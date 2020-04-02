using System;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent an event args
	/// </summary>
	public class ConfigurationLoadedEventArgs : EventArgs
	{
	}

	/// <summary>
	/// Represent an event args
	/// </summary>
	public class ConfigurationSavedEventArgs : EventArgs
	{
	}

	/// <summary>
	/// Represent an event args
	/// </summary>
	public class ConfigurationExceptionEventArgs : EventArgs
	{
		/// <summary>
		/// The message backed field
		/// </summary>
		private readonly Exception _exception = null;

		

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="exception">the event args</param>
		/// <exception cref="ArgumentNullException"/>
		public ConfigurationExceptionEventArgs( Exception exception )
		{
			if ( null == exception )
			{
				throw new ArgumentNullException( nameof( exception ) );
			}

			_exception = exception;
		}

		
		/// <summary>
		/// Gets the exception
		/// </summary>
		public Exception Exception
		{
			get => _exception;
		} 

	}
}
