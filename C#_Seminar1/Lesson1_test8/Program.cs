// all even up to n

int n, current;

Console.Write("Input any number: ");
n = Convert.ToInt32(Console.ReadLine());

current = 2;

while (current <= n)
{
    Console.Write(current + " ");
    current = current + 2;
}