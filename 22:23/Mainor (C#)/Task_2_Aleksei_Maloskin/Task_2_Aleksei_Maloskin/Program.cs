using System;

class Program
{

  static void Main(string[] args)
  {

        #region 1 Задание

        /*Написать программу, которая выдаёт таблицу курса
        USD - Доллар США и EUR -евро.*/

        double a = 1.05;
        double u = 0.94;

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} USD = {u*i:f2}; {i} EUR = {a*i:f2}");
        }

        #endregion

        #region 2 задание

        /*Написать программу, которая выводит таблицу значений функции
        Y = -2,4 * x * x + 5 * x - 3 в диапазоне от –2 до 0,5 с шагом 0,5.*/
        Console.WriteLine();

        double x;

        for (x = -2; x < 0.6; x += 0.1)
        {
            double y = 2.4 * x * 2 + 5 * x - 3;
            Console.WriteLine("{0:N}", x, y);
        }

        #endregion

        #region 3 задание
        Console.WriteLine();

        //Написать программу, которая вычисляет сумму первых 20 целых положительных
        //чисел

        int summa = 0;
        for (int i = 1; i <= 20; i++)
        {
            summa += i;
        }
        Console.WriteLine("summa {0}", summa);

        #endregion

        #region 4 задание

        /*Написать программу, которая выводит на экран таблицу умножения, 
        например,на7.*/

        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("7 * {0} = {1}", i, i * 7);
        }

        #endregion

        #region 5 задание

        /*Написать программу, которая выводит на экран квадрат Пифагора
        – таблицу умножения.*/

        Console.WriteLine("\n        1\t2\t3\t4\t5\t6\t7\t8\t9\t10");

        Console.WriteLine();
        for (int i = 1; i < 10; i++)
        {
            Console.Write(i);
            for (int y = 1; y < 11; y++)
            {
                Console.Write("\t" + i * y);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        Console.ReadLine();

        #endregion
    }

}