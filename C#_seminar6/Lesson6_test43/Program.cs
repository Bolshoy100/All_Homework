// Сoordinates of the intersection of straight lines

double b1; double k1; double b2; double k2;

Console.Write("Input b1: ");
b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine($"({x}; {y})");

// Здравствуйте, Павел. У меня не получилось реализовать решение путем метода.
//Точнее не смог разобраться с выводом в консоль сразу двух переменных x и y.

/*
double CoordIntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
}

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CoordIntersectionLines()($"({x}; {y})"));
*/

