using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using PIM = Microsoft.Office.Interop.Outlook;

namespace ESolutions.TFon.Tapi.Resolvers
{
	public class OutlookPhoneNumberResolver : IPhoneNumberResolver
	{
		//Fields
		#region number
		private String number = String.Empty;
		#endregion

		#region resolveThread
		private Thread resolveThread = null;
		#endregion

		#region contactCache
		private PIM.Items contactCache = null;
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
			this.number = number.TrimPhoneNumber();

			this.resolveThread = new Thread(new ThreadStart(this.ResolveNumberStart));
			resolveThread.Start();
		}
		#endregion

		#region ResolveNumberStart
		/// <summary>
		/// Resolves the number begin.
		/// </summary>
		private void ResolveNumberStart()
		{
			try
			{
				if (this.contactCache == null)
				{
					var outlookApplication = new PIM.Application();
					PIM.NameSpace mapiNamespace = outlookApplication.GetNamespace("MAPI");
					PIM.MAPIFolder contactFolder = mapiNamespace.GetDefaultFolder(PIM.OlDefaultFolders.olFolderContacts);
					this.contactCache = contactFolder.Items;
				}

				foreach (PIM.ContactItem current in this.contactCache)
				{
					if (
						current.MobileTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.PrimaryTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.BusinessTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.Business2TelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.CompanyMainTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.HomeTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.Home2TelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.OtherTelephoneNumber.TrimPhoneNumber().Equals(this.number) ||
						current.RadioTelephoneNumber.TrimPhoneNumber().Equals(this.number))
					{
						String tempFileName = null;
						foreach (PIM.Attachment currentAttachment in current.Attachments)
						{
							if (currentAttachment.DisplayName == "ContactPicture.jpg")
							{
								tempFileName = Path.GetTempFileName() + ".jpg";
								currentAttachment.SaveAsFile(tempFileName);
							}
						}

						this.OnPhoneNumberResolved(current.FirstName + " " + current.LastName, tempFileName);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
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