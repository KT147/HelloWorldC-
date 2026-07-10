int? age = null;

if (age.HasValue)
{
    System.Console.WriteLine("age is " + age.Value);
}
else
{
    System.Console.WriteLine("age is not specified");
}