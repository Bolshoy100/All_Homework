// the second of the three

void SecondDigit()
{
    int num;
    
	Console.Write("Enter a three-digit number: ");
	num = Convert.ToInt32(Console.ReadLine());

    if (num < 100 | num > 999)
    {
    Console.Write("Error. Enter a three-digit number");
    }
    else
    {int num1;
    num1 = ((num % 100) / 10);
    Console.WriteLine("The second number is: " + num1);
    }
}

SecondDigit();
