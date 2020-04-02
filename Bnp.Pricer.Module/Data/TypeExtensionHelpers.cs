using System;

namespace Bnp.Pricer.Data
{
	/// <summary>
	/// Represent a data type extension helpers
	/// </summary>
	public static class TypeExtensionHelpers
	{
		/// <summary>
		/// Round the value
		/// </summary>
		/// <param name="valueType">the value</param>
		/// <returns>Returns a value.</returns>
		public static decimal ToRound( this decimal valueType )
		{
			return Math.Round( valueType );
		}

		/// <summary>
		/// Round the value
		/// </summary>
		/// <param name="valueType">the value</param>
		/// <param name="numberOfDigits">the number of digits</param>
		/// <returns>Returns a value.</returns>
		/// <exception cref="ArgumentException"/>
		public static decimal ToRound( this decimal valueType , int numberOfDigits )
		{
			if ( 0 >= numberOfDigits )
			{
				throw new ArgumentException( nameof( numberOfDigits ) );
			}

			return Math.Round( valueType , numberOfDigits );
		}
	}
}
