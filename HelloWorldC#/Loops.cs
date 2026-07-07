string myString = "Hi \r\n Hi";

for (int i = 10; i >= 0; i--)
{
    System.Console.WriteLine("Count is " + i);
    Thread.Sleep(1000);
}

bool isCounting = true;
int counter = 0;

while (isCounting)
{
    System.Console.WriteLine(counter);
    Thread.Sleep(300);
    counter++;

    if (counter == 5)
    {
        isCounting = false;
        System.Console.WriteLine("This is the end");
    }
}

int counter2 = 0;

do
{
    System.Console.WriteLine(counter2);
    counter2++;
} while (counter < 10);