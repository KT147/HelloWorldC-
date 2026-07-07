int[,] array = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    System.Console.WriteLine(sum);
    sum = 0;
}