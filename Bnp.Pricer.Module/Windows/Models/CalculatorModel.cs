using System;

namespace Bnp.Pricer.Windows.Models
{
	/// <summary>
	/// Represent the model
	/// </summary>
	public sealed class CalculatorModel : Model
	{
		/// <summary>
		/// The pricision
		/// </summary>
		private int				_precision			= 4;

		/// <summary>
		/// The stock price backing field
		/// </summary>
		private decimal			_stockPrice			= 0;

		/// <summary>
		/// The strike price backing field
		/// </summary>
		private decimal			_strikePrice		= 0;

		/// <summary>
		/// The time backing field
		/// </summary>
		private decimal			_time				= 0;

		/// <summary>
		/// The standard deviation backing field
		/// </summary>
		private decimal			_standardDeviation	= 0;

		/// <summary>
		/// The risk interest backing field
		/// </summary>
		private decimal			_riskInterest		= 0;

		/// <summary>
		/// D1 backing field
		/// </summary>
		private decimal			_d1					= 0;

		/// <summary>
		/// D2 backing field
		/// </summary>
		private decimal			_d2					= 0;

		/// <summary>
		/// Call option backing field
		/// </summary>
		private decimal			_callOption			= 0;

		/// <summary>
		/// Put option backing field
		/// </summary>
		private decimal			_putOption			= 0;

		
		

		/// <summary>
		/// Constructor
		/// </summary>
		public CalculatorModel()
		{
		}



		
		/// <summary>
		/// Gets / Sets the precision
		/// </summary>
		public int Precision
		{
			get => GetField( ref _precision );
			set => SetField( ref _precision , ValueAdapter.AdaptBetween<int>( 1 , 10 , value ) );
		}

		/// <summary>
		/// Gets / Sets the stock price
		/// </summary>
		public decimal StockPrice
		{
			get => GetField( ref _stockPrice );
			set => SetField( ref _stockPrice , value );
		}

		/// <summary>
		/// Gets / Sets the strike price
		/// </summary>
		public decimal StrikePrice
		{
			get => GetField( ref _strikePrice );
			set => SetField( ref _strikePrice , value );
		}

		/// <summary>
		/// Gets / Sets the time
		/// </summary>
		public decimal Time
		{
			get => GetField( ref _time );
			set => SetField( ref _time , value );
		}

		/// <summary>
		/// Gets / Sets the standard deviation
		/// </summary>
		public decimal StandardDeviation
		{
			get => GetField( ref _standardDeviation );
			set => SetField( ref _standardDeviation , ValueAdapter.AdaptAsPercentage( value ) );
		}

		/// <summary>
		/// Gets / Sets the risk interest
		/// </summary>
		public decimal RiskInterest
		{
			get => GetField( ref _riskInterest );
			set => SetField( ref _riskInterest , ValueAdapter.AdaptAsPercentage( value ) );
		}

		/// <summary>
		/// Gets / Sets the d1
		/// </summary>
		public decimal D1
		{
			get => GetField( ref _d1 );
			set => SetField( ref _d1 , value );
		}

		/// <summary>
		/// Gets / Sets the d2
		/// </summary>
		public decimal D2
		{
			get => GetField( ref _d2 );
			set => SetField( ref _d2 , value );
		}

		/// <summary>
		/// Gets / Sets the call option
		/// </summary>
		public decimal CallOption
		{
			get => GetField( ref _callOption );
			set => SetField( ref _callOption , value );
		}

		/// <summary>
		/// Gets / Sets the put option
		/// </summary>
		public decimal PutOption
		{
			get => GetField( ref _putOption );
			set => SetField( ref _putOption , value );
		}





		/// <summary>
		/// Validate the current model
		/// </summary>
		/// <returns>Returns true for a success</returns>
		public override bool Validate()
		{
			if ( 0 >= Precision )
			{
				return false;
			}

			if ( 0 >= StockPrice )
			{
				return false;
			}

			if ( 0 >= StrikePrice )
			{
				return false;
			}

			if ( 0 >= Time )
			{
				return false;
			}

			if ( 0 >= StandardDeviation )
			{
				return false;
			}

			if ( 0 >= RiskInterest )
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Perform a reset of the model
		/// </summary>
		public void ClearParameters()
		{
			StockPrice			= 0;
			StrikePrice			= 0;
			Time				= 0;
			StandardDeviation	= 0;
			RiskInterest		= 0;
		}

		/// <summary>
		/// Perform a reset of the model
		/// </summary>
		public void ClearResults()
		{
			D1					= 0;
			D2					= 0;
			CallOption			= 0;
			PutOption			= 0;
		}
	}
}
