using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Bnp.Pricer
{
	using Pricer.Configuration;

	/// <summary>
	/// Logique d'interaction pour App.xaml
	/// </summary>
	public partial class App : Application
	{
		/// <summary>
		/// Occurs when the application is starting
		/// </summary>
		/// <param name="e">the event args</param>
		protected override void OnStartup( StartupEventArgs e )
		{
			if ( ! ConfigurationManager.Load() )
			{
				ConfigurationManager.Initialize();
			}
			
			base.OnStartup( e );
		}

		/// <summary>
		/// Occurs when the application is closing
		/// </summary>
		/// <param name="e">the event args</param>
		protected override void OnExit( ExitEventArgs e )
		{
			ConfigurationManager.Save();
			
			base.OnExit( e );
		}
	}
}
