using System;
using System.Collections.Generic;

namespace Observer.IObserver
{
	public class StockTicker : IObservable<Stock>
	{
		List<IObserver<Stock>> observers = new List<IObserver<Stock>>();

		private Stock stock;
		public Stock Stock
		{
			get{return stock;}
			set
			{
				stock=value;
                this.Notify();
			}
		}

		public IDisposable Subscribe(IObserver<Stock> observer)
		{
			if (!observers.Contains(observer))
				observers.Add(observer);
			return new Subscriber(observers, observer);
		}

		private void Notify()
		{
			foreach (var o in observers)
				if (stock.Symbol == null || stock.Price < 0)
					o.OnError(new Exception("Bad Stock Data"));
				else
					o.OnNext(stock);
		}

		private void Stop()
		{
			foreach (var o in observers)
				if (observers.Contains(o))
					o.OnCompleted();
			observers.Clear();
		}
    }    
}
