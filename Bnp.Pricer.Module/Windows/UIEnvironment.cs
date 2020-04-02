using System;

namespace Bnp.Pricer.Windows
{
	using Bnp.Pricer.Configuration;

	/// <summary>
	/// Represent the common adapter between ui objects and configuration settings. This is class is for reducing coupling between ui objects and others class
	/// </summary>
	public static class UIEnvironment
	{
		/// <summary>
		/// Gets / Sets the calculator output precision
		/// </summary>
		public static int CalculatorPrecision
		{
			get => ConfigurationManager.Settings[ ConfigurationConstants.PrecisionSetting.Name ].ReadInt();
			set => ConfigurationManager.Settings[ ConfigurationConstants.PrecisionSetting.Name ].Write( value );
		}
	}
}
