using System;
using System.Windows.Input;

namespace Bnp.Pricer.Windows.Controllers
{
	using Bnp.Pricer.Windows.Models;
	using Bnp.Pricer.Windows.Commands;

	/// <summary>
	/// Represent the calculator controller class
	/// </summary>
	public sealed class CalculatorController : Controller
	{
		/// <summary>
		/// The model
		/// </summary>
		private readonly CalculatorModel		_model				= null;

		/// <summary>
		/// The calculate command
		/// </summary>
		private readonly ICommand				_calculateCommand	= null;

		/// <summary>
		/// The reset command
		/// </summary>
		private readonly ICommand				_resetCommand		= null;




		/// <summary>
		/// Constructor
		/// </summary>
		public CalculatorController()
		{
			_model				= new CalculatorModel();
			_calculateCommand	= new CalculateCommand( _model );
			_resetCommand		= new     ResetCommand( _model );
		}




		/// <summary>
		/// Gets the calculate command
		/// </summary>
		public ICommand CalculateCommand
		{
			get => _calculateCommand;
		}

		/// <summary>
		/// Gets the reset command
		/// </summary>
		public ICommand ResetCommand
		{
			get => _resetCommand;
		}

		/// <summary>
		/// Gets the model
		/// </summary>
		public override Model Model
		{
			get => _model;
		}





		/// <summary>
		/// Initialize
		/// </summary>
		public override void Initialize()
		{
			_model.Precision = UIEnvironment.CalculatorPrecision;
		}
		
	}
}
