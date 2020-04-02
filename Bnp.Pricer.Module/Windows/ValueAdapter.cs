using System;

namespace Bnp.Pricer.Windows
{
	/// <summary>
	/// Represent a value adapter
	/// </summary>
	public static class ValueAdapter
	{
		/// <summary>
		/// Rectify a value if it is outside the boundaries
		/// </summary>
		/// <param name="value">the value to be rectified</param>
		/// <returns>returns a value</returns>
		/// <exception cref="ArgumentException"/>
		public static decimal AdaptAsPercentage( decimal value )
		{
			return AdaptBetween<decimal>( 0M , 100M , value );
		}

		/// <summary>
		/// Rectify a value if it is outside the boundaries
		/// </summary>
		/// <param name="minimum">the minimum</param>
		/// <param name="maximum">the maximum</param>
		/// <param name="value">the value to be rectified</param>
		/// <returns>returns a value</returns>
		/// <exception cref="ArgumentException"/>
		public static TValue AdaptBetween<TValue>( TValue minimum , TValue maximum , TValue value )
			where TValue : struct , IComparable<TValue>
		{
			if ( 0 <= minimum.CompareTo( maximum ) )
			{
				throw new ArgumentException( nameof( minimum ) );
			}

			if ( 0 < minimum.CompareTo( value ) )
			{
				return minimum;
			}

			if ( 0 > maximum.CompareTo( value ) )
			{
				return maximum;
			}

			return value;
		}

	}
}
