namespace OOP
{
    internal class Car
    {
        public static int NumberOfCars = 0;
        private string _model = "";

        public string Brand { get; set; }

        private bool _isLuxury;

        public string Model
        {
            get
            {
                if (_isLuxury)
                {
                    return _model + " - Luxury Edition";
                }
                else
                {
                    return _model;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("You entered nothing");
                    _model = "DEFAULTVALUE";
                }
                else
                {
                    _model = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            IsLuxury = isLuxury;
            Brand = Brand;
            System.Console.WriteLine("A car of the model " + model + " has been created");
        }

        public void Drive()
        {
            System.Console.WriteLine("I'm driving " + Model);
        }
    }
}