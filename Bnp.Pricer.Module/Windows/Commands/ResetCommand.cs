using System;

namespace Bnp.Pricer.Windows.Commands
{
	using Bnp.Pricer.Windows.Models;

	/// <summary>
	/// Represent the reset calculator command
	/// </summary>
	public sealed class ResetCommand : Command
	{
		/// <summary>
		/// The model
		/// </summary>
		private readonly CalculatorModel	_model	= null;


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="model">the model</param>
		/// <exception cref="ArgumentNullException"/>
		public ResetCommand( CalculatorModel model )
		{
			if ( null == model )
			{
				throw new ArgumentNullException( nameof( model ) );
			}

			_model = model;
		}


		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public override bool CanExecute( object parameter )
		{
			return true;
		}

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public override void Execute( object parameter )
		{
			_model.ClearParameters();
			_model.ClearResults();
		}
	}
}
