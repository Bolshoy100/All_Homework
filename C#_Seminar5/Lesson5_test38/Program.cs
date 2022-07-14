//the difference between the maximum and minimum numbers

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

int DiffMaxMin(int[] array)
{   
    int min1 = 0;
    int max1 = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] < array[min1]) min1 = i;
        if(array[i] > array[max1]) max1 = i;
    }    
    int diff = array[max1] - array[min1];
    return diff;
}    

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.Write("The difference between the maximum and minimum numbers is: " + (DiffMaxMin(array)));