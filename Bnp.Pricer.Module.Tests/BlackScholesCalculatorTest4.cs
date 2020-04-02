using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTest4
	{
		private BlackScholesCalculator					_calculator = null;
		private BlackScholesCalculatorPricingResults	_result		= null;

		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();

			_result     = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData( 45 , 23 , 0.10M , 0.15M , 123M ) );
		}

		[TestMethod]
		public void AssertD1()
		{
			Assert.AreEqual( 12.4616M , _result.D1.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertD2()
		{
			Assert.AreEqual( 12.4035M , _result.D2.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertCallOption()
		{
			Assert.AreEqual( 23.1337M , _result.CallOption.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertPutOption()
		{
			Assert.AreEqual( 0M , _result.PutOption.ToRound( 4 ) );
		}
	}
}
