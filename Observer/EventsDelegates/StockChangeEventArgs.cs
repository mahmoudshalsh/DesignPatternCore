using System;

namespace Observer.EventsDelegates
{
    public class StockChangeEventArgs : EventArgs
    {
        public Stock Stock{get;set;}
        public StockChangeEventArgs(Stock s) => this.Stock=s;
    }
}
