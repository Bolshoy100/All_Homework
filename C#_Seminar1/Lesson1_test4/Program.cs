// max of the three

int num1, num2, num3;
int max;

Console.Write("Input a first number:  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number:  ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
            
Console.WriteLine("Max number: " + max);

