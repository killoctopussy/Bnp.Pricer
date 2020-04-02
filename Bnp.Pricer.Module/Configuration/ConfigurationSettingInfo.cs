using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent the configuration class
	/// </summary>
	public sealed class ConfigurationSettingInfo
	{
		/// <summary>
		/// The name of the setting
		/// </summary>
		private readonly string _name	= string.Empty;

		/// <summary>
		/// The value of the setting
		/// </summary>
		private readonly string _value	= string.Empty;
		



		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">the name of setting</param>
		/// <param name="value">the value</param>
		/// <exception cref="ArgumentException"/>
		public ConfigurationSettingInfo( string name , string value )
		{
			if ( string.IsNullOrWhiteSpace( name ) )
			{
				throw new ArgumentException( nameof( name ) );
			}

			_name  = name;
			_value = value ?? string.Empty;
		}





		/// <summary>
		/// Gets the name
		/// </summary>
		public string Name
		{
			get => _name;
		}

		/// <summary>
		/// Gets the value
		/// </summary>
		public string Value
		{
			get => _value;
		}
	}

}
