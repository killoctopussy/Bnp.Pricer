using System;
using System.Globalization;
using System.Windows.Data;

namespace Bnp.Pricer.Windows.Converters
{
	/// <summary>
	/// Represent a convert
	/// </summary>
	public class RangePercentageConverter : IValueConverter
	{
		/// <summary>
		/// Convert
		/// </summary>
		/// <param name="value">value</param>
		/// <param name="targetType">target type</param>
		/// <param name="parameter">parameter</param>
		/// <param name="culture">culture</param>
		/// <returns>returns a converted value</returns>
		public object Convert( object value , Type targetType , object parameter , CultureInfo culture )
		{
			if ( value is ValueType )
			{
				return value.ToString();
			}

			return "";
		}

		/// <summary>
		/// Reverse convert
		/// </summary>
		/// <param name="value">value</param>
		/// <param name="targetType">target type</param>
		/// <param name="parameter">parameter</param>
		/// <param name="culture">culture</param>
		/// <returns>returns a converted value</returns>
		public object ConvertBack( object value , Type targetType , object parameter , CultureInfo culture )
		{
			if ( string.IsNullOrWhiteSpace( value as string ) )
			{
				return null;
			}

			if ( ! decimal.TryParse( value.ToString() , out decimal result ) )
			{
				result = 0;
			}

			if ( result < 0 )
			{
				result = 0;
			}

			if ( result > 100 )
			{
				result = 100;
			}

			return result;
		}
	}
}
