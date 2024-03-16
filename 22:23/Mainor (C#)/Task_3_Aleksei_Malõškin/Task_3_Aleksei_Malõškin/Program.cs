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

        Random ran = new Random();

        Console.Write("Для N = имеем ");
        int N = int.Parse(Console.ReadLine());
        int count = 0;

        int[] points = new int[N];
        int[] marks = new int[N];

        for (int i = 0; i < points.Length; i++)
        {
            points[i] = ran.Next(1, 100); //случайное число от 1 до 100

            if (points[i] <= 100 && points[i] >= 91)
            {
                marks[i] = 5;
            }
            else if (points[i] <= 90 && points[i] >= 81)
            {
                marks[i] = 4;
            }
            else if(points[i] <= 80 && points[i] >= 71)
            {
                marks[i] = 3;
            }
            else if(points[i] <= 70 && points[i] >= 61)
            {
                marks[i] = 2;
            }
            else if(points[i] <= 60 && points[i] >= 51)
            {
                marks[i] = 1;
            }
            else if(points[i] <= 50)
            {
                marks[i] = 0;
            }
            Console.WriteLine("{0,4}. {1,4} баллов, оценка:{2,4}", i + 1, points[i], marks[i]);

            if (marks[i] == 5 || marks[i] == 4)
                count++;
        }
        Console.WriteLine("Оценок 5 и 4 - {0}", + count);
        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}