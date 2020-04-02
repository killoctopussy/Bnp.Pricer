using System;
using System.Windows;

namespace Bnp.Pricer.Windows
{
	/// <summary>
	/// Represent a message box wrapper
	/// </summary>
	public static class AlertBox
	{
		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		public static void ShowInfo( string message )
		{
			ShowInfo( message , "Informations" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="caption">the caption</param>
		public static void ShowInfo( string message , string caption )
		{
			Show( message , caption , MessageBoxButton.OK , MessageBoxImage.Information );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		public static void ShowWarning( string message )
		{
			ShowWarning( message , "Warning" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="caption">the caption</param>
		public static void ShowWarning( string message , string caption )
		{
			Show( message , caption , MessageBoxButton.OK , MessageBoxImage.Warning );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		public static void ShowError( string message )
		{
			ShowError( message , "Error" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="caption">the caption</param>
		public static void ShowError( string message , string caption )
		{
			Show( message , caption , MessageBoxButton.OK , MessageBoxImage.Error );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="exception">the exception</param>
		public static void ShowError( Exception exception )
		{
			ShowError( exception , "Error" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="exception">the message</param>
		/// <param name="caption">the caption</param>
		public static void ShowError( Exception exception , string caption )
		{
			if ( null == exception )
			{
				return;
			}

			Show( exception.Message , caption , MessageBoxButton.OK , MessageBoxImage.Error );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		public static void ShowDebug( string message )
		{
			ShowDebug( message , "Debug" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="caption">the caption</param>
		public static void ShowDebug( string message , string caption )
		{
#if DEBUG
			Show( message , caption , MessageBoxButton.OK , MessageBoxImage.Asterisk );
#endif
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="exception">the exception</param>
		public static void ShowDebug( Exception exception )
		{
			ShowDebug( exception , "Debug" );
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="exception">the exception</param>
		/// <param name="caption">the caption</param>
		public static void ShowDebug( Exception exception , string caption )
		{
#if DEBUG
			if ( null == exception )
			{
				return;
			}

			Show( exception.Message , caption , MessageBoxButton.OK , MessageBoxImage.Asterisk );
#endif
		}

		/// <summary>
		/// Show a message
		/// </summary>
		/// <param name="message">the message</param>
		/// <param name="caption">the caption</param>
		/// <param name="buttons">the buttons</param>
		/// <param name="image">the image</param>
		private static void Show( string message , string caption , MessageBoxButton buttons , MessageBoxImage image )
		{
			MessageBox.Show( message , caption , MessageBoxButton.OK , MessageBoxImage.Information );
		}
	}
}
