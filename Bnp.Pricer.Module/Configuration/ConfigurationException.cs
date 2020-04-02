using System;
using System.Runtime.Serialization;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent an event args
	/// </summary>
	[Serializable] public class ConfigurationException : Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ConfigurationException()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">the message</param>
		public ConfigurationException( string message ) 
			: base( message ) 
		{ 
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="inner">the inner exception</param>
		public ConfigurationException( string message , Exception inner ) 
			: base( message , inner ) 
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info">info</param>
		/// <param name="context">context</param>
		protected ConfigurationException( SerializationInfo info , System.Runtime.Serialization.StreamingContext context ) 
			: base( info , context ) 
		{
		}
	}
}
