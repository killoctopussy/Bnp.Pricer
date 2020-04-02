using System;

namespace Bnp.Pricer.Data.Calculators.Formulas
{
	/// <summary>
	/// Represent the call option formula class
	/// </summary>
	public sealed class CallOptionFormula : Formula
	{
		/// <summary>
		/// Gets / Sets the d1 parameter
		/// </summary>
		public decimal D1
		{ 
			get;
			set;
		}

		/// <summary>
		/// Gets / Sets the d2 parameter
		/// </summary>
		public decimal D2
		{ 
			get;
			set;
		}

		/// <summary>
		/// Gets / Sets the stock price
		/// </summary>
		public decimal StockPrice 
		{ 
			get;
			set;
		}

		/// <summary>
		/// Gets / Sets strike price
		/// </summary>
		public decimal StrikePrice
		{ 
			get;
			set;
		}

		/// <summary>
		/// Gets / Sets the time
		/// </summary>
		public decimal Time
		{ 
			get;
			set;
		}

		/// <summary>
		/// Gets / Sets the risk interest
		/// </summary>
		public decimal RiskInterest
		{ 
			get;
			set;
		}

		/// <summary>
		/// Compute the d1 parameter
		/// </summary>
		/// <remarks> 
		///		<para>
		///			c = StockPrice * N( D1 )      -     StrikePrice * (exp ( - RiskInterest * Time ) ) * N( D2 )
		///		</para>
		/// </remarks>
		public override void Calculate()
		{
			SetResult( StockPrice  *  MathFunctions.CumulativeDistribution( D1 )
 				     - StrikePrice * (MathFunctions.Exponantial( - RiskInterest * Time ) ) * MathFunctions.CumulativeDistribution( D2 )
					 );
		}
	}
}
