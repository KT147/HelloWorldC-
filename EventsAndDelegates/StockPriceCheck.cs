public class StockPriceCheck
{
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        // Private field to store the stock price
        // Private field to store the threshold
        //TODO
        public event StockPriceChangedHandler OnStockPriceChanged;
        private decimal _price;
        private decimal _threshold;

        // Property to get and set the stock price
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent("Stock price is below threshold!");
                }
            }
            // Set the new price
            // Raise the event if the price drops below the threshold
            //TODO

        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            //TODO
            get { return _threshold; }
            set { _threshold = value; }
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
            // Invoke the event
            //TODO
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        //TODO
        public void OnStockPriceChanged(string message)
        {
            System.Console.WriteLine("Stock Alert: " + message);
        }
    }
}