using System;

namespace Bnp.Pricer.Data.Calculators
{
	/// <summary>
	/// Represent the data input for a black scholes calculator
	/// </summary>
	public sealed class BlackScholesCalculatorPricingData
	{
		/// <summary>
		/// Stock price backing field
		/// </summary>
		private readonly decimal _stockPrice			= 0;

		/// <summary>
		/// Strike price backing field
		/// </summary>
		private readonly decimal _strikePrice			= 0;

		/// <summary>
		/// Stddev price backing field
		/// </summary>
		private readonly decimal _standardDeviation		= 0;

		/// <summary>
		/// Risk interest backing field
		/// </summary>
		private readonly decimal _riskInterest			= 0;

		/// <summary>
		/// Time backing field
		/// </summary>
		private readonly decimal _time					= 0;


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="stockPrice">the stock price</param>
		/// <param name="strikePrice">the strike price</param>
		/// <param name="standardDeviation">the standard deviation</param>
		/// <param name="riskInterest">the risk interest</param>
		/// <param name="time">the time</param>
		public BlackScholesCalculatorPricingData( decimal stockPrice , decimal strikePrice , decimal standardDeviation , decimal riskInterest , decimal time  )
		{
			_stockPrice			= stockPrice;
			_strikePrice		= strikePrice;
			_standardDeviation	= standardDeviation;
			_riskInterest		= riskInterest;
			_time				= time;
		}

		
		/// <summary>
		/// Factory method
		/// </summary>
		/// <param name="stockPrice">the stock price</param>
		/// <param name="strikePrice">the strike price</param>
		/// <param name="standardDeviation">the standard deviation</param>
		/// <param name="riskInterest">the risk interest</param>
		/// <param name="time">the time</param>
		public static BlackScholesCalculatorPricingData NewPricingData( decimal stockPrice , decimal strikePrice , decimal standardDeviation , decimal riskInterest , decimal time )
		{
			return NewPricingData( stockPrice , strikePrice , standardDeviation , riskInterest , time , true );
		}

		/// <summary>
		/// Factory method
		/// </summary>
		/// <param name="stockPrice">the stock price</param>
		/// <param name="strikePrice">the strike price</param>
		/// <param name="standardDeviation">the standard deviation</param>
		/// <param name="riskInterest">the risk interest</param>
		/// <param name="time">the time</param>
		/// <param name="useTimeAsDays">set true to convert time as number of days</param>
		public static BlackScholesCalculatorPricingData NewPricingData( decimal stockPrice , decimal strikePrice , decimal standardDeviation , decimal riskInterest , decimal time , bool useTimeAsDays )
		{
			decimal realTime = ( useTimeAsDays ) 
							 ? time / 365M 
							 : time;
			
			return new BlackScholesCalculatorPricingData( stockPrice , strikePrice , standardDeviation , riskInterest , realTime );
		}

		
		/// <summary>
		/// Gets the stock price
		/// </summary>
		public decimal StockPrice
		{ 
			get => _stockPrice;
		}
		
		/// <summary>
		/// Gets the strike price
		/// </summary>
		public decimal StrikePrice
		{ 
			get => _strikePrice;
		}

		/// <summary>
		/// Gets the standard deviation
		/// </summary>
		public decimal StandardDeviation
		{ 
			get => _standardDeviation;
		}

		/// <summary>
		/// Gets / Sets the time
		/// </summary>
		public decimal Time
		{ 
			get => _time;
		}

		/// <summary>
		/// Gets the risk interest
		/// </summary>
		public decimal RiskInterest
		{
			get => _riskInterest;
		}
	}
}
