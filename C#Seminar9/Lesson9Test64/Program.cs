//how many digits?

int NumDigits(int n)
{
    if (n < 10)
    {
        return 1;
    }
    return (NumDigits(n / 10)) + 1;
}
Console.Write("Input any number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Total digits in this number is: " + NumDigits(n));