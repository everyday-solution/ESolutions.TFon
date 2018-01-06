using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ESolutions.TFon.Tapi.Resolvers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESolutions.TFon.Tests
{
	[TestClass]
	public class KlickTelPhoneNumberResolverTest
	{
		#region resolvedNumber
		private IPhoneNumberResolvedEventArgs resolvedNumber = null;
		#endregion

		[TestMethod]
		public void TestThatNumberCanBeResolvedUsingKlicktel()
		{
			KlicktelPhoneNumberResolver resolver = new KlicktelPhoneNumberResolver();
			resolver.PhoneNumberResolved += new PhoneNumberResolvedEventHandler(resolver_PhoneNumberResolved);
			resolver.BeginResolvingPhoneNumber("040 123456");
			resolver.WaitForSearch();

			Assert.IsNotNull(this.resolvedNumber);
			Assert.AreEqual("Testfirma", this.resolvedNumber.Name);
		}

		void resolver_PhoneNumberResolved(IPhoneNumberResolvedEventArgs e)
		{
			this.resolvedNumber = e;
		}
	}
}
