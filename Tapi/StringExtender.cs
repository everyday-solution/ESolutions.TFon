using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ESolutions.TFon.Tapi
{
	public static class StringExtender
	{
		#region TrimPhoneNumber
		public static String TrimPhoneNumber(this String input)
		{
			String result = String.Empty;

			try
			{
				if (input != null)
				{
					//Replace leading + by double zero
					if (input.StartsWith("+"))
					{
						input = input.Replace("+", "00");
					}

					//if the input does not start with a country code insert the
					//german country code and trims the leading zero of the area code.
					if (!input.StartsWith("00"))
					{
						input = input.TrimStart('0');
						input = input.Insert(0, "0049");
					}

					//Take digits from input
					foreach (Char current in input.ToCharArray())
					{
						if (current >= '0' && current <= '9')
						{
							result += current;
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new ConverterException("Number could not be stripped to standard format", ex);
			}

			return result;
		}
		#endregion
	}
}
