using System.Collections.Generic;

namespace Observer.Traditional
{
	public abstract class Subject<T>
	{
		List<IObserver<T>> observers=new List<IObserver<T>>();

		public void Register(IObserver<T> observer) => observers.Add(observer);
		public void Unregister(IObserver<T> observer) => observers.Remove(observer);
		public void Notify(T args)
		{
			foreach (var o in observers)
				o.Update(args);
		}
	}
}
