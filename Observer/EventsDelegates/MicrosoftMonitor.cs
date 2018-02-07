using System;

namespace Observer.EventsDelegates
{
	public class MicrosoftMonitor
	{
		public void Monitor(object sender, StockChangeEventArgs e)
		{
			if (e.Stock.Symbol == "MSFT" && e.Stock.Price > 10.00m)
				Console.WriteLine("Microsoft has reached the target price: {0}", e.Stock.Price);
		}
	}
}
