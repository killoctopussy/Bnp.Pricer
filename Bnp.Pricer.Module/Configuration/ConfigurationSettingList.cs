using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a custom collection of settings
	/// </summary>
	public class ConfigurationSettingList : IEnumerable<ConfigurationSetting>
	{
		/// <summary>
		/// Represent the maximum of settings
		/// </summary>
		public const int											MaximumOfSettings			= 3000;

		/// <summary>
		/// The setting containers class
		/// </summary>
		private readonly IDictionary<string,ConfigurationSetting>	_collection					= new Dictionary<string,ConfigurationSetting>();

		



		/// <summary>
		/// Constructor
		/// </summary>
		public ConfigurationSettingList()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="settings">the items</param>
		/// <exception cref="ArgumentNullException"/>
		public ConfigurationSettingList( IEnumerable<ConfigurationSetting> settings )
		{
			if ( null == settings )
			{
				throw new ArgumentNullException( nameof( settings ) );
			}

			AddRange( settings );
		}

		



		/// <summary>
		/// Get a setting
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting this[ int index ]
		{
			get => GetAt( index );
		}

		/// <summary>
		/// Get a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting this[ string name ]
		{
			get => GetByName( name );
		}


		


		/// <summary>
		/// Gets the number of elements
		/// </summary>
		public int Count
		{
			get => _collection.Count;
		}

		/// <summary>
		/// Check if the current instance is empty
		/// </summary>
		public bool IsEmpty
		{
			get => _collection.Count <= 0;
		}

		/// <summary>
		/// Check if the current instance is full
		/// </summary>
		public bool Full
		{
			get => _collection.Count >= MaximumOfSettings ;
		}





		/// <summary>
		/// Gets the enumerator
		/// </summary>
		/// <returns>returns an enumerator</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _collection.Values.ToList().GetEnumerator();
		}

		/// <summary>
		/// Gets the enumerator
		/// </summary>
		/// <returns>returns an enumerator</returns>
		public IEnumerator<ConfigurationSetting> GetEnumerator()
		{
			return _collection.Values.ToList().GetEnumerator();
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Any()
		{
			return _collection.Count >= 0;
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <param name="predicate">the predicate</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		/// <exception cref="ArgumentNullException"/>
		public bool Any( Func<ConfigurationSetting,bool> predicate )
		{
			if ( null == predicate )
			{
				throw new ArgumentNullException(nameof(predicate) );
			}

			return _collection.Values.Any( predicate );
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <param name="action">the predicate</param>
		/// <exception cref="ArgumentNullException"/>
		public void ForEach( Action<ConfigurationSetting> action )
		{
			if ( null == action )
			{
				throw new ArgumentNullException( nameof(action) );
			}
			
			_collection.Values.ToList().ForEach( action );
		}

		/// <summary>
		/// Check if a setting exist
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Contains( string name )
		{
			return _collection.ContainsKey( name ?? string.Empty );
		}

		/// <summary>
		/// Check if a setting exist
		/// </summary>
		/// <param name="setting">the setting</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Contains( ConfigurationSetting setting )
		{
			return _collection.Values.Contains( setting );
		}

		/// <summary>
		/// Add a setting exist
		/// </summary>
		/// <param name="setting">the setting</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Add( ConfigurationSetting setting )
		{
			if ( null == setting )
			{
				return false;
			}

			if ( object.ReferenceEquals( setting , ConfigurationSetting.Null ) )
			{
				return false;
			}

			if ( string.IsNullOrWhiteSpace( setting.Name ) )
			{
				return false;
			}

			if ( _collection.ContainsKey( setting.Name ) )
			{
				return false;
			}

			if ( _collection.Count >= MaximumOfSettings )
			{
				return false;
			}

			_collection[ setting.Name ] = setting;

			return true;
		}

		/// <summary>
		/// Add multiple settings
		/// </summary>
		/// <param name="settings">the elements</param>
		/// <returns>returns the number of elements added</returns>
		public int AddRange( IEnumerable<ConfigurationSetting> settings )
		{
			if ( null == settings )
			{
				return 0;
			}

			int results = 0;

			foreach ( var setting in settings )
			{
				if ( _collection.Count >= MaximumOfSettings )
				{
					break;
				}

				if ( Add( setting ) )
				{
					_collection[ setting.Name ] = setting;

					++ results;
				}
			}

			return results;
		}
		
		/// <summary>
		/// Find a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance otherwise null</returns>
		public ConfigurationSetting FindByName( string name )
		{
			if ( _collection.TryGetValue( name ?? string.Empty , out ConfigurationSetting result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// Find a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting GetByName( string name )
		{
			if ( _collection.TryGetValue( name ?? string.Empty , out ConfigurationSetting result ) )
			{
				return result ?? ConfigurationSetting.Null;
			}

			return ConfigurationSetting.Null;
		}

		/// <summary>
		/// Gets an element at the desired index
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting GetAt( int index )
		{
			if ( index < 0 || index >= _collection.Count )
			{
				return ConfigurationSetting.Null;
			}

			return _collection.Values.ElementAt( index ) ?? ConfigurationSetting.Null;
		}

		/// <summary>
		/// List all settings
		/// </summary>
		/// <returns>Returns a collection of settings</returns>
		public IList<ConfigurationSetting> ListAll()
		{
			return _collection.Values.ToList();
		}

		/// <summary>
		/// List all settings
		/// </summary>
		/// <param name="predicate">the predicate</param>
		/// <returns>Returns a collection of settings</returns>
		/// <exception cref="ArgumentNullException"/>
		public IList<ConfigurationSetting> ListAll( Func<ConfigurationSetting,bool> predicate )
		{
			if ( null == predicate )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			return _collection.Values.Where( predicate ).ToList();
		}

		/// <summary>
		/// Remove a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public bool Remove( string name )
		{
			return _collection.Remove( name ?? string.Empty );
		}

		/// <summary>
		/// Remove a setting
		/// </summary>
		/// <param name="setting">the setting</param>
		/// <returns>returns an instance</returns>
		public bool Remove( ConfigurationSetting setting )
		{
			if ( null == setting )
			{
				return false;
			}

			if ( ! _collection.Values.Contains( setting ) )
			{
				return false;
			}

			return _collection.Remove( setting.Name ?? string.Empty );
		}

		/// <summary>
		/// Remove all elements
		/// </summary>
		public void Clear()
		{
			_collection.Clear();
		}

	}
}
