using System.Runtime.InteropServices;

namespace Interface
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            // PaymentService paymentService = new PaymentService(creditCardProcessor);
            // paymentService.ProcessOrderPayment(100.00m);

            // IPaymentProcessor paypalProcessor = new PayPalProcessor();
            // paymentService = new PaymentService(paypalProcessor);
            // paymentService.ProcessOrderPayment(200.00m);


            // ILogger fileLogger = new FileLogger();
            // Application app = new Application(fileLogger);
            // app.DoWork();

            // ILogger dbLogger = new DataBaseLogger();
            // app = new Application(dbLogger);
            // app.DoWork();

            // Hammer hammer = new Hammer();
            // Saw saw = new Saw();
            // Builder builder = new Builder();
            // // builder.Hammer = hammer; //injection dependenciesvia Setters
            // // builder.Saw = saw; //injection dependenciesvia Setters
            // builder.SetHammer(hammer);
            // builder.SetSaw(saw);
            // builder.BuildHouse();

            // MultiFuntionPrinter printer = new MultiFuntionPrinter();
            // printer.Print();
            // printer.Scan();

            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            IShape[] shapes = { circle, rectangle };
            System.Console.WriteLine($"Area: {circle.GetArea()}\nArea: {rectangle.GetArea()}\n");
            


        }
    }
}
