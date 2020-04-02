using System;

namespace Bnp.Pricer.Data.Calculators
{
	/// <summary>
	/// Represent a calculator contract
	/// </summary>
	/// <typeparam name="TInput">the input data type</typeparam>
	/// <typeparam name="TOutput">the output data type</typeparam>
	public interface ICalculator<TInput,TOutput>
	{
		/// <summary>
		/// Run a calculation
		/// </summary>
		/// <param name="input">the input data</param>
		/// <returns>Returns the output results</returns>
		TOutput Calculate( TInput input );
	}
}
