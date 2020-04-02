using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent the configuration class
	/// </summary>
	public static class ConfigurationConstants
	{
		/// <summary>
		/// Represent the configuration file name
		/// </summary>
		public const string	ConfigurationFile		= "settings.xml";

		/// <summary>
		/// Represent a setting
		/// </summary>
		public static readonly ConfigurationSettingInfo	PrecisionSetting = new ConfigurationSettingInfo( "Precision" , "4" );
	}
}
