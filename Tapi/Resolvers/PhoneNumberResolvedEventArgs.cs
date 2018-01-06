using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESolutions.TFon.Tapi.Resolvers
{
	/// <summary>
	/// 
	/// </summary>
	public class PhoneNumberResolvedEventArgs : IPhoneNumberResolvedEventArgs
	{
		//Properties
		#region Name
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public String Name
		{
			get;
			set;
		}
		#endregion

		#region Image
		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
		public String Image
		{
			get;
			set;
		}
		#endregion

		//Constructors
		#region PhoneNumberResolvedEventArgs
		public PhoneNumberResolvedEventArgs(String name, String image)
		{
			this.Name = name;
			this.Image = image;
		}
		#endregion
	}
}
