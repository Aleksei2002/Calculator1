using System;

class Program
{

    static void Main(string[] args)
    {


        //Console.WriteLine('*');
        //Console.WriteLine('*');
        //Console.WriteLine('*');
        //Console.WriteLine('*');
        //Console.WriteLine('*');

        for (int i = 1; i <= 5; i++) //i = 1 - начальная переменная
        {
            Console.WriteLine('*');
        }
        Console.WriteLine();

        //====================================================================


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0, 3} {1, 3}", i, i * i);
        }
        Console.WriteLine();

        //====================================================================

        for (int i = 1, a = 2; i < 10; i++, a += 2)
        {
            Console.WriteLine("{2} Step: {0, 3} {1, 3}", a, a * a, i) ;
        }
        Console.WriteLine();

        //====================================================================

        for (int i = 1, a = 1; i < 10; i++, a += 1)
        {
            Console.WriteLine("{0, 3} {1, 3}", a, a * a);
        }

        //====================================================================

        /*
         
            *****
            *****
            *****
            *****
            *****

         */

        Console.WriteLine();

        for (int row = 1; row <= 5; row++)
        {
            for (int i = 1; i <= row; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int row = 1; row <= 5; row++)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        //====================================================================

        Console.WriteLine();

        for (int row = 5; row >= 1; row--) // строка
        {
            for (int i = 1; i <= row; i++) // количество звезд 
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        //====================================================================

        /*

        *****
        *   *
        *   *
        *   *
        *****
         
         */

        Console.WriteLine();

        for (int row = 1; row <= 5; row++) // строка
        {
            if (row == 1 || row == 5) // количество звезд 
            {
                for (int i = 1; i <=5; i++)
                {
                    Console.Write('*');
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1 || i == 5)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' '); //' '
                    }
                }
            }
            Console.WriteLine();
        }

        //====================================================================

        Console.WriteLine();

        int x = 3;
        while (x > 0)
        {
            Console.WriteLine("x: {0}", x);
            x--;
        }
        Console.WriteLine("Out of Loop");

        //====================================================================
        /*
        Console.WriteLine();

        string password = "xyz123";
        string word;

        do
        {
            Console.Write("Input Password");
            word = Console.ReadLine();
        } while (password != word);
        */

        //====================================================================

        Console.WriteLine();

        int k = 10, y;
        for (y = 0; y < k; y++)
        {
            Console.WriteLine(y);
            if (y == 3)
                break;
        }
        /*
        0
        1
        2
        3
         */
        Console.WriteLine();
        for (y = 0; y < x; y++)
        {
            if (y == 3)
                break;
            Console.WriteLine(y);
        }

        //====================================================================

        Console.WriteLine();
        for (int n = 0; n < 10; n++)
        {
            if (n == 3)
                continue;
            if (n == 8)
                break;
            Console.WriteLine(n);
        }

        //Написать программу, которая вычисляет сумму первых 20 целых положительных
        //чисел

        int summa = 0;
        for (int i = 1; i<=20; i++)
        {
            summa += i;
        }
        Console.WriteLine("summa {0}", summa);

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}