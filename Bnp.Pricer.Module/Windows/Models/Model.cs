using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bnp.Pricer.Windows.Models
{
	/// <summary>
	/// Represent the model
	/// </summary>
	public abstract class Model : INotifyPropertyChanged
	{
		/// <summary>
		/// Raise when a property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged = delegate { };






		/// <summary>
		/// Validate the current model
		/// </summary>
		/// <returns>Returns true for a success</returns>
		public abstract bool Validate();

		/// <summary>
		/// Gets the a property value
		/// </summary>
		/// <typeparam name="TValue">the type of the property</typeparam>
		/// <param name="member">the member</param>
		/// <param name="propertyName">the property</param>
		/// <returns>returns the value</returns>
		protected TValue GetField<TValue>( ref TValue member , [CallerMemberName] string propertyName = null )
		{
			if ( string.IsNullOrWhiteSpace( propertyName ) )
			{
				return default( TValue );
			}

			return member;
		}

		/// <summary>
		/// Gets the a property value
		/// </summary>
		/// <typeparam name="TValue">the type of the property</typeparam>
		/// <param name="member">the member</param>
		/// <param name="value">the value</param>
		/// <param name="propertyName">the property</param>
		/// <returns>returns the value</returns>
		protected bool SetField<TValue>( ref TValue member , TValue value , [CallerMemberName] string propertyName = null )
		{
			if ( string.IsNullOrWhiteSpace( propertyName ) )
			{
				return false;
			}

			if ( member is ValueType )
			{
				if ( member.Equals( value ) )
				{
					return false;
				}
			}
			else
			{
				if ( object.ReferenceEquals( member , value ) )
				{
					return false;
				}

				if ( null != member && member.Equals( value ) )
				{
					return false;
				}
			}

			member = value;

			OnPropertyChanged( new PropertyChangedEventArgs( propertyName ) );

			return true;
		}






		/// <summary>
		/// Fired when a property has been changed
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnPropertyChanged( PropertyChangedEventArgs e )
		{
			if ( null == e )
			{
				return;
			}

			try
			{
				var handler = PropertyChanged;

				if ( null != handler )
				{
					handler( this , e );
				}
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}



	}
}
