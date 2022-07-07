// Palindrome

void Palindr(int num)
{   
    string str = num.ToString();
    if ((str[0]) == (str[4]) && (str[1]) == (str[3]))
        Console.Write(num + ": the number is a palindrome");
    else
        Console.Write(num + ": the number is not a palindrome");
} 
      
Console.Write("Enter a five-digit number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Palindr(n1);
