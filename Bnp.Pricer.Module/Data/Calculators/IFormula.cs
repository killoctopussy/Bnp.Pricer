using System;

namespace Bnp.Pricer.Data.Calculators
{
	/// <summary>
	/// Represent a formula contract object
	/// </summary>
	public interface IFormula
	{
		/// <summary>
		/// Gets the result
		/// </summary>
		decimal Result
		{
			get;
		}

		/// <summary>
		/// Calculate
		/// </summary>
		void Calculate();
	}
}
