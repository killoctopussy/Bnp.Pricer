using System;

namespace Bnp.Pricer.Windows.Controllers
{
	using Bnp.Pricer.Windows.Models;

	/// <summary>
	/// Represent the base controller class. This class is the base viewmodel, it'has been renamed to avoid naming confusion.
	/// </summary>
	public abstract class Controller
	{
		/// <summary>
		/// The controller factory member
		/// </summary>
		private static readonly ControllerFactory s_factory = new ControllerFactory();



		/// <summary>
		/// Gets the controllers factory
		/// </summary>
		public static ControllerFactory Factory
		{
			get => s_factory;
		}

		/// <summary>
		/// Gets the model
		/// </summary>
		public abstract Model Model
		{
			get;
		}



		/// <summary>
		/// Initialize
		/// </summary>
		public abstract void Initialize();
	}
}
