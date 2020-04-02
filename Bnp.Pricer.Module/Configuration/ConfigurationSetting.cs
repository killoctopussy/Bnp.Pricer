using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a configuration setting
	/// </summary>
	public sealed class ConfigurationSetting
	{
		/// <summary>
		/// Design for null object pattern
		/// </summary>
		private readonly static ConfigurationSetting	s_null	= new ConfigurationSetting();

		/// <summary>
		/// The name backing field
		/// </summary>
		private readonly string		_name			= string.Empty;

		/// <summary>
		/// The default value backing field
		/// </summary>
		private readonly string		_defaultValue   = string.Empty;

		/// <summary>
		/// The value backing field
		/// </summary>
		private string          	_value			= string.Empty;

		/// <summary>
		/// the dirty flag
		/// </summary>
		private bool				_isDirty		= false;


		
		/// <summary>
		/// Constructor
		/// </summary>
		private ConfigurationSetting()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">the name</param>
		public ConfigurationSetting( string name )
			: this ( name , null )
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">the name</param>
		/// <param name="defaultValue">the value</param>
		/// <exception cref="ArgumentException"/>
		public ConfigurationSetting( string name , string defaultValue )
		{
			if ( string.IsNullOrEmpty( name ) )
			{
				throw new ArgumentException( nameof( name ) );
			}

			_name			= name;
			_defaultValue	= defaultValue ?? string.Empty;
			_value			= defaultValue ?? string.Empty;
		}



		

		/// <summary>
		/// Gets the null instance
		/// </summary>
		public static ConfigurationSetting Null
		{
			get => s_null;
		}

		/// <summary>
		/// Gets the name
		/// </summary>
		public string Name
		{
			get => _name;
		}

		/// <summary>
		/// Gets the default value
		/// </summary>
		public string DefaultValue
		{
			get => _value;
		}

		/// <summary>
		/// Gets / Sets the value
		/// </summary>
		public string Value
		{
			get => Read();
			set => Write( value );
		}

		/// <summary>
		/// Gets / Sets the dirty state
		/// </summary>
		public bool IsDirty
		{
			get => _isDirty;
			set => _isDirty = value;
		}






		/// <summary>
		/// Read the content of the property
		/// </summary>
		/// <returns>returns an value</returns>
		public string Read()
		{
			return _value;
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public bool ReadBool()
		{
			return ConfigurationConverter.ToBool( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public short ReadShort()
		{
			return ConfigurationConverter.ToShort( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public int ReadInt()
		{
			return ConfigurationConverter.ToInt( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public long ReadLong()
		{
			return ConfigurationConverter.ToLong( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public float ReadFloat()
		{
			return ConfigurationConverter.ToFloat( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public decimal ReadDecimal()
		{
			return ConfigurationConverter.ToDecimal( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public double ReadDouble()
		{
			return ConfigurationConverter.ToDouble( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public DateTime ReadDateTime()
		{
			return ConfigurationConverter.ToDateTime( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public TimeSpan ReadTimeSpan()
		{
			return ConfigurationConverter.ToTimeSpan( _value );
		}

		/// <summary>
		/// Read a value
		/// </summary>
		/// <returns>returns an value</returns>
		public Guid ReadGuid()
		{
			return ConfigurationConverter.ToGuid( _value );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( string value )
		{
			if ( 0 == string.Compare( _value ?? string.Empty , value ?? string.Empty ) )
			{
				return false;
			}

			_value   = value;
			_isDirty = true;

			return true;
		}
		
		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( bool value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( int value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( long value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( float value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( decimal value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( double value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( DateTime value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( TimeSpan value )
		{
			return Write( value.ToString() );
		}

		/// <summary>
		/// Write a new value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns true for a success, otherwise false</returns>
		public bool Write( Guid value )
		{
			return Write( value.ToString() );
		}
		
		/// <summary>
		/// Reset the property value to its <see cref="DefaultValue"/>.
		/// </summary>
		public void Reset()
		{
			_value   = _defaultValue;
			_isDirty = false;
		}

	}
}
