// Total numbers greater than zero
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
} 

void ShowArray(int[] array)
{ 
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

        Console.WriteLine();
}

int PositivElementsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum = sum + 1; 
    }
    return sum;
}

Console.Write("Input size of arrey: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);

Console.WriteLine("Total numbers greater than zero are: " + PositivElementsSum(array));