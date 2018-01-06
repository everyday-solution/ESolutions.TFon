using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Net;
using System.Xml.Linq;

namespace ESolutions.TFon.Tapi.Resolvers
{
	public class KlicktelPhoneNumberResolver : IPhoneNumberResolver
	{
		//Consts
		#region klicktelUriPattern
		private const String klicktelUriPattern = "http://webservice.telegate.com/de/1.0/ReverseSearch.php?_dvform_posted=1&phone_number={0}&key=test_webinvers&spriv=1&sbus=1&sgov=1";
		#endregion

		//Fields
		#region number
		private String number = String.Empty;
		#endregion

		#region resolveThread
		private Thread resolveThread = null;
		#endregion

		//Events
		#region PhoneNumberResolved
		/// <summary>
		/// Occurs after the phone number was resolved to the name of the called.
		/// </summary>
		public event PhoneNumberResolvedEventHandler PhoneNumberResolved;
		#endregion

		//Methods
		#region BeginResolvingPhoneNumber
		/// <summary>
		/// Begins the resolving phone number. The PhoneNumberResolved is fired
		/// when the number is resolved.
		/// </summary>
		/// <param name="number">The number.</param>
		public void BeginResolvingPhoneNumber(string number)
		{
			this.number = number;

			this.resolveThread = new Thread(new ThreadStart(this.ResolveNumberStart));
			resolveThread.Start();
		}
		#endregion

		#region ResolveNumberStart
		/// <summary>
		/// Resolves the number begin.
		/// </summary>
		public void ResolveNumberStart()
		{
			try
			{
				WebClient client = new WebClient();
				client.Credentials = new NetworkCredential("everyday_solutions", "eiCez7Ed");
				String queryUri = String.Format(klicktelUriPattern, this.number);
				Byte[] rawData = client.DownloadData(queryUri);
				String content = Encoding.UTF8.GetString(rawData);

				XDocument doc = XDocument.Parse(content);
				XNamespace nameSpace = "http://webservice.telegate.com";
				var nodes = from current in doc.Descendants(nameSpace + "displayname")
							  select current;

				if (nodes == null || nodes.Count() <= 0)
				{
					throw new Exception();
				}

				String name = String.Empty;
				foreach (XElement current in nodes)
				{
					name += current.Value + " - ";
				}
				name = name.TrimEnd(' ', '-');
				this.OnPhoneNumberResolved(name, null);
			}
			catch
			{
			}
		}
		#endregion

		#region OnPhoneNumberResolved
		/// <summary>
		/// Called when [phone number resolved].
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="image">The image.</param>
		protected void OnPhoneNumberResolved(String name, String image)
		{
			if (this.PhoneNumberResolved != null)
			{
				PhoneNumberResolvedEventArgs e = new PhoneNumberResolvedEventArgs(name, image);
				this.PhoneNumberResolved(e);
			}
		}
		#endregion

		#region WaitForSearch
		public void WaitForSearch()
		{
			this.resolveThread.Join();
		}
		#endregion
	}
}