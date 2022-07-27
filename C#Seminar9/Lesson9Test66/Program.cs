// Sum of elements from N up to M

void DigitsSum(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Sum of elements from n up to m is: {sum}"); 
        return;
    }
    sum = sum + (m++);
    DigitsSum(m, n, sum);
}

Console.WriteLine("Enter the minimum number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum number n: ");
int n = Convert.ToInt32(Console.ReadLine());

DigitsSum(m, n, 0);