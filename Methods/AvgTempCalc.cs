
double[] temperatures = { 13.1, 15.2, 16.7 };

void PrintAverage(double[] temperatures)
{
    System.Console.WriteLine("The average temperature is: " + CalculateAverage(temperatures));
}

double CalculateAverage(double[] temperatures)
{
    double total = 0;
    foreach (var temp in temperatures)
    {
        total += temp;
    }
    return total / temperatures.Length;
}

PrintAverage(temperatures);