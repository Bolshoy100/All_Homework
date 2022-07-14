// sum of even elements

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

int SumEven(int[] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
return count;    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.Write("The sum of even numbers is: " + (SumEven(array)));
