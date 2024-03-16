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

        // Номер варианта 21 Алексей Малышкин

        int[] array = new int[7];
        double summa = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("a[{0}] -> ", i + 1);
            int element = int.Parse(Console.ReadLine());
            array[i] = element;
        }

        foreach (int item in array)
        {
            Console.Write("{0, 5}", item);
            summa += item;
            //count++;
        }

        Console.WriteLine();

        Console.WriteLine("Среднее арифметическое {0,6:f2}", summa / array.Length);

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

        }

        Console.WriteLine("Максимальное значение: {0}",max);

        int minimum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }

        Console.WriteLine("Минимальное значение: {0}", minimum);
        Console.ReadKey();

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}