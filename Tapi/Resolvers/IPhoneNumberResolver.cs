using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Tapi.Resolvers
{
	/// <summary>
	/// Interface of plugins that are able to resolve numbers to names.
	/// </summary>
	public interface IPhoneNumberResolver
	{
		/// <summary>
		/// Begins the resolving phone number. The PhoneNumberResolved is fired
		/// when the number is resolved.
		/// </summary>
		/// <param name="number">The number.</param>
		void BeginResolvingPhoneNumber(String number);

		/// <summary>
		/// Occurs after the phone number was resolved to the name of the called.
		/// </summary>
		event PhoneNumberResolvedEventHandler PhoneNumberResolved;
	}
}
