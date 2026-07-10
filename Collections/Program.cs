
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 15, 18, 444 };

            numbers.Sort();

            foreach (int number in numbers)
            {
                System.Console.WriteLine(number);
            }

            bool hasLargeNumber = numbers.Any(x => x > 20);
            System.Console.WriteLine("hasLargeNumber: " + hasLargeNumber);

            System.Console.WriteLine("------------------");

            Predicate<int> isGreaterThanTen = x => x >= 10;

            List<int> higherThanTen = numbers.FindAll(isGreaterThanTen);

            foreach (int number in higherThanTen)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine("------------------");

            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Berries", Price = 2.99 });
            products.Add(new Product { Name = "Apples", Price = 0.99 });
            products.Add(new Product { Name = "Bananas", Price = 3.99 });

            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            System.Console.WriteLine("Available products: ");

            foreach (Product product in products)
            {
                System.Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            System.Console.WriteLine("Cheap products: ");

            foreach (Product product in cheapProducts)
            {
                System.Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            System.Console.WriteLine("-----------");

            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("John", new Student(1, "John Doe", 3));
            students.Add("Mary", new Student(2, "Mary Moses", 7));
            students.Add("Anne", new Student(3, "Anne Van Claude Damme", 9));

            foreach (var student in students)
            {
                System.Console.WriteLine($"Name: {student.Key}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            }

        }
    }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Grade { get; set; }

    public Student(int id, string name, int grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }
}




//  List<string> colors = new List<string>();
//             colors.Add("Red");
//             colors.Add("Blue");
//             colors.Add("Yellow");
//             colors.Add("Red");

//             foreach (string color in colors)
//             {
//                 System.Console.WriteLine(color);
//             }
//             ;


//             bool isdeletingSuccessful = colors.Remove("red");

//             System.Console.WriteLine("-----------");

//             foreach (string color in colors)
//             {
//                 System.Console.WriteLine(color);
//             }
//             ;

//             System.Console.WriteLine("Was red deleted? " + isdeletingSuccessful);

//             colors.RemoveAll(color => color == "Red");

//             System.Console.WriteLine("-----------");

//             foreach (string color in colors)
//             {
//                 System.Console.WriteLine(color);
//             }

//             System.Console.WriteLine("-----------");

//             List<int> numbers = new List<int> { 1, 2, 3 };

//             foreach (int num in numbers)
//             {
//                 Console.Write(num + " ");
//             }