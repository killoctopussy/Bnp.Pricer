using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTest3
	{
		private BlackScholesCalculator					_calculator = null;
		private BlackScholesCalculatorPricingResults	_result		= null;

		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();

			_result     = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData( 28 , 30 , 0.37M , 0.15M , 251M ) );
		}

		[TestMethod]
		public void AssertD1()
		{
			Assert.AreEqual( 0.2647M , _result.D1.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertD2()
		{
			Assert.AreEqual(-0.0421M , _result.D2.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertCallOption()
		{
			Assert.AreEqual( 3.8474M , _result.CallOption.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertPutOption()
		{
			Assert.AreEqual( 2.9071M , _result.PutOption.ToRound( 4 ) );
		}
	}
}
