using System;

namespace Bnp.Pricer.Data.Calculators
{
	using Bnp.Pricer.Data.Calculators.Formulas;

	/// <summary>
	/// Represent a back scholes calculator
	/// </summary>
	public sealed class BlackScholesCalculator 
		: ICalculator<BlackScholesCalculatorPricingData,BlackScholesCalculatorPricingResults>
	{
		/// <summary>
		/// Run a calculation
		/// </summary>
		/// <param name="data">the input data</param>
		/// <returns>Returns the output results</returns>
		/// <exception cref="ArgumentNullException"/>
		public BlackScholesCalculatorPricingResults Calculate( BlackScholesCalculatorPricingData data )
		{
			if ( null == data )
			{
				throw new ArgumentNullException( nameof( data ) );
			}

			var d1 = new D1Formula()
			{
				StockPrice		  = data.StockPrice,
				StrikePrice		  = data.StrikePrice,
				Time			  = data.Time ,
				StandardDeviation = data.StandardDeviation ,
				RiskInterest	  = data.RiskInterest ,
			};
			
			d1.Calculate();

			var d2 = new D2Formula()
			{
				D1				  = d1.Result,
				StandardDeviation = data.StandardDeviation ,
				Time			  = data.Time ,
			};
			
			d2.Calculate();

			var callOption = new CallOptionFormula()
			{
				D1				  = d1.Result ,
				D2				  = d2.Result ,
				StockPrice		  = data.StockPrice ,
				StrikePrice		  = data.StrikePrice ,
				Time			  = data.Time,
				RiskInterest	  = data.RiskInterest ,
			};

			callOption.Calculate();

			var putOption = new PutOptionFormula()
			{
				D1				  = d1.Result ,
				D2				  = d2.Result ,
				StockPrice		  = data.StockPrice ,
				StrikePrice		  = data.StrikePrice ,
				Time			  = data.Time,
				RiskInterest	  = data.RiskInterest,
			};
			
			putOption.Calculate();

			return new BlackScholesCalculatorPricingResults( d1.Result , d2.Result , callOption.Result , putOption.Result );
		}
	}
}
