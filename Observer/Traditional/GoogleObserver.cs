using System;

namespace Observer.Traditional
{
	public class GoogleObserver : IObserver<Stock>
	{
		public void Update(Stock stock)
		{
			if (stock.Symbol == "GOOG")
				Console.WriteLine("Google's has reached the target price: {0}", stock.Price);
		}
	}
}
