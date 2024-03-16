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
        int summa = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Ввод массива целых чисел: {0}", i);
            int element = int.Parse(Console.ReadLine());
            array[i] = element;
        }

        foreach(int item in arr)
        {
            Console.WriteLine(item);
            summa += item
                count++;
        }

        Console.WriteLine(summa / count);

        int max = 0;

        foreach(int item in array)
        {
            if(item > max)
            {
                max = item;
            }
        }

        Console.WriteLine(max);

        int minimum = 0

        foreach(int item in array)
        {
            if (item < minimum)
            {
                minimum = item;
            }
        }

        Console.WriteLine(minimum);

        Console.ReadKey();

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}