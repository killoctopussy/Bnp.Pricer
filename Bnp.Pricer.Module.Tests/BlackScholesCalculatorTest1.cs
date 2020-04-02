using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTest1
	{
		private BlackScholesCalculator					_calculator = null;
		private BlackScholesCalculatorPricingResults	_result		= null;

		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();
			
			_result     = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData( 50 , 55 , 0.2M , 0.09M , 365M ) );
		}

		[TestMethod]
		public void AssertD1()
		{
			Assert.AreEqual( 0.0734M , _result.D1.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertD2()
		{
			Assert.AreEqual( -0.1266M , _result.D2.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertCallOption()
		{
			Assert.AreEqual( 3.8617M , _result.CallOption.ToRound( 4 ) );
		}

		[TestMethod]
		public void AssertPutOption()
		{
			Assert.AreEqual( 4.1279M , _result.PutOption.ToRound( 4 ) );
		}
	}
}
