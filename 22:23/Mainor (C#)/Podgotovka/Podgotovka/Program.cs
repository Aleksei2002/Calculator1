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

        // Оператор запятая в цикле for
        // Печатаем таблицу первых 10 четных чисел

        for (int i = 1, a = 1; i <= 10; i++, a += 2)
        {
            Console.WriteLine("{0,2} {1,3}", a, a * a);
        }
        // Console.ReadKey();

        Console.WriteLine();

        // Управляющий переменную k цикла и переменную x объявляем до конца
        int k;
        double x;

        for(k = 1, x = -0.5; k <= 10; k++, x += 0.5)
        {
            Console.WriteLine("{0,6:f2}", x);
        }
        Console.WriteLine();

        Console.WriteLine("k = {0}", k); //11
        Console.WriteLine("x = {0}", x);
        //=====================================================================
        //Switch
        /*
        Демонстрируется работы оператора Switch

        */
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine("i = {0}", i);
            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("Low number");
                    break;
                case 3:
                    Console.WriteLine("3");
                    goto case 4;
                case 4:
                    Console.WriteLine("Middle Number");
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Default Number");
                    break;
            }
        }

        double d1 = 3.5;
        double d2 = 7;
        char znak = '-';

        double y = 0;

        switch (znak)
        {
            case '+': y = d1 + d2; break;
            case '-': y = d1 - d2; break;
            case '/': y = d1 / d2; break;
            case '*': y = d1 * d2; break;
        }
        Console.WriteLine("{0,2} {1} {2,1} = {3,4}", d1, znak, d2, y);

        /*
        Написать программу, которая считывает символы, вводимые с клавиатуры, до тех пор,
        пока не будет введен символ точки(.)

        Программа должна сосчитать количество введенных пробелов и вывести это число в конце программы. 
        */

        char sym;
        int count = 0;

        do
        {
            Console.Write("Input char:");
            sym = Char.Parse(Console.ReadLine());

            if (sym == ' ')
            {
                count++;
            }
        } while (sym != '.');

        Console.WriteLine("count = {0}", count);

        //Генерация случайных чисел

        int aa;
        Random obj = new Random();

        for (int i = 1; i <= 10; i++)
        {
            aa = obj.Next(1, 101); //[1,100]
            Console.Write("{0,5}", aa);
        }

        Console.WriteLine();

        // foreach
        int[] array = new int[10];

        foreach (int nn in array)
        {
            Console.Write("{0,5}", nn);
        }
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 255 * i;
        }

        foreach (int nn in array)
        {
            Console.Write("{0,5}", nn);
        }
        Console.WriteLine();


       for(int i = 0; i < array.Length / 2; i++)
        {
            array[i] *= -1;
        }

       foreach(int nn in array)
        {
            Console.Write("{0,5}", nn);
        }
        Console.WriteLine();

        int kk = 0;
        foreach (int n in array)
        {
            Console.WriteLine(n);
            kk++;
            if (kk == array.Length / 2)
                break;
        }
        Console.WriteLine();

        // Определить, является ли числовое значение положительным или отрицательным.
        int h;

        for( h = -5; h <= 5; h++)
        {
            Console.Write("Проверка " + h + " ");

            if (h < 0)
                Console.WriteLine("Отрицательное число");
            else
                Console.WriteLine("Положительное число");
        }
        Console.WriteLine();

        // Определить, является ли числовое значение
        // положительным, отрицательным или нулевым.

        int ii;

        for(ii = -5; ii <= 5; ii++)
        {
            Console.Write("Проверка " + ii + ": ");
            if (ii < 0)
                Console.WriteLine("Отрицательное число");
            else if (ii == 0)
                Console.WriteLine("Число без знака");
            else
                Console.WriteLine("Положительное число");
        }

        Console.WriteLine();

        int number;

        for(number = 2; number < 12; number++)
        {
            if ((number % 2) == 0)
                Console.WriteLine("Наименьший множитель числа " + number + " равен 2.");
            else if ((number % 3) == 0)
                Console.WriteLine("Наименьший множитель числа " + number + " равен 3.");
            else if ((number % 5) == 0)
                Console.WriteLine("Наименьший множитель числа " + number + " равен 5.");
            else if ((number % 7) == 0)
                Console.WriteLine("Наименьший множитель числа " + number + " равен 7.");
            else
                Console.WriteLine(number + " не делится на 2, 3, 5 или 7.");
        }

        Console.WriteLine();

        // Метод Switch

        int ik;
        for (ik = 0; ik < 10; ik++)
            switch (ik)
            {
                case 0:
                    Console.WriteLine("i равно нулю");
                    break;
                case 1:
                    Console.WriteLine("i равно единице");
                    break;
                case 2:
                    Console.WriteLine("i равно двум");
                    break;
                case 3:
                    Console.WriteLine("i равно трем");
                    break;
                case 4:
                    Console.WriteLine("i равно четырем");
                    break;
                default:
                    Console.WriteLine("i равно или больше пяти");
                    break;
            }
        Console.WriteLine();

        char ch;

        for(ch = 'A'; ch <= 'E'; ch++)
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("ch содержит A");
                break;
                case 'B':
                    Console.WriteLine("ch содержит B");
                break;
                case 'C':
                    Console.WriteLine("ch содержит C");
                break;
                case 'D':
                    Console.WriteLine("ch содержит D");
                break;
                case 'E':
                    Console.WriteLine("ch содержит E");
                break;
            }
        Console.WriteLine();

        int c;

        for (c = 1; c < 5; c++)
        {
            switch (c)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("i равно 1, 2 или 3");
                    break;
                case 4:
                    Console.WriteLine("i равно 4");
                    break;
            }
        }
        Console.WriteLine();


        // Выяснить, является ли число простым. Если оно
        // непростое, вывести наибольший его множитель.

        int num;
        int iii;
        int factor;
        bool isprime;
        for (num = 2; num < 20; num++)
        {
            isprime = true;
            factor = 0;
            // Выяснить, делится ли значение переменной num нацело.
            for (iii = 2; iii <= num / 2; iii++)
            {
                if ((num % iii) == 0)
                {
                    // Значение переменной num делится нацело.
                    // Следовательно, это непростое число.
                    isprime = false;
                    factor = iii;
                }
            }
            if (isprime)
                Console.WriteLine(num + " — простое число.");
            else
                Console.WriteLine("Наибольший множитель числа " + num +
                " равен " + factor);
        }
        Console.WriteLine();


        int ig, j;
        for (ig = 0, j = 10; ig < j; ig++, j--)
            Console.WriteLine("i и j: {0} {1}", ig, j);
    

    Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}