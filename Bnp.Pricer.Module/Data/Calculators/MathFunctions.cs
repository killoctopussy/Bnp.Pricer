using System;

namespace Bnp.Pricer.Data.Calculators
{
	/// <summary>
	/// Represent the helpers methods. The idea of thus class is to stay in the way of writing / translating formla more "standard".
	/// </summary>
	/// <remarks>
	///		<para>If you just look on all formula statement implementation, the calculation statements used math static methods.</para>
	///		<para>I have decided to preserved this philosophy to used core math function defined as static lile the <see cref="Math"/> class.</para>
	///		<para>This function is not used has a <see cref="IFormula"/>. It can be wrapped into a formula object.</para>
	///		<para>The actual version of C# does not allow to provided extensions method to STATIC class.</para>
	///		<para>Perphaps the better approach, is to create a static class which that static Maths statis methods. </para>
	///		<para>But, I have prefered to exposed has a static method, because on all <see cref="IFormula.Calculate"/> method, this method used <see cref="Math"/> static methods/</para>
	///		<para>So, in terms of readability, I thinks it'is better to used on the formula implemtation static methods in formula statements.</para>
	///		<para/>
	///		<example>
	///		<para>This class is used to avoid code like that:</para>
	///		<code>
	///			double result = Math.Log( x ) * Algos.CalcDistrib( x ) + Heplers.CalcSomething(x) ;
	///		</code>
	///		<para>The prefered approach is:</para>
	///		<code>
	///			double result = PricerMath.Log( x ) * PricerMath.CalcDistrib( x ) + PricerMath.CalcSomething(x) ;
	///		</code>
	///		</example>
	/// </remarks>
	public static class MathFunctions
	{
		/// <summary>
		/// Calculate the power of x^y
		/// </summary>
		/// <param name="x">the x number</param>
		/// <param name="y">the power value</param>
		/// <returns>Returns a value</returns>
		public static double Power( double x , double y )
		{
			return Math.Pow( x , y );
		}

		/// <summary>
		/// Calculate the power of x^y
		/// </summary>
		/// <param name="x">the x number</param>
		/// <param name="y">the power value</param>
		/// <returns>Returns a value</returns>
		public static decimal Power( decimal x , decimal y)
		{
			return Convert.ToDecimal( Math.Pow( Convert.ToDouble( x ) , Convert.ToDouble( y ) ) );
		}

		/// <summary>
		/// Calculate the power of x^2
		/// </summary>
		/// <param name="x">the x number</param>
		/// <returns>Returns a value</returns>
		public static double PowerSquare( double x )
		{
			return Math.Pow( x , 2 );
		}

		/// <summary>
		/// Calculate the power of x^2
		/// </summary>
		/// <param name="x">the x number</param>
		/// <returns>Returns a value</returns>
		public static decimal PowerSquare( decimal x )
		{
			return Convert.ToDecimal( Math.Pow( Convert.ToDouble( x ) , 2 ) );
		}

		/// <summary>
		/// Calculate the log
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static double Logarithm( double value )
		{
			return Math.Log( value );
		}

		/// <summary>
		/// Calculate the log
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static decimal Logarithm( decimal value )
		{
			return Convert.ToDecimal( Math.Log( Convert.ToDouble( value ) ) );
		}

		/// <summary>
		/// Calculate the square root
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static double SquareRoot( double value )
		{
			return Math.Sqrt( value );
		}

		/// <summary>
		/// Calculate the square root
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static decimal SquareRoot( decimal value )
		{
			return Convert.ToDecimal( Math.Sqrt( Convert.ToDouble( value ) ) );
		}

		/// <summary>
		/// Calculate the exponantial
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static double Exponantial( double value )
		{
			return Math.Exp( value );
		}

		/// <summary>
		/// Calculate the exponantial
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static decimal Exponantial( decimal value )
		{
			return Convert.ToDecimal( Math.Exp( Convert.ToDouble( value ) ) );
		}

		/// <summary>
		/// Calculate the round
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static double Round( double value )
		{
			return Math.Round( value );
		}

		/// <summary>
		/// Calculate the round
		/// </summary>
		/// <param name="value">the x number</param>
		/// <param name="digits">the number of digits</param>
		/// <returns>Returns a value</returns>
		public static double Round( double value , int digits )
		{
			return Math.Round( value , digits );
		}

		/// <summary>
		/// Calculate the round
		/// </summary>
		/// <param name="value">the x number</param>
		/// <returns>Returns a value</returns>
		public static decimal Round( decimal value )
		{
			return Convert.ToDecimal( Math.Round( Convert.ToDouble( value ) ) );
		}

		/// <summary>
		/// Calculate the round
		/// </summary>
		/// <param name="value">the x number</param>
		/// <param name="digits">the number of digits</param>
		/// <returns>Returns a value</returns>
		public static decimal Round( decimal value , int digits )
		{
			return Math.Round( value , digits );
		}

		/// <summary>
		/// Calculate the cumulative normal distribution. 
		/// </summary>
		/// <param name="value">the input value</param>
		/// <returns>Returns a value</returns>
		public static double CumulativeDistribution( double value )
		{
			return CDF( value );
		}

		/// <summary>
		/// Calculate the cumulative normal distribution. 
		/// </summary>
		/// <param name="value">the input value</param>
		/// <returns>Returns a value</returns>
		public static decimal CumulativeDistribution( decimal value )
		{
			return Convert.ToDecimal( CDF( Convert.ToDouble( value ) ));
		}

		/// <summary>
		/// Calculate the cumulative normal distribution. 
		/// </summary>
		/// <param name="value">the input value</param>
		/// <returns>Returns a value</returns>
		/// <remarks>
		/// <para>
		///		<seealso href="https://jamesmccaffrey.wordpress.com/2014/07/16/the-normal-cumulative-density-function-using-c/"/> for the C# implementation 
		/// </para>
		/// <para>
		///		<see href="https://planetcalc.com/4986/" /> for getting expected results, and see if the code implementation is right. 
		/// </para>
		/// </remarks>
		private static double CDF( double value )
		{
			const double p   =  0.3275911;
			const double a1  =  0.254829592;
			const double a2  = -0.284496736;
			const double a3  =  1.421413741;
			const double a4  = -1.453152027;
			const double a5  =  1.061405429;

			int sign   = (value >= 0 ) ? 1 : -1 ;

			double x   = Math.Abs(value) / Math.Sqrt(2.0);
			double t   = 1.0 / (1.0 + p * x);
			double erf = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

			return 0.5 * (1.0 + sign * erf);
		}
	}
}
