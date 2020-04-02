using System;

namespace Bnp.Pricer.Windows.Controllers
{
	/// <summary>
	/// Represent the controller factory class
	/// </summary>
	public class ControllerFactory
	{
		/// <summary>
		/// Constructor
		/// </summary>
		internal ControllerFactory()
		{
		}

		/// <summary>
		/// Create a controller
		/// </summary>
		/// <returns>Returns an instance</returns>
		public TController NewController<TController>() where TController : Controller , new () 
		{
			var controller = new TController();

			controller.Initialize();

			return controller;
		}
	}
}
