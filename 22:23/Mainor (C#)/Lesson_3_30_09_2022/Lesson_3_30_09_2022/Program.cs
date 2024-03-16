using System;


class Program
{
    static void Main(string[] args)
    {
        #region Примеры на использование оператора if
        
        int x = 5, y = 1, z;
        if (x < y)     // (5 < 2)
        {
            z = 1;
        }
        else
        {
            z = 2;    //!!!
        }

        Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);  // x = 5, y = 1, z = 2;
        Console.WriteLine(); //пустая строка
       
        //********************************************

        x = 15;
        if (x > 10)  // проверка на истинность условия (15  > 10)
        {
            x = 2 * x;
            Console.WriteLine("\t x > 10\n\n");
        }
        Console.WriteLine("x = {0} ", x); // x = 30

        x = 5;
        if (x > 10)      // проверка на НЕ истинность условия (5  > 10)
        {
            x = 2 * x;
            Console.WriteLine("x > 10");
        }
        Console.WriteLine("x = {0} ", x); // x = 5

        Console.WriteLine(); //пустая строка

        //*************************************************

        // Пример с вложенными условными операторами:
        x = 1;
        y = 2;
        Console.WriteLine("\n\nx = {0} ", x);
        Console.WriteLine("y = {0} ", y);

        if (x == 1)
        {
            Console.WriteLine(" x = 1\n");

            if (y == 2)
            {
                Console.WriteLine("y = 2\n");
            }
        }
        else
        {
            Console.WriteLine("x != 1\n");
        }

        /*   Проверяем работу каждого оператора if на истинность и на ложь (true/false)
             x=1, y= 2    =>           x = 1;  y = 2
             x=2, y= 2    =>           x != 1; 
             x=1, y= 1    =>           x = 1;

         */


        //***********************************************
        Console.WriteLine(); //пустая строка
        #endregion

        #region Знакомство с классом Random

        // Генерация псевдослучайных чисел
        //для генерации псевдослучайных чисел предназначен класс «Random».

        Random obj = new Random();        //создаём объект класса Random
        /*
        мы использовали конструктор по умолчанию Random(), 
        «начальное значение» задается на основании системного/компьютерного времени.
        При каждом запуске программы будет генерироваться различная последовательность чисел.
        */

        //Random obj = new Random(5000); 
        //- каждый раз будет генерироваться одна и таже последовательность чисел, так как  «начальное значение» = 500

        int a1 = obj.Next();       // Получить очередное случайное число в интервале [0 maxInt32-1] 
        int a2 = obj.Next(1, 10); // [1, 9]

        Console.WriteLine("a1 = {0} a2 = {1}", a1, a2);

        a1 = obj.Next(-100, 101);  //[-100, 100]
        a2 = obj.Next(101);         //[0, 100]

        Console.WriteLine("a1 = {0} a2 = {1}", a1, a2);

        #endregion
        //*******************************

        #region Нахождение минимального значения и цикл for

        Console.WriteLine("\n\n Min(a1,a2): "); 

        for (int i = 10; i >= 1; i --)   // "зациклили" процесс генерации 2-х псевдослучайных чисел и нахождения минимального значения
        {
            a1 = obj.Next(-50, 51);   //[-50, 50]
            a2 = obj.Next(-50, 51);

            Console.WriteLine("\n{2}. a1 = {0} a2 = {1}", a1, a2, i);

            int min;

            if (a1 < a2)
            {
                min = a1;
            }
            else
            {
                min = a2;
            }

            Console.WriteLine("min = {0}", min);
        }
        #endregion

        //*******************************************

        #region небольшое отступление про символы на клавиатуре и их кодировку

        Console.WriteLine();
        char ch = 'G'; // объявили переменную символьного типа

        if (ch >= 'A' && ch <= 'Z')  //проверяем, является ли символ заглавной буквой латинского алфавита
        {
            Console.WriteLine("{0} >= 'A' && {0} <= 'Z' Ok!", ch);
        }

        if (ch >= 'a' && ch <= 'z')  //проверяем, является ли символ прописной буквой латинского алфавита
        {
            Console.WriteLine("Ok!");
        }

        if (ch >= '0' && ch <= '9') //проверяем, является ли символ цифрой
        {
            Console.WriteLine("Ok!");
        }

        Console.WriteLine("{0} - {1}", ch, (int)ch);                         // печатаем символ и его код АSCII
        Console.WriteLine("{0} - {1}", (char)(ch + 32), (int)(ch + 32));     

        //*******************************************
        #endregion

        
        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();

        Console.Clear();  //Очищает экран дисплея

        #region  является ли четным целое число?

        Console.WriteLine();
        //  Написать программу, которая проверяет, является ли четным целое число.

        Random random = new Random();  // создали новый объект класса Random.
        int number;

        number = random.Next(1, 10001);
        Console.Write("\n number = {0} ", number);

        if (number % 2 == 0)   //проверяем число на чётность, остаток от деления на 2 должен равняться 0
        {
            Console.WriteLine(" - chetnoe");
        }
        else
        {
            Console.WriteLine(" - nechetnoe");
        }

        #endregion
        
        Console.WriteLine();
        
        //****************************************
        
        /*
        Написать программу вычисления стоимости покупки с учетом скидки. 
        Скидка 10% предоставляется, если сумма покупки больше 1000 euro.
        
        Сумма покупки 1200 
        Cкидка – 10% 
        С учетом скидки Сумма 1080
        */

        double summaP = 1200;
        //double summaP = 200;

        double skidka = 0;

        Console.WriteLine("Summa: {0:f2}", summaP);

        if (summaP > 1000)
        {
            skidka = summaP * 0.1;
            Console.WriteLine("skidka 10% : {0:f2}", skidka);
        }

        summaP = summaP - skidka;  //   summaP -= skidka;

        Console.WriteLine("summaP : {0:f2}", summaP);

        //*****************************************

        /*
        Написать программу вычисления стоимости покупки с учетом скидки.
        Скидка 3 % предоставляется в том случае, если
        сумма покупки больше 500 euro,

        5 % -если сумма больше 1000 euro.
        
        Сумма покупки 640
        Cкидка – 3 %
        С учетом скидки Сумма 620.80
        */
        Console.WriteLine();

        summaP = 640;
        skidka = 0;

        Console.WriteLine("Summa: {0:f2}", summaP);

        //проверка суммы покупки на скидку
        // if(summaP > 1000)
        // {
        //     skidka = summaP * 0.05;
        //     Console.WriteLine("skidka 5% : {0:f2}", skidka);
        // }
        //else if(summaP > 500)
        // {
        //     skidka = summaP * 0.03;
        //     Console.WriteLine("skidka 3% : {0:f2}", skidka);
        // }

        // альтернативный способ организации проверки суммы на скидку

        if (summaP > 500 && summaP <= 1000)
        {
            skidka = summaP * 0.03;
            Console.WriteLine("skidka 3% : {0:f2}", skidka);
        }
        else if (summaP > 1000)
        {
            skidka = summaP * 0.05;
            Console.WriteLine("skidka 5% : {0:f2}", skidka);
        }


        summaP -= skidka;

        Console.WriteLine("summaP : {0:f2}", summaP); //f2 - 2 знака после запятой Float 
        
        //****************************************

        Console.WriteLine();
        int a = 5, b = 10, max;

        Console.WriteLine("Max({0},{1}) = {2}", a, b, max = (a > b) ? a : b);



        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }//end Main
}