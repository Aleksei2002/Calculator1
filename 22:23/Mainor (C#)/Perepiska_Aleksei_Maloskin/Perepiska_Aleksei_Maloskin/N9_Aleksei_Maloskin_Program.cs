using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        // Для использования кириллицы в консольных приложениях
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.GetEncoding(1251);

        // Номер варианта 9 Алексей Малышкин

        //N1

        int x, y, z;
        for (x = 7; x >= 1; x--)
        {
            for (y = 1; y < x; y++)
            {
                Console.Write(" ");
            }
            for (z = 10; z >= x; z--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // N2

        double person;

        person = 30 * 2 / 0.65;

        Console.WriteLine("За стол может поместиться: {0:f0} человека", person);

        Console.ReadLine();

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}