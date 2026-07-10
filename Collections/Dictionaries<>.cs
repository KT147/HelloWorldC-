Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(101, "John Doe");
employees.Add(102, "Bob Smith");
employees.Add(103, "Rob Smith");
employees.Add(104, "Dob Smith");

string name = employees[101];
System.Console.WriteLine(name);

employees[102] = "Jane Smith";
employees.Remove(101);

if (employees.ContainsKey(104))
{
    employees.Add(104, "Mike Jike");
}

bool added = employees.TryAdd(102, "Mini Maini");

foreach (KeyValuePair<int, string> employee in employees)
{
    System.Console.WriteLine($"ID: {employee.Key}, Name; {employee.Value}");
}


Dictionary<int, Employee> employees2 = new Dictionary<int, Employee>();
employees2.Add(1, new Employee("John Doe", 35, 100000));
employees2.Add(2, new Employee("Mary Yellow", 25, 10000));
employees2.Add(3, new Employee("Smith Nith", 55, 18000));
employees2.Add(4, new Employee("Jane Banane", 54, 70000));

foreach (var item in employees2)
{
    System.Console.WriteLine($"ID: {item.Key}, name: {item.Value.Name}, age: {item.Value.Age}, salary: {item.Value.Salary}");
}

System.Console.WriteLine("---------");
Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

dictionary.Add("numbers", new List<int> { 1, 2, 3 });

foreach (int number in dictionary["numbers"])
{
    System.Console.Write(number + " ");
}

var codes = new Dictionary<string, string>
{
    ["NY"] = "New York",
    ["CA"] = "California",
    ["TX"] = "Texas",
};


if (codes.TryGetValue("NY", out string state))
{
    System.Console.WriteLine(state);
}

foreach (var item in codes)
{
    System.Console.WriteLine("The state code is " + item.Key + " the state name is " + item.Value);
}



class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}


