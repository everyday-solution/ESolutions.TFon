using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using JulMar.Atapi;
using System.ComponentModel;

namespace ESolutions.TFon.Tapi
{
	public class TapiController : IDisposable, INotifyPropertyChanged
	{
		//Fields
		#region manager
		/// <summary>
		/// The wrapped tapi manager.
		/// </summary>
		private TapiManager innerManager = null;
		#endregion

		#region default
		private static TapiController defaultController = new TapiController();
		#endregion

		#region isMonitoring
		private Boolean isMonitoring = false;
		#endregion

		//Properties
		#region Default
		/// <summary>
		/// Gets the default controller for the application.
		/// </summary>
		/// <value>The default.</value>
		public static TapiController Default
		{
			get
			{
				return TapiController.defaultController;
			}
		}
		#endregion

		#region Events
		/// <summary>
		/// Gets a lists of all tapi line events that occured after calling the StartMonitoringPhones method.
		/// </summary>
		/// <value>The events.</value>
		public ObservableCollection<TapiEventLogEntry> Events
		{
			get;
			private set;
		}
		#endregion

		#region AllCalls
		/// <summary>
		/// Gets a lists of all calls that were montitore since the StartMonitoringPhone mehtod was called.
		/// </summary>
		/// <value>The events.</value>
		public ObservableCollection<Call> AllCalls
		{
			get;
			private set;
		}
		#endregion

		#region ActiveCalls
		/// <summary>
		/// Gets a lists of all calls that are currently active
		/// </summary>
		/// <value>The events.</value>
		public ThreadSafeObservableCollection<Call> ActiveCalls
		{
			get;
			private set;
		}
		#endregion

		//Constructors
		#region TapiController
		private TapiController()
		{
			this.Events = new ObservableCollection<TapiEventLogEntry>();
			this.AllCalls = new ObservableCollection<Call>();
			this.ActiveCalls = new ThreadSafeObservableCollection<Call>();

			this.innerManager = new TapiManager(Guid.NewGuid().ToString());
			this.innerManager.Initialize();
		}
		#endregion

		//Events
		#region PropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		//Methods
		#region Dispose
		public void Dispose()
		{
			this.StopMonitoringPhones();
		}
		#endregion

		#region OnPropertyChanged
		protected void OnPropertyChanged(String propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion

		#region StartMonitoringPhones
		/// <summary>
		/// Starts the monitoring all TAPI lines that can be used as phones.
		/// </summary>
		public void StartMonitoringPhones()
		{
			if (this.isMonitoring == false)
			{
				var phoneLines = from current in this.innerManager.Lines
									  where current.Capabilities.BearerModes == BearerModes.Voice
									  && current.Capabilities.SupportsVoiceCalls
									  && current.IsValid
									  select current;

				foreach (TapiLine current in phoneLines)
				{
					current.AddressChanged += new EventHandler<AddressInfoChangeEventArgs>(AnyPhoneLine_AddressChanged);
					current.CallInfoChanged += new EventHandler<CallInfoChangeEventArgs>(AnyPhoneLine_CallInfoChanged);
					current.CallStateChanged += new EventHandler<CallStateEventArgs>(AnyPhoneLine_CallStateChanged);
					current.Changed += new EventHandler<LineInfoChangeEventArgs>(AnyPhoneLine_Changed);
					current.NewCall += new EventHandler<NewCallEventArgs>(AnyPhoneLine_NewCall);
					current.Ringing += new EventHandler<RingEventArgs>(AnyPhoneLine_Ringing);
					current.Monitor();
				}

				this.isMonitoring = true;
			}
		}
		#endregion

		#region StopMonitoringPhones
		/// <summary>
		/// Stops all monitorings.
		/// </summary>
		public void StopMonitoringPhones()
		{
			if (this.innerManager != null && this.isMonitoring)
			{
				this.innerManager.Shutdown();
				this.isMonitoring = false;
			}
		}
		#endregion

		#region AnyPhoneLine_AddressChanged
		void AnyPhoneLine_AddressChanged(object sender, AddressInfoChangeEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Address.Line.Name,
				-1,
				TapiEvents.AddressChanged,
				e.Change.ToString());
			this.Events.Insert(0, entry);
		}
		#endregion

		#region AnyPhoneLine_CallInfoChanged
		void AnyPhoneLine_CallInfoChanged(object sender, CallInfoChangeEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Call.Line.Name,
				e.Call.GetHashCode(),
				TapiEvents.CallInfoChanged,
				e.Change.ToString());
			this.Events.Insert(0, entry);
		}
		#endregion

		#region AnyPhoneLine_CallStateChanged
		void AnyPhoneLine_CallStateChanged(object sender, CallStateEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Call.Line.Name,
				e.Call.GetHashCode(),
				TapiEvents.CallStateChanged,
				String.Format("old: {0} new: {1}", e.OldCallState, e.CallState));
			this.Events.Insert(0, entry);

			switch (e.CallState)
			{
				case CallState.Connected:
				{
					this.PickUpCall(e);
					break;
				}

				case CallState.Disconnected:
				{
					this.HangUpCall(e);
					break;
				}

				case CallState.Ringback:
				{
					this.NewOutgoingCall(e);
					break;
				}

				case CallState.Accepted:
				{
					this.NewIncomingCall(e);
					break;
				}
			}
		}
		#endregion

		#region NewIncomingCall
		private void NewIncomingCall(CallStateEventArgs e)
		{
			Call newCall = new Call(e.Call);
			this.AllCalls.Insert(0, newCall);
			this.ActiveCalls.Insert(0, newCall);
		}
		#endregion

		#region NewOutgoingCall
		private void NewOutgoingCall(CallStateEventArgs e)
		{
			Call newCall = new Call(e.Call);
			this.AllCalls.Insert(0, newCall);
			this.ActiveCalls.Insert(0, newCall);
		}
		#endregion

		#region HangUpCall
		private void HangUpCall(CallStateEventArgs e)
		{
			var disconnectedCall = (from current in this.AllCalls
											where current.Id == e.Call.GetHashCode()
											select current).FirstOrDefault();
			if (disconnectedCall != null)
			{
				disconnectedCall.HangUp();
				this.ActiveCalls.Remove(disconnectedCall);
			}

			this.OnPropertyChanged(nameof(ActiveCalls));
		}
		#endregion

		#region PickUpCall
		private void PickUpCall(CallStateEventArgs e)
		{
			var acceptedCall = (from current in this.AllCalls
									  where current.Id == e.Call.GetHashCode()
									  select current).FirstOrDefault();
			if (acceptedCall != null)
			{
				acceptedCall.PickUp();
			}

			this.OnPropertyChanged(nameof(ActiveCalls));
		}
		#endregion

		#region AnyPhoneLine_Changed
		void AnyPhoneLine_Changed(object sender, LineInfoChangeEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Line.Name,
				-1,
				TapiEvents.Changed,
				e.Change.ToString());
			this.Events.Insert(0, entry);
		}
		#endregion

		#region AnyPhoneLine_NewCall
		void AnyPhoneLine_NewCall(object sender, NewCallEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Call.Line.Name,
				e.Call.GetHashCode(),
				TapiEvents.NewCall,
				e.Call.CallState.ToString());
			this.Events.Insert(0, entry);
		}
		#endregion

		#region AnyPhoneLine_Ringing
		void AnyPhoneLine_Ringing(object sender, RingEventArgs e)
		{
			TapiEventLogEntry entry = new TapiEventLogEntry(
				e.Line.Name,
				 -1,
				TapiEvents.Ringing,
				e.RingCount.ToString());
			this.Events.Insert(0, entry);
		}
		#endregion

		#region CallNumber
		public void CallNumber(string phoneNumber)
		{
			var phoneLines = from current in this.innerManager.Lines
								  where current.Capabilities.BearerModes == BearerModes.Voice
								  && current.Capabilities.SupportsVoiceCalls
								  && current.IsValid
								  select current;
			var phoneLine = phoneLines.FirstOrDefault();

			if (phoneLine != null)
			{
				String dialablePhoneNumber = phoneNumber.TrimPhoneNumber().Replace("0049", "0");
				phoneLine.Addresses.First().MakeCall(dialablePhoneNumber);
			}
		}
		#endregion
	}
}
