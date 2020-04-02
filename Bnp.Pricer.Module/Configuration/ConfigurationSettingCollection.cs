using System;
using System.Collections;
using System.Collections.Generic;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a custom readonly collection
	/// </summary>
	public sealed class ConfigurationSettingCollection : IEnumerable<ConfigurationSetting>
	{
		/// <summary>
		/// The setting containers class
		/// </summary>
		private readonly ConfigurationSettingList _collection = null;

		


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="collection">the collection</param>
		/// <exception cref="ArgumentNullException"/>
		public ConfigurationSettingCollection( ConfigurationSettingList collection )
		{
			if ( null == collection )
			{
				throw new ArgumentNullException( nameof( collection ) );
			}

			_collection = collection;
		}

		


		/// <summary>
		/// Get a setting
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting this[ int index ]
		{
			get => _collection[ index ];
		}

		/// <summary>
		/// Get a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting this[ string name ]
		{
			get => _collection[ name ];
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
		/// Gets the enumerator
		/// </summary>
		/// <returns>returns an enumerator</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		/// <summary>
		/// Gets the enumerator
		/// </summary>
		/// <returns>returns an enumerator</returns>
		public IEnumerator<ConfigurationSetting> GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Any()
		{
			return _collection.Any();
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <param name="predicate">the predicate</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Any( Func<ConfigurationSetting,bool> predicate )
		{
			return _collection.Any( predicate );
		}

		/// <summary>
		/// Checf if the current instance contains some elements
		/// </summary>
		/// <param name="action">the predicate</param>
		public void ForEach( Action<ConfigurationSetting> action )
		{
			_collection.ForEach( action );
		}

		/// <summary>
		/// Check if a setting exist
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Contains( string name )
		{
			return _collection.Contains( name );
		}

		/// <summary>
		/// Check if a setting exist
		/// </summary>
		/// <param name="setting">the setting</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public bool Contains( ConfigurationSetting setting )
		{
			return _collection.Contains( setting );
		}
		
		/// <summary>
		/// Find a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance, otherwise null</returns>
		public ConfigurationSetting FindByName( string name )
		{
			return _collection.FindByName( name );
		}

		/// <summary>
		/// Find a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting GetByName( string name )
		{
			return _collection.GetByName( name );
		}

		/// <summary>
		/// Gets an element at the desired index
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public ConfigurationSetting GetAt( int index )
		{
			return _collection.GetAt( index );
		}

		/// <summary>
		/// List all settings
		/// </summary>
		/// <returns>Returns a collection of settings</returns>
		public IList<ConfigurationSetting> ListAll()
		{
			return _collection.ListAll();
		}

		/// <summary>
		/// List all settings
		/// </summary>
		/// <param name="predicate">the predicate</param>
		/// <returns>Returns a collection of settings</returns>
		public IList<ConfigurationSetting> ListAll( Func<ConfigurationSetting,bool> predicate )
		{
			return _collection.ListAll( predicate );
		}

		/// <summary>
		/// Remove a setting
		/// </summary>
		/// <param name="name">the name</param>
		/// <returns>returns an instance</returns>
		public bool Remove( string name )
		{
			return _collection.Remove( name );
		}

		/// <summary>
		/// Remove a setting
		/// </summary>
		/// <param name="setting">the setting</param>
		/// <returns>returns an instance</returns>
		public bool Remove( ConfigurationSetting setting )
		{
			return _collection.Remove( setting );
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
