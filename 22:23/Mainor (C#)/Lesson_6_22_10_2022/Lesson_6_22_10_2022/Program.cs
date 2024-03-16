using System;
using System.Text;

class Programm
{
    static void Main(string[] args)
    {


        #region Заданы три числа a, b, c
        /*Заданы три числа a, b, c. Определить, могут ли они быть сторонами треугольника, и если да, то определить его тип:
        равносторонний, равнобедренный, разносторонний.
        Замечание.Условия существования треугольника:

        Нельзя исключать экстремальных случаев, когда одна(или
        несколько) сторон равны нулю, либо когда одно из неравенство
        переходит в равенство(треугольник нулевой площади).
        */

        // для использования кириллицы

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.GetEncoding(1251);

        /*
         Основное условие существования треугольника - это выполнение условия
        if (a + b > c && a + c > b && b + c > a)

        или

        наибольшая сторона меньше суммы двух других
         */



        //"Треугольник равносторонний."
        double a = 10;
        double b = 10;
        double c = 10;

        //Треугольник равнобедренный.(большая сторона меньше суммы 2-х других)
        //double a = 10;
        //double b = 10;
        //double c = 13;

        //2-ой случай
        //double a = 10;
        //double b = 13;
        //double c = 13;



        //треугольник разносторонний (большая сторона меньше суммы 2-х других) - общий случай треугольник
        //double a = 13;
        //double b = 15;
        //double c = 25;

        //"вырожденный" треугольник  - треугольник нулевой площади a + b == c || a + c == b || b + c == a
        //double a = 10;
        //double b = 15;
        //double c = 25;  //максимальная сторона равна сумме двух других

        // одна (или несколько) сторон равны нулю
        //double a = 10;
        //double b = 0;
        //double c = 25;

        //Если большая сторона меньше, чем сумма двух других сторон - это обчный треугольник

        //Случай с нулевой площадью - это "вырожденный" треугольник, когда большая сторона равна сумме 2-х других
        //Если большая сторона больше, чем сумма двух других сторон - нельзя построить треугольник
        // if (a + b >= c && a + c >= b && b + c >= a)  - учитывается вырожденный тр-к


        if (a > 0 && b > 0 && c > 0)  //сторона не может быть 0 или меньше 0
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c) //(a == b && a == c && b == c) - если 1 сторона равна двум другим, то проверять третье условие b == c не нужно
                {
                    Console.WriteLine("Треугольник равносторонний."); // частный случай равнобедренного
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Треугольник равнобедренный.");
                }
                else
                {
                    Console.WriteLine("Треугольник разносторонний.");
                }
            }
            else if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("Треугольник не существует  -  вырожденный треугольник, площадь равна 0 ");
            }
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }

        //===============================================================


        Console.WriteLine();
        Console.Write("Press any key to continue...");
        // pause - задержка экрана, пока пользователь не нажмет любую клавишу Console.ReadKey()
        Console.ReadKey();

        #endregion

        #region Написать программу, которая вычисляет дату следующего дня

        int day, mounth, year;

        int lastDay = 0;

        year = 2021;
        mounth = 10;

        if (mounth == 1 || mounth == 3 || mounth == 5 || mounth == 7 || mounth == 8 ||
            mounth == 10 || mounth == 12)
        {
            lastDay = 31;
        }
        else if (mounth == 4 || mounth == 6 || mounth == 9 || mounth == 11)
        {
            lastDay = 30;
        }
        else if (mounth == 2)
        {
            if ((year % 4 == 0) || ((year % 100 == 0) && (year % 400 == 0)))
            {
                lastDay = 29;
            }
            else
            {
                lastDay = 28;
            }
        }

        day = 22;

        Console.WriteLine("Date: {0:d2}.{1:d2}.{2}", day, mounth, year);

        if (mounth > 12 || mounth < 1 || day < 1 || day > lastDay)
        {
            Console.WriteLine("Error Date!");
            Console.ReadKey();
            return; // Выход из программы
        }
        else if (mounth == 12 && day == lastDay)
        {
            day = 1; mounth = 1; year++;
        }
        else if (day == lastDay)
        {
            day = 1; mounth++;
        }
        else
        {
            day++;
        }


        Console.WriteLine(
            "Following Date: {0:d2}.{1:d2}.{2}",
             day, mounth, year);



        Console.ReadKey();

        // Break - прекращаем цикл


        #endregion

        #region Вычисление скорости, с которой спортсмен пробежал дистанцию

        /*
             Написать программу, которая вычисляет скорость, с которой спортсмен пробежал дистанцию. 
             Рекомендуемый вид экрана программы приведен ниже. 
             
            Вычисление скорости бега 

            Длина дистанции (метры) -> 1000
            Время (минут.секунд)-> 3.25

            Дистанция: 1000
            Время: 3 мин 25 сек = 205 сек
            Скорость: 17.56 км/час

             */
        // для использования кириллицы

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.GetEncoding(1251);


        float s; // дистанция
        float t; // время

        float v; // скорость
        int min; // минут
        int sek; // секунд
        float ts; // время в секундах

        s = 1000;
        t = 3.25f; //исполняемая 

        min = (int)t; // 3 минуты
        sek = (int)((t - min) * 100); // Остаток 25 секунд 
        ts = min * 60 + sek; // 205 секунд 


        v = (s / 1000) / (ts / 3600); // 1000м - 3600сек

        Console.WriteLine("Дистанция: {0}", s);

        Console.WriteLine("Время: {0} мин {1} сек = {2,4} сек\n", min, sek, ts);

        Console.WriteLine("Скорость {0,5:f2} км/час", v);


        Console.ReadKey();

        #endregion


    }

}