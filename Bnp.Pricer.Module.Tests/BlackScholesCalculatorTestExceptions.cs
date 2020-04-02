using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTestExceptions
	{
		private BlackScholesCalculator _calculator = null;
		
		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();
		}

		[TestMethod]
		public void AssertNullArgumentException()
		{
			Assert.ThrowsException<ArgumentNullException>( () => _calculator.Calculate( null ) );
		}
	}
}
