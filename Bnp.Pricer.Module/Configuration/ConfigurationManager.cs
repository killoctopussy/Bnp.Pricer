using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent the configuration manager
	/// </summary>
	public static class ConfigurationManager
	{
		/// <summary>
		/// The settings list
		/// </summary>
		private static readonly ConfigurationSettingList					s_settings		= null;

		
		
		/// <summary>
		/// Event raised the configuration has been loaded
		/// </summary>
		public static event EventHandler<ConfigurationLoadedEventArgs>		Loaded			= delegate { };

		/// <summary>
		/// Event raised the configuration has been saved
		/// </summary>
		public static event EventHandler<ConfigurationSavedEventArgs>		Saved			= delegate { };

		/// <summary>
		/// Event raised when a load / save operation failed
		/// </summary>
		public static event EventHandler<ConfigurationExceptionEventArgs>	Exception		= delegate { };





		/// <summary>
		/// Constructor
		/// </summary>
		static ConfigurationManager()
		{
			s_settings = new ConfigurationSettingList();
		}





		/// <summary>
		/// Gets the settings
		/// </summary>
		public static ConfigurationSettingCollection Settings
		{
			get => new ConfigurationSettingCollection( s_settings );
		}





		/// <summary>
		/// Initialize the configuration settings
		/// </summary>
		public static void Initialize()
		{
			var builder = new ConfigurationBuilder( s_settings )
			{
				AutoClear = true
			};

			builder.AddProperty( ConfigurationConstants.PrecisionSetting.Name , ConfigurationConstants.PrecisionSetting.Value );

			builder.Build();
		}

		/// <summary>
		/// Load the settings
		/// </summary>
		/// <returns>returns true for a sucess, otherwise false.</returns>
		public static bool Load()
		{
			return Load( ConfigurationConstants.ConfigurationFile );
		}

		/// <summary>
		/// Load the settings
		/// </summary>
		/// <param name="fileName">the file name</param>
		/// <returns>returns true for a sucess, otherwise false.</returns>
		public static bool Load( string fileName )
		{
			try
			{
				var provider = new ConfigurationProvider()
				{
					FileName = fileName,
				};

				provider.Validate();
				provider.Load();

				s_settings.Clear();
				s_settings.AddRange( provider.Settings );

				OnLoaded( new ConfigurationLoadedEventArgs() );

				return true;
			}
			catch ( Exception ex )
			{
				OnException( new ConfigurationExceptionEventArgs( ex ) );
			}

			return false;
		}

		/// <summary>
		/// Save the settings
		/// </summary>
		/// <returns>returns true for a sucess, otherwise false.</returns>
		public static bool Save()
		{
			return Save( ConfigurationConstants.ConfigurationFile );
		}

		/// <summary>
		/// Save the settings
		/// </summary>
		/// <param name="fileName">the file name</param>
		/// <returns>returns true for a sucess, otherwise false.</returns>
		public static bool Save( string fileName )
		{
			try
			{
				var provider = new ConfigurationProvider()
				{
					FileName = fileName,
				};

				provider.Settings.AddRange( s_settings );

				provider.Validate();
				provider.Save();

				OnSaved( new ConfigurationSavedEventArgs() );

				return true;
			}
			catch ( Exception ex )
			{
				OnException( new ConfigurationExceptionEventArgs( ex ) );
			}

			return false;
		}

		/// <summary>
		/// Reset all settings
		/// </summary>
		public static void Reset()
		{
			s_settings.ForEach( (setting) => setting.Reset() );
		}






		/// <summary>
		/// Fired when settings are loaded
		/// </summary>
		/// <param name="e">the event args</param>
		private static void OnLoaded( ConfigurationLoadedEventArgs e )
		{
			if ( null == e )
			{
				return;
			}

			try
			{
				var handler = ConfigurationManager.Loaded;

				if ( null != handler )
				{
					handler( null , e );
				}
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}

		/// <summary>
		/// Fired when settings are saved
		/// </summary>
		/// <param name="e">the event args</param>
		private static void OnSaved( ConfigurationSavedEventArgs e )
		{
			if ( null == e )
			{
				return;
			}

			try
			{
				var handler = ConfigurationManager.Saved;

				if ( null != handler )
				{
					handler( null , e );
				}
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}

		/// <summary>
		/// Fired when an exception occurs
		/// </summary>
		/// <param name="e">the event args</param>
		private static void OnException( ConfigurationExceptionEventArgs e )
		{
			if ( null == e )
			{
				return;
			}

			try
			{
				var handler = ConfigurationManager.Exception;

				if ( null != handler )
				{
					handler( null , e );
				}
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}
	}
}
