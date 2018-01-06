using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Tapi
{
	public class TapiEventLogEntry
	{
		//Properties
		#region Time
		public DateTime Time
		{
			get;
			private set;
		}
		#endregion

		#region LineName
		public String LineName
		{
			get;
			private set;
		}
		#endregion

		#region CallHash
		public Int32 CallHash
		{
			get;
			private set;
		}
		#endregion

		#region Event
		public TapiEvents Event
		{
			get;
			private set;
		}
		#endregion

		#region Message
		public String Message
		{
			get;
			private set;
		}
		#endregion

		//Constructors
		#region TapiEventLogEntry
		public TapiEventLogEntry(
			String lineName,
			Int32 callHash,
			TapiEvents tapiEvent,
			String message)
		{
			this.Time = DateTime.Now;
			this.LineName = lineName;
			this.CallHash = callHash;
			this.Event = tapiEvent;
			this.Message = message;
		}
		#endregion
	}
}
