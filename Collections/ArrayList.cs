using System.Collections;

ArrayList myArrayList = new ArrayList();

myArrayList.Add(25);
myArrayList.Add("Hello");
myArrayList.Add(13);
myArrayList.Add(35);
myArrayList.Add(13);

myArrayList.Remove(13);
myArrayList.RemoveAt(0);
System.Console.WriteLine(myArrayList.Count);

double sum = 0;

foreach (object obj in myArrayList)
{
    if (obj is int)
    {
        sum += Convert.ToDouble(obj);
    }
    else if (obj is double)
    {
        sum += (double)obj;
    }
    else if (obj is string)
    {
        System.Console.WriteLine(obj);
    }
}

System.Console.WriteLine(sum);