using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;

namespace ESolutions.TFon.Tapi
{
	public class Call : INotifyPropertyChanged, IDisposable
	{
		//Enums
		#region Directions
		public enum Directions
		{
			Incoming,
			Outgoing
		}
		#endregion

		//Fields
		#region innerCall
		private JulMar.Atapi.TapiCall innerCall = null;
		#endregion

		#region durationTimer
		private System.Timers.Timer durationTimer = new System.Timers.Timer();
		#endregion

		#region wasPickedUp
		private Boolean wasPickedUp = false;
		#endregion

		#region duration
		private TimeSpan duration = TimeSpan.Zero;
		#endregion

		#region isActive
		private Boolean isActive = false;
		#endregion

		#region isRinging
		private Boolean isRinging = false;
		#endregion

		#region numberOfCounterpart
		private String numberOfCounterpart = String.Empty;
		#endregion

		#region nameOfCounterpart
		private String nameOfCounterpart = String.Empty;
		#endregion

		#region pictureOfCounterpart
		private String pictureOfCounterpart = null;
		#endregion

		#region direction
		private Directions direction = Directions.Incoming;
		#endregion

		#region note
		private String note = String.Empty;
		#endregion

		//Properties
		#region Id
		/// <summary>
		/// Gets or sets the id primary id of the call.
		/// </summary>
		/// <value>The id.</value>
		/// <remarks>
		/// Since the call objectes are build from a JulMar.TapiCall this is the HastCode of the
		/// TapiCall object
		/// </remarks>
		public Int32 Id
		{
			get;
			private set;
		}
		#endregion

		#region Direction
		public Directions Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
				this.OnPropertyChanged("Direction");
			}
		}
		#endregion

		#region NumberOfCounterpart
		/// <summary>
		/// Gets or sets the number of counterpart calling or beeing called.
		/// </summary>
		/// <value>The number of counterpart.</value>
		public String NumberOfCounterpart
		{
			get
			{
				return this.numberOfCounterpart;
			}
			private set
			{
				this.numberOfCounterpart = value;
				this.OnPropertyChanged("NumberOfCounterpart");
			}
		}
		#endregion

		#region NameOfCounterpart
		public String NameOfCounterpart
		{
			get
			{
				return this.nameOfCounterpart;
			}
			set
			{
				this.nameOfCounterpart = value;
				this.OnPropertyChanged("NameOfCounterpart");
			}
		}
		#endregion

		#region PictureOfCounterpart
		public String PictureOfCounterpart
		{
			get
			{
				return this.pictureOfCounterpart;
			}
			set
			{
				this.pictureOfCounterpart = value;
				this.OnPropertyChanged("PictureOfCounterpart");
			}
		}
		#endregion

		#region Time
		/// <summary>
		/// Gets or sets the time the call came in or went out.
		/// </summary>
		/// <value>The time.</value>
		public DateTime Time
		{
			get;
			private set;
		}
		#endregion

		#region Duration
		/// <summary>
		/// Gets or sets the duration of the call since it was picked up.
		/// </summary>
		/// <value>The duration.</value>
		public TimeSpan Duration
		{
			get
			{
				return this.duration;
			}
			private set
			{
				this.duration = value;
				this.OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region WasPickedUp
		/// <summary>
		/// Gets or sets a value indicating whether the  call was answered or was made during beeing away
		/// </summary>
		/// <value><c>true</c> if [was picked up]; otherwise, <c>false</c>.</value>
		public Boolean WasPickedUp
		{
			get
			{
				return this.wasPickedUp;
			}
			private set
			{
				this.wasPickedUp = value;
				this.OnPropertyChanged("WasPickedUp");
			}
		}
		#endregion

		#region IsActive
		/// <summary>
		/// Gets a value indicating whether the conversation is still going on.
		/// </summary>
		/// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
		public Boolean IsActive
		{
			get
			{
				return this.isActive;
			}
			set
			{
				this.isActive = value;
				this.OnPropertyChanged("IsActive");
			}
		}
		#endregion

		#region IsRinging
		/// <summary>
		/// Gets a value indicating whether the conversation is still going on.
		/// </summary>
		/// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
		public Boolean IsRinging
		{
			get
			{
				return this.isRinging;
			}
			set
			{
				this.isRinging = value;
				this.OnPropertyChanged("IsRinging");
			}
		}
		#endregion

		#region Note
		/// <summary>
		/// Gets or sets the note.
		/// </summary>
		/// <value>
		/// The note.
		/// </value>
		public String Note
		{
			get
			{
				return this.note;
			}
			set
			{
				this.note = value;
				this.OnPropertyChanged("Note");
			}
		}
		#endregion

		//Constructors
		#region Call
		public Call(JulMar.Atapi.TapiCall call)
		{
			this.innerCall = call;
			this.Id = call.GetHashCode();
			this.Time = DateTime.Now;
			this.NumberOfCounterpart = call.CallState == JulMar.Atapi.CallState.Ringback ? call.CalledId : call.CallerId;
			this.NameOfCounterpart = this.NumberOfCounterpart;

			this.direction = call.CallOrigin ==
				JulMar.Atapi.CallOrigins.Outbound
				? Directions.Outgoing :
				Directions.Incoming;

			Resolvers.IPhoneNumberResolver resolver1 = new Resolvers.OutlookPhoneNumberResolver();
			resolver1.PhoneNumberResolved += new Resolvers.PhoneNumberResolvedEventHandler(Resolver_PhoneNumberResolved);
			resolver1.BeginResolvingPhoneNumber(this.NumberOfCounterpart);

			Resolvers.IPhoneNumberResolver resolver2 = new Resolvers.KlicktelPhoneNumberResolver();
			resolver2.PhoneNumberResolved += new Resolvers.PhoneNumberResolvedEventHandler(Resolver_PhoneNumberResolved);
			resolver2.BeginResolvingPhoneNumber(this.NumberOfCounterpart);
		}
		#endregion

		//Events
		#region PropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		//Methods
		#region OnPropertyChanged
		protected void OnPropertyChanged(String propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion

		#region PickUp
		/// <summary>
		/// Marks the call as answered and
		/// </summary>
		public void PickUp()
		{
			this.IsActive = true;
			this.WasPickedUp = true;
			this.IsRinging = false;

			this.durationTimer.Interval = 1000;
			this.durationTimer.Elapsed += new System.Timers.ElapsedEventHandler(DurationTimer_Elapsed);
			this.durationTimer.Start();
		}
		#endregion

		#region Resolver_PhoneNumberResolved
		void Resolver_PhoneNumberResolved(Resolvers.IPhoneNumberResolvedEventArgs e)
		{
			this.NameOfCounterpart = e.Name;
			this.PictureOfCounterpart = e.Image;
		}
		#endregion

		#region DurationTimer_Elapsed
		void DurationTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			this.Duration = DateTime.Now - this.Time;
		}
		#endregion

		#region HangUp
		public void HangUp()
		{
			this.durationTimer.Stop();
			this.IsActive = false;
			this.IsRinging = false;
		}
		#endregion

		#region Dispose
		public void Dispose()
		{
			File.Delete(this.PictureOfCounterpart);
		}
		#endregion

		#region HandOver
		public void HandOver(string number)
		{
			this.innerCall.BlindTransfer(number, 0);
		}
		#endregion
	}
}
