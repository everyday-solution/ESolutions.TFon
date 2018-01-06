using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Tapi
{
	public class SingleEvent
	{
		#region Time
		public DateTime Time
		{
			get;
			set;
		}
		#endregion

		#region LineName
		public String LineName
		{
			get;
			set;
		}
		#endregion

		#region CallHandle
		public Int32 CallHandle
		{
			get;
			set;
		}
		#endregion

		#region EventName
		public String EventName
		{
			get;
			set;
		}
		#endregion

		#region Message
		public String Message
		{
			get;
			set;
		}
		#endregion

		#region SingleEvent
		public SingleEvent()
		{
			this.Time = DateTime.Now;
		}
		#endregion
	}
}
