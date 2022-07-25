//The string with the smallest summ
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input square array size: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int n = m;

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

int minsum = Int32.MaxValue;
int minRow = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum = sum + myArray[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        minRow++;
    }
}
Console.WriteLine("The row with the minimum sum of elements is: " + (minRow));
Console.WriteLine();