using System;
using NUnit.Framework;
using Observer;
using OT=Observer.Traditional;
using OED=Observer.EventsDelegates;
using OI=Observer.IObserver;

namespace Tests
{
    public class ObserverTest
    {
        [Test]
        public void OldTest()
        {
            //Monitor a stock ticker, when particular events occur, react
            foreach (Stock s in SampleData.getNext())
            {
            	// Reactive Filters
            	if (s.Symbol == "GOOG")
            		Console.WriteLine("Google's new price is: {0}", s.Price);

            	if (s.Symbol == "MSFT" && s.Price > 10.00m)
            		Console.WriteLine("Microsoft has reached the target price: {0}", s.Price);

            	if (s.Symbol == "XOM")
            		Console.WriteLine("Exxon mobile's price is {0}", s.Price);
            }
        }

        [Test]
        public void TraditionalTest()
        {
            // Monitor a stock ticker, when particular events occur, react
			OT.StockTicker subject = new OT.StockTicker();

			// Create New observers to listen to the stock ticker
			subject.Register(new OT.GoogleObserver());
			subject.Register(new OT.MicrosoftObserver());

			// Load the Sample Stock Data
			foreach (var s in SampleData.getNext())
				subject.Stock=s;
        }

        [Test]
        public void EventsDelegatesTest()
        {
            //Monitor a stock ticker, when particular events occur, react
			OED.StockTicker subject = new OED.StockTicker();

			// Create New observers to listen to the stock ticker
			subject.StockChange += new EventHandler<OED.StockChangeEventArgs>(new OED.GoogleMonitor().Monitor);
            subject.StockChange += new OED.GoogleMonitor().Monitor;
            subject.StockChange += delegate(object sender, OED.StockChangeEventArgs e) {
                if (e.Stock.Symbol == "GOOG")
				    Console.WriteLine("Google's has reached the target price: {0}", e.Stock.Price);
            };
            subject.StockChange += (object sender, OED.StockChangeEventArgs e) => {
                if (e.Stock.Symbol == "GOOG")
				    Console.WriteLine("Google's has reached the target price: {0}", e.Stock.Price);
            };

			// Load the Sample Stock Data
			foreach (var s in SampleData.getNext())
				subject.Stock=s;
        }

        [Test]
        public void IObserverTest()
        {
            //Monitor a stock ticker, when particular events occur, react
			OI.StockTicker subject = new OI.StockTicker();

			// Load the Sample Stock Data
			using(subject.Subscribe(new OI.MicrosoftObserver()))
			using(subject.Subscribe(new OI.GoogleObserver()))
			{
				foreach (var s in SampleData.getNext())
					subject.Stock=s;
			}
        }
    }
}