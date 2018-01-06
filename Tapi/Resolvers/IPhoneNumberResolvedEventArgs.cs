using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Tapi.Resolvers
{
	public interface IPhoneNumberResolvedEventArgs
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		String Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
		String Image
		{
			get;
			set;
		}
	}
}
