using System;

namespace Bnp.Pricer.Data.Calculators.Formulas
{
	/// <summary>
	/// Represent the base formula class
	/// </summary>
	public abstract class Formula : IFormula
	{
		/// <summary>
		/// Represent the result backing field
		/// </summary>
		private decimal _result = 0;

		/// <summary>
		/// Gets the result
		/// </summary>
		public decimal Result
		{
			get => _result;
		}

		/// <summary>
		/// Calculate
		/// </summary>
		public abstract void Calculate();

		/// <summary>
		/// Define the result value for the current formula
		/// </summary>
		/// <param name="value">the result value</param>
		protected void SetResult( decimal value )
		{
			_result = value;
		}
	}
}
