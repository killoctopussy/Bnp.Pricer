using System;

namespace Bnp.Pricer.Data.Calculators.Formulas
{
	/// <summary>
	/// Represent the D2 formula class
	/// </summary>
	public sealed class D2Formula : Formula
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
		/// Compute the d2 parameter
		/// </summary>
		/// <remarks>
		///		<para>
		///			 d2 = d1 - Deviation * SquareRoot( Maturity );
		///		</para>
		/// </remarks>
		public override void Calculate()
		{
			SetResult(  D1 - ( StandardDeviation * MathFunctions.SquareRoot( Time ) ) );
		}
	}
}
