public class TemperatureCheck
{
    // public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        // public event TemperatureChangeHandler OnTemperatureChanged;

        public EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChange(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }
        protected virtual void OnTemperatureChange(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            System.Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender} ");
        }
    }
}