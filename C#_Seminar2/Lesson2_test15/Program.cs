// workday or weekend

void WeekDay()
{
	int num;
	Console.Write("Input any week day number from one to seven: ");
	num = Convert.ToInt32(Console.ReadLine());
    
	if (num > 7) Console.WriteLine("the day of the week does not exist");
    if (num == 1) Console.WriteLine("Monday is a workday");
	if (num == 2) Console.WriteLine("Tuesday is a workday");
	if (num == 3) Console.WriteLine("Wednesday is a workday");
	if (num == 4) Console.WriteLine("Thursday is a workday");
	if (num == 5) Console.WriteLine("Friday is a workday");
	if (num == 6) Console.WriteLine("Saturday is a weekend");
	if (num == 7) Console.WriteLine("Sunday is a weekend");
}

WeekDay();