using System;
using System.Collections.Generic;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a configuration setting factory
	/// </summary>
	public sealed class ConfigurationBuilder
	{
		/// <summary>
		/// The settings list
		/// </summary>
		private readonly ConfigurationSettingList		_settings	= null;

		/// <summary>
		/// The collection used to build
		/// </summary>
		private readonly IList<ConfigurationSetting>	_items		= null;

		/// <summary>
		/// Variable used to perform to remove all elements before the build operation
		/// </summary>
		private bool									_autoClear	= false;



		/// <summary>
		/// Constructor
		/// </summary>
		/// <exception cref="ArgumentNullException"/>
		public ConfigurationBuilder( ConfigurationSettingList settings )
		{
			if ( null == settings )
			{
				throw new ArgumentNullException( nameof( settings ) );
			}

			_settings = settings;
			_items    = new List<ConfigurationSetting>();
		}



		/// <summary>
		/// Gets / Sets the auto clear
		/// </summary>
		public bool AutoClear
		{
			get => _autoClear;
			set => _autoClear = value;
		}



		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , bool defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , short defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , int defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , long defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , float defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , decimal defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , double defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , DateTime defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , TimeSpan defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , Guid defaultValue )
		{
			AddProperty( propertyName , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a property
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		public void AddProperty( string propertyName , string defaultValue )
		{
			_items.Add( new ConfigurationSetting( propertyName , defaultValue ) );
		}
				
		/// <summary>
		/// Remove all properties previously added
		/// </summary>
		public void Cancel()
		{
			_items.Clear();
		}

		/// <summary>
		/// Build
		/// </summary>
		public void Build()
		{
			if ( _autoClear )
			{
				_settings.Clear();
			}

			_settings.AddRange( _items );
		}
	}
}
