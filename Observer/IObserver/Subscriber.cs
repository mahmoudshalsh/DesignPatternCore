using System;
using System.Collections.Generic;

namespace Observer.IObserver
{
	public class Subscriber : IDisposable
	{
		private List<IObserver<Stock>> _observers;
		private IObserver<Stock> _observer;

		public Subscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
		{
			this._observers = observers;
			this._observer = observer;
		}

		public void Dispose()
		{
			if (_observer != null && _observers.Contains(_observer))
				_observers.Remove(_observer);
		}
	}
}
