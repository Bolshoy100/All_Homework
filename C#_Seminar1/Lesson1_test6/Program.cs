// even or odd

int num1;

Console.Write("Input a number: ");
num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 % 2) == 0)
{
    Console.WriteLine(num1 + " Чётное число");
}
else
{
    Console.WriteLine(num1 + " Нечетное число");
}