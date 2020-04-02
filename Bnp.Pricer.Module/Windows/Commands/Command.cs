using System;
using System.Windows.Input;

namespace Bnp.Pricer.Windows.Commands
{
	/// <summary>
	/// Represent the command
	/// </summary>
	public abstract class Command : ICommand
	{
		/// <summary>
		/// Event used to listen a modification of a command it's self
		/// </summary>
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}

			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}




		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public abstract bool CanExecute( object parameter );

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public abstract void Execute( object parameter );
	}
}
