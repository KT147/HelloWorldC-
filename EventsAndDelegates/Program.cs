using System.Security.Cryptography;

namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateExample.Notify notifyDelegate = DelegateExample.ShowMessage;
            //  Delegate.Notify notifyDelegate = new DelegateDelegateNotify(notifyDelegate);
            notifyDelegate("Hello, Delegates");

            Logger logger = new Logger();
            Logger.LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            // logHandler("Logging to console");

            // logHandler = logger.LogToFile;
            // logHandler("Logging to file");

            logHandler("Log this info");

            foreach (Logger.LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occurred with error handling");
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }

            if (logger.IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                System.Console.WriteLine("LogToFile method removed");
            }
            else
            {
                System.Console.WriteLine("LogToFile method not found");
            }

            if (logger != null)
            {
                logger.InvokeSafely(logHandler, "After removing LogtoFile");
            }



            // logHandler("After removing LogToFile");

            System.Console.WriteLine("--------------------");

            Generics generics = new Generics();
            generics.PrintArray([1, 2, 3]);
            generics.PrintArray(["One", "Two", "Three"]);

            SortingMechanism.Person[] people ={
                new SortingMechanism.Person {Name  ="Salice", Age =30},
                new SortingMechanism.Person {Name  ="Bob", Age =25},
                new SortingMechanism.Person {Name  ="Charlie", Age =35},
            };

            SortingMechanism.PersonSorter sorter = new SortingMechanism.PersonSorter();
            sorter.Sort(people, sorter.CompareByAge);

            foreach (SortingMechanism.Person person in people)
            {
                System.Console.WriteLine(person.Name + " " + person.Age);
            }

            System.Console.WriteLine("-----------------------");

            sorter.Sort(people, sorter.CompareByName);

            foreach (SortingMechanism.Person person in people)
            {
                System.Console.WriteLine(person.Name + " " + person.Age);
            }

            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Events: ");
            Events.EventPublisher publisher = new Events.EventPublisher();
            Events.EventSubscriber subscriber = new Events.EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;

            publisher.RaiseEvent("test");

            TemperatureCheck.TemperatureMonitor monitor = new TemperatureCheck.TemperatureMonitor();
            TemperatureCheck.TemperatureAlert alert1 = new TemperatureCheck.TemperatureAlert();
            monitor.TemperatureChanged += alert1.OnTemperatureChanged;

            monitor.Temperature = 20;

            System.Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            System.Console.WriteLine("-------------");
            StockPriceCheck.Stock stock = new StockPriceCheck.Stock();
            StockPriceCheck.StockAlert alert = new StockPriceCheck.StockAlert();

            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            stock.Threshold = 120;
            stock.Price = 150;
            stock.Price = 130;
            stock.Price = 110;


        }


    }
}