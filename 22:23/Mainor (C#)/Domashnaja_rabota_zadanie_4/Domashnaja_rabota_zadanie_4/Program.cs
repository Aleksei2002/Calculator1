using System;

class Program
{

    static void Main(string[] args)
    {

        Console.Write("Сторона A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Сторона B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Сторона C: ");
        double c = double.Parse(Console.ReadLine());

        if ((a + b > c) && (b + c > a) && (a + c > b))
        {
            if (a == b && a == c && b == c)
            {
                Console.WriteLine("Ravnostoronnij");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Ravnobedrennij");
            }
            else
            {
                Console.WriteLine("Raznostoronnij");
            }

        }
    }

}