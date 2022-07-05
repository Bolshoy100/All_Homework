// the third digit
void ThirdDigit()
{
    int num;
    
	Console.Write("Enter any number: ");
	num = Convert.ToInt32(Console.ReadLine());

    if (num < 100)
    {
    Console.Write("The third digit does not exist");
    }
    else
    {
    string str = num.ToString();
    Console.Write("The third digit is " + (str[2]));
    }
}

ThirdDigit();