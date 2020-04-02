using System;

namespace Bnp.Pricer.Data.Calculators.Formulas
{
	/// <summary>
	/// Represent the D1 formula class
	/// </summary>
	public sealed class D1Formula : Formula
	{
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
		/// Gets / Sets the risk interest
		/// </summary>
		public decimal RiskInterest
		{ 
			get; 
			set; 
		}

		/// <summary>
		/// Gets / Sets the standard deviation
		/// </summary>
		public decimal StandardDeviation
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
		/// Compute the d1 parameter
		/// </summary>
		/// <remarks>
		///		<para>
		///			
		///                 ln( StockPrice / StrikePrice ) + ( RiskInterest + (Deviation^2) / 2 ) * Maturity
		///		    d1 = ______________________________________________________________________________________
		///		                       Deviation * Square( Maturity );
		///		</para>
		/// </remarks>
		public override void Calculate()
		{
			decimal numerator   = 0;
			decimal denominator = 0;

			numerator =  MathFunctions.Logarithm( StockPrice / StrikePrice );
			numerator+= ( RiskInterest + ( MathFunctions.PowerSquare( StandardDeviation ) ) / 2 ) * Time;
			
			denominator = StandardDeviation * MathFunctions.SquareRoot( Time );

			//if ( denominator == 0 )
			//{
			//	throw new FormulaException( nameof(D1Formula) + " illegal denominator " );
			//}

			SetResult( numerator / denominator );
		}
	}
}
