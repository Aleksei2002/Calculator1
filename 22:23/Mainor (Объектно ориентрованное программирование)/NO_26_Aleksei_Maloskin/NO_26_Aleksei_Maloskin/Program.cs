using System;
using System.Drawing;
using NO_26_Aleksei_Maloskin;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5.5, "red", false);
            Console.WriteLine(c1);
            Console.WriteLine(c1.GetArea());
            Console.WriteLine(c1.GetPerimeter());
            Console.WriteLine(c1.GetColor());
            Console.WriteLine(c1.IsFilled());
            Console.WriteLine(c1.GetRadius());

            Rectangle r1 = new Rectangle(1.0, 2.0, "red", false);
            Console.WriteLine(r1);
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(r1.GetPerimeter());
            Console.WriteLine(r1.GetColor());
            Console.WriteLine(r1.GetLength());

            Square s1 = new Square(6.6);
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(s1.GetColor());
            Console.WriteLine(s1.GetSide());

            Console.ReadLine();
        }
    }
}