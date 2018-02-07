using System;

namespace Observer.EventsDelegates
{
	public class GoogleMonitor
	{
		public void Monitor(object sender, StockChangeEventArgs e)
		{
			if (e.Stock.Symbol == "GOOG")
				Console.WriteLine("Google's has reached the target price: {0}", e.Stock.Price);
		}
	}
}
