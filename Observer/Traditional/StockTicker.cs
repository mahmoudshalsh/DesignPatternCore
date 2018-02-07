namespace Observer.Traditional
{
	public class StockTicker : Subject<Stock>
	{
		private Stock stock;
		public Stock Stock
		{
			get{return stock;}
			set
			{
				stock=value;
				this.Notify(stock);
			}
		}
	}
}
