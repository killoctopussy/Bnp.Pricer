using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a tolerant value converter
	/// </summary>
	public static class ConfigurationConverter
	{
		/// <summary>
		/// Convert to bool
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static bool ToBool( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return false;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return false;
			}

			if ( bool.TryParse( data , out bool result ) )
			{
				return result;
			}

			return false;
		}

		/// <summary>
		/// Convert to short
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static short ToShort( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( short.TryParse( data , out short result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to int
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static int ToInt( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( int.TryParse( data , out int result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to long
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static long ToLong( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( long.TryParse( data , out long result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to float
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static float ToFloat( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( float.TryParse( data , out float result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to decimal
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static decimal ToDecimal( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( decimal.TryParse( data , out decimal result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to double
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static double ToDouble( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return 0;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return 0;
			}

			if ( double.TryParse( data , out double result ) )
			{
				return result;
			}

			return 0;
		}

		/// <summary>
		/// Convert to date time
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static DateTime ToDateTime( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return DateTime.MinValue;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return DateTime.MinValue;
			}

			if ( DateTime.TryParse( data , out DateTime result ) )
			{
				return result;
			}

			return DateTime.MinValue;
		}

		/// <summary>
		/// Convert to time span
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static TimeSpan ToTimeSpan( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return TimeSpan.Zero;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return TimeSpan.Zero;
			}

			if ( TimeSpan.TryParse( data , out TimeSpan result ) )
			{
				return result;
			}

			return TimeSpan.Zero;
		}

		/// <summary>
		/// Convert to guid
		/// </summary>
		/// <param name="value"></param>
		/// <returns>returns a value</returns>
		public static Guid ToGuid( string value )
		{
			if ( string.IsNullOrWhiteSpace( value ) )
			{
				return Guid.Empty;
			}

			string data = value.Trim();

			if ( string.IsNullOrWhiteSpace( data ) )
			{
				return Guid.Empty;
			}

			if ( Guid.TryParse( data , out Guid result ) )
			{
				return result;
			}

			return Guid.Empty;
		}
	}
}
