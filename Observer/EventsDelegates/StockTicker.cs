using System;

namespace Observer.EventsDelegates
{
	public class StockTicker
	{
		private Stock stock;
		public Stock Stock
		{
			get{return stock;}
			set
			{
				stock=value;
                if(StockChange != null)
                    StockChange(this,new StockChangeEventArgs(stock));
			}
		}

        public event EventHandler<StockChangeEventArgs> StockChange;
	}
}
