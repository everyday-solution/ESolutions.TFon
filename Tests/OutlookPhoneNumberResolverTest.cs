using ESolutions.TFon.Tapi.Resolvers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ESolutions.TFon.Tests
{
	/// <summary>
	///This is a digits class for OutlookPhoneNumberResolverTest and is intended
	///to contain all OutlookPhoneNumberResolverTest Unit Tests
	///</summary>
	[TestClass()]
	public class OutlookPhoneNumberResolverTest
	{
		#region resolvedNumber
		private IPhoneNumberResolvedEventArgs resolvedNumber = null;
		#endregion

		/// <summary>
		///A digits for ResolveNumberStart
		///</summary>
		[TestMethod()]
		[DeploymentItem("ESolutions.TFon.exe")]
		public void TestThatNumberCanBeSolvedUsingOutlook()
		{
			OutlookPhoneNumberResolver resolver = new OutlookPhoneNumberResolver();
			resolver.PhoneNumberResolved += new PhoneNumberResolvedEventHandler(resolver_PhoneNumberResolved);
			resolver.BeginResolvingPhoneNumber("0151 1234567890");
			resolver.WaitForSearch();

			Assert.IsNotNull(this.resolvedNumber);
			Assert.AreEqual("Tobias Mundt", this.resolvedNumber.Name);
		}

		void resolver_PhoneNumberResolved(IPhoneNumberResolvedEventArgs e)
		{
			this.resolvedNumber = e;
		}
	}
}
