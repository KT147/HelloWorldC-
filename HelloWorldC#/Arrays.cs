int[] intArray = [1, 2, 3];
System.Console.WriteLine(intArray[0]);

string[] weekDays = ["Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"];
System.Console.WriteLine("Weekdays length " + weekDays.Length);

foreach (string day in weekDays)
{
    System.Console.WriteLine("Weekdays are " + day);
}

int[,] array2DDeclaration = new int[3, 3];
int[,,] array3DDeclaration = new int[3, 3, 3];

int[,] array2DInitialized = { { 1, 2 }, { 3, 4 } };

System.Console.WriteLine(array2DInitialized[0, 0]);

string[,,] simple3DArray = {
    {
        {"000", "001"},
        {"010", "011"}
    }, {
        {"100", "101"},
        {"110", "111"}
    }
};

System.Console.WriteLine(simple3DArray[0, 1, 0]);
