using System;
using System.Xml;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a <see cref="ConfigurationSetting"/> persistence class.
	/// </summary>
	/// <remarks>
	///		<para>Settings are saved in xml format.</para>
	///		<para/>
	/// </remarks>
	/// <example> This is an output template
	///		<code>
	///			<![CDATA[
	///	
	///			<pricer>
	///				<configuration>
	///					<settings>
	///						<setting name="mySetting1">my value 1</setting>
	///						<setting name="mySetting2">my value 2</setting>
	///						<setting name="mySetting3">my value 3</setting>
	///					</settings>
	///				</configuration>
	///			</pricer>
	/// 
	///			]]>
	///		</code>
	/// </example>
	public sealed class ConfigurationProvider
	{
		/// <summary>
		/// The file name backing field
		/// </summary>
		private string								_fileName	= string.Empty;

		/// <summary>
		/// The settings list backing field
		/// </summary>
		private readonly ConfigurationSettingList	_settings	= new ConfigurationSettingList();
		



		/// <summary>
		/// Constructor
		/// </summary>
		public ConfigurationProvider()
		{
		}





		/// <summary>
		/// Gets / Sets the file name
		/// </summary>
		public string FileName
		{
			get => _fileName;
			set => _fileName = value ?? string.Empty;
		}

		/// <summary>
		/// Gets the settings
		/// </summary>
		public ConfigurationSettingList Settings
		{
			get => _settings;
		}





		/// <summary>
		/// Check if the current instance is valid or not
		/// </summary>
		/// <exception cref="ConfigurationException"/>
		public void Validate()
		{
			if ( string.IsNullOrWhiteSpace( _fileName ) )
			{
				throw new ConfigurationException( "Invalid configuration file" );
			}

			if ( string.IsNullOrWhiteSpace( _fileName.Trim() ) )
			{
				throw new ConfigurationException( "Invalid configuration file" );
			}
		}

		/// <summary>
		/// Load the settings
		/// </summary>
		public void Load()
		{
			var xmlDocument = new XmlDocument();

			xmlDocument.Load( FileName );

			var xmlSettings = xmlDocument.SelectNodes( "pricer/configuration/settings/setting");

			if ( null == xmlSettings || xmlSettings.Count <= 0 )
			{
				return;
			}

			foreach ( XmlNode xmlSetting in xmlSettings )
			{
				if ( null == xmlSetting )
				{
					continue;
				}

				var settingName = xmlSetting.ReadAttribute( "name" );

				if ( string.IsNullOrWhiteSpace( settingName ) )
				{
					continue;
				}
				
				Settings.Add( new ConfigurationSetting( settingName , xmlSetting.InnerText ) );
			}
		}

		/// <summary>
		/// Load the settings
		/// </summary>
		public void Save()
		{
			var xmlDocument = new XmlDocument();

			var xmlSettings = xmlDocument.AppendNode( "pricer")
										 .AppendNode( "configuration")
										 .AppendNode( "settings");

			foreach ( var setting in Settings )
			{
				if ( null == setting )
				{
					continue;
				}

				if ( string.IsNullOrWhiteSpace( setting.Name ) )
				{
					continue;
				}

				var xmlSetting = xmlSettings.AppendNode( "setting" );

				if ( null == xmlSetting )
				{
					continue;
				}

				xmlSetting.WriteAttribute( "name" , setting.Name );
				xmlSetting.InnerText = setting.Value;
			}

			xmlDocument.Save( FileName );
		}
	}
}
