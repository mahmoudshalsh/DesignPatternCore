using System;

namespace Observer.Traditional
{
	public class MicrosoftObserver : IObserver<Stock>
	{
		public void Update(Stock stock)
		{
			if (stock.Symbol == "MSFT" && stock.Price > 10.00m)
				Console.WriteLine("Microsoft has reached the target price: {0}", stock.Price);
		}
	}
}
