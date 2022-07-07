// NCub
void NCubed(int n)
{    
    int current = 1;
    while (current <= n)
        {
        int nqub = current * current * current;
        Console.Write(nqub + " ");
        current++;
        }
}

Console.Write("Input any number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
NCubed(n1);