using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Windows
{
	public static class TimeSpanExtender 
	{
		#region ToShortTimeString
		public static String ToShortTimeString(this TimeSpan value)
		{
			return String.Format(
				"{0}:{1}:{2}",
				value.Hours.ToString("00"),
				value.Minutes.ToString("00"),
				value.Seconds.ToString("00"));
		}
		#endregion
	}
}
