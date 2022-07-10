int SumNum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a /10 ;
    }
    return sum;
}   
    
Console.Write("Enter any number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of all digits of the number {num} is {SumNum(num)}");