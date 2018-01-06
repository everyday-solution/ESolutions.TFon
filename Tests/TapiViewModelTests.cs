using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESolutions.TFon;

namespace ESolutions.TFon.Tests
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestClass]
	public class TapiViewModelTests
	{
		#region TapiViewModelTests
		public TapiViewModelTests()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion

		#region testContextInstance
		private TestContext testContextInstance;
		#endregion

		#region TestContext
		/// <summary>
		///Gets or sets the digits context which provides
		///information about and functionality for the current digits run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}
		#endregion

		#region Additional digits attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first digits in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in addDelegate class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each digits 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each digits has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

	}
}
