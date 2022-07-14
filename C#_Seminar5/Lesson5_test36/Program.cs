//sum of elements in odd positions

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; // Строка инициализирует массив newArrey

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{ 
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

        Console.WriteLine();
}

int SumElemOddPos(int[] array)
{
    int count = 0;
     for (int i = 1; i < array.Length; i += 2)
    {   
        
        count += array[i];
    }
return count;    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.Write("The sum of the elements in odd positions is: " + (SumElemOddPos(array)));