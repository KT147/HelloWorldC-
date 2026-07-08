void CalculateArea(double radius)
{
    double area = Math.PI * radius * radius;
    Console.WriteLine("The area is: " + area);
}

int myRadius = 5;
CalculateArea(myRadius); 


//ref :
void ModifyValue(ref int number)
{
    number += 10; // Modify the original value
}
 
int myNumber = 5;
ModifyValue(ref myNumber);
Console.WriteLine(myNumber);


//out : 
void GetValues(out int result)
{
    result = 42; // Must be assigned before the method exits
}
 
int myValue;
GetValues(out myValue);
Console.WriteLine(myValue);

void Calculate(int x, int y, out int sum, out int product)
{
    sum = x + y;
    product = x * y;
}
 
int a = 5, b = 3, sum, product;
Calculate(a, b, out sum, out product);
Console.WriteLine($"Sum: {sum}, Product: {product}");


//in :

void PrintValue(in int number)
{
    Console.WriteLine(number); // Allowed
    // number += 10; // Not allowed (will cause a compile error)
}
 
int myNum = 100;
PrintValue(in myNum);