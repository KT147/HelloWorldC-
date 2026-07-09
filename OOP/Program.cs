namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car audi = new Car("A3", "Audi", false);
            // Car bmw = new Car("i7", "BMW", true);

            // System.Console.WriteLine("Number of cars " + Car.NumberOfCars);

            // audi.Drive();


            // System.Console.WriteLine("Car is  " + audi.Model);
            // System.Console.WriteLine("Car is " + bmw.Model);

            // Customer myCustomer = new Customer();
            // // System.Console.WriteLine("myCustomer name is: " + myCustomer.ContactNumber);
            // // myCustomer.SetDetails("Frank", "Mainstreet 1");
            // // System.Console.WriteLine("myCustomer name is: " + myCustomer.ContactNumber);

            // // //static method
            // // Customer.DoSomeStuff();

            // // Customer earl = new Customer("Earl");
            // Customer frank = new Customer("Frank", "Mainstreet 1", "55959595");
            // myCustomer.GetDetails();
            // frank.GetDetails();
            // System.Console.WriteLine("Customer's name: " + earl.Name);
            // System.Console.WriteLine("Customer's name: " + frank.Name);
            // System.Console.WriteLine("Customer's name: " + myCustomer.Name);

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");
            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();

        }
    }
}