using System;

namespace ClassDemo_1_Line;
class Program
{
    static void Main(string[] args)
    {
        string[] name = { "Egor", "Boris", "Anna", "Oleg", "Ivan", "Lena", "Aleksandr" };

        //Отобразить ков-во элементов в массиве при помощи своиства Length
        Console.WriteLine("name.Length = {0}", name.Length); //7

        //1 - отобразить содержимое массива:
        for(int i = 0; i<name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
        Console.WriteLine();

        Array.Sort(name);

        //2 - отобразить содержимое массива:
        foreach (string s in name)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();


        Array.Reverse(name);

        foreach (string s in name)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();

        //********************************************************************

        int[] intArray = { 100, 50, 5, 1, 0, 25 };
        foreach(int n in intArray)
        {
            Console.WriteLine("{0, 5}", n);
        }
        Console.WriteLine();

        Array.Sort(intArray);

        foreach (int n in intArray)
        {
            Console.WriteLine("{0, 5}", n);
        }
        Console.WriteLine();

        //********************************************************************

        Line[] arrayLine =
        {
            new Line(25), new Line(), new Line(5),
            new Line(15), new Line(10), new Line(20),
        };

        foreach (Line obj in arrayLine)
        {
            obj.Draw();
        }
        Console.WriteLine();

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}