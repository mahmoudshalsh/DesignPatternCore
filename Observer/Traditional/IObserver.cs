namespace Observer.Traditional
{
	public interface IObserver<T>
	{
		void Update(T args);
	}
}
