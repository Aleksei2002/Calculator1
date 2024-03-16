using System;
using Abstract_Class_Figure;

class Program
{

    static void Main(string[] args)
    {
        //Figure obj = new Figure();
        ////Console.WriteLine(obj.ToString());
        //Console.WriteLine(obj); //0*0

        //Figure obj1 = new Figure(10, 15.5);
        //Console.WriteLine(obj1);

        //Console.WriteLine("{0} * {1}", obj.Length, obj.Width);

        //Figure obj2 = new Figure(-10, 15.5);
        //Console.WriteLine(obj2);

        Rectangle rect1 = new Rectangle();
        Console.WriteLine(rect1); // 1*1
        Console.WriteLine("Area = {0}", rect1.Area()); //1

        Rectangle rect2 = new Rectangle(5,8);
        Console.WriteLine(rect2); // 5*8
        Console.WriteLine("Area = {0}", rect2.Area()); //40

        Rectangle rect3 = new Rectangle(5, -8);
        Console.WriteLine(rect3); // 5*8
        Console.WriteLine("Area = {0}", rect3.Area()); //-40

        rect3 = new Rectangle(5, 80);
        Console.WriteLine(rect3); // 5*80
        Console.WriteLine("Area = {0}", rect3.Area()); //-400

        double S = rect3.Area();
        Console.WriteLine("Area = {0}", S);

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}