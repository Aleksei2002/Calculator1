using System;

class Program
{

    static void Main(string[] args)
    {
        int a, b, c;
        double result;

        Console.Write("Введите a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите c: ");
        c = Convert.ToInt32(Console.ReadLine());

        double d = b * b - 4 * a * c; // указываем чему равен d

        if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine(x);
        }

        else

        if (d > 0)
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }

        else
        {
            Console.WriteLine("Нет решений");
        }
        Console.ReadKey();
    }

}