using System;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        //КОНТРОЛЬНАЯ РАБОТА НОМЕР 20 АЛЕКСЕЙ МАЛЫШКИН
        // Для использования кириллицы в консольных приложениях
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.GetEncoding(1251);
        #region Nomer 1 Написать фрагмент программы, который выводит таблицу значений функции 

        Console.WriteLine("X \t Y");
        double y;
        for (double x = -2.0; x <= 0.5; x += 0.5)
        {
            y = x * x - 3;
            Console.WriteLine(string.Format("{0} \t {1}", x, y));
        }

        Console.WriteLine();
        
        #endregion

        #region Написать программу, которая выводит на экран фигуру
        /* **********
            *********
             ********
              *******
               ******
                *****
                 ****
                  ***
                   **
                    *
         */

        int row = 11;
        int a, b, c;
        for (a = 1; a <= row; a++)
        {
            for (b = 1; b <= a; b++)
            {
                Console.Write(" ");
            }
            for (c = 1; c <= row - a; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();



        #endregion

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}