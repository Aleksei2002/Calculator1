using System;
using System.Text; 

class Program
{

    static void Main(string[] args)
    {

        //для использования кириллицы в коесольных приложениях
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.GetEncoding(1251);


        //Написать программу пересчета величины временного интервала, заданного в минутах, в величину, выраженную в часах и минутах.
        //min = 150;
        //150 min - 2ч. 30мин.

        int min = 150;
        int h, m;

        // 1 способ
        h = min / 60;
        m = min - h * 60;

        Console.WriteLine("{0} минут - {1} ч. {2} мин.",
            min, h, m);

        Console.WriteLine("{0} минут - {1:d2} ч. {2:d2} мин.",
            min, h, m);

        // 2 способ
        // Если результат вычисления не надо сохраниять для дальнейшого использования, то можно не использовать доп. переменные, а делать
        // вычисления в процессе создагния информации для печати

        Console.WriteLine("{0} минут - {1} ч. {2} мин.",
            min, min / 60, min % 60);

        Console.WriteLine("{0} минут - {1:d2} ч. {2:d2} мин.",
            min, min / 60, min % 60);

        //*********************************************************************
        // Программы с линейной структурой
        // Исходные данные
        // Обработка
        // Вывод результата

        // Написать программу вычисления площади прямоугольника

        double a = 5, b = 3.5, S;
        S = a * b;
        Console.WriteLine("\n\n\t a = {0}, b = {1}, a, b ");
        Console.WriteLine("S = {0}", S);

        //*********************************************************************
        float k; // 8 знаков после запятой
        k = 8; // Неявное приведение типа
        k = 32748; // Неявное приведение типа


        // k = 0.1;
        k = 0.1F;
        k = 0.8f;
        k = (float)0.5;

        //*********************************************************************
        Console.WriteLine("\n'n");

        // Напечатать дробное число в денежном формате.
        // Пример, число 75, 25 должно быть преобразовано к виду 75 euro 25 с

        double f = 75.25;
        int euro, s;

        euro = (int)f; //75

        s = (int)((f - euro)*100); //25
        Console.WriteLine("{0} = {1} euro {2} c", f, euro, s);
        Console.WriteLine("{0:C} = {1} euro {2} c", f, euro, s);
        Console.WriteLine("{0}€ = {1} euro {2} c", f, euro, s);

        //*********************************************************************

        Console.WriteLine();

        Console.WriteLine("Фирма \'Рога и Копыта \' ");
        Console.WriteLine("Фирма \"Рога и Копыта \" ");

        Console.WriteLine("C:\\Users\\burgmalmail.ru\\Desktop\\Mainor Üld\\ Mainor(C#)\\Lesson_2_29_09_2022");

        //*********************************************************************

        Console.WriteLine();

        Console.Write("Введите своё имя: ");
        string name = Console.ReadLine(); // Вводим имена консоле
        Console.WriteLine("Привет, {0}", name);

        Console.WriteLine("Привет, {name}");
        Console.WriteLine($"Привет, {name}");

        //*********************************************************************


        name = "Tom";
        int age = 22;
        double height = 1.7;
        Console.WriteLine($"Имя: {name}, возраст: {age}, рост: {height}");
        Console.WriteLine("Имя: {0}, возраст: {1}, рост: {2}", name, age, height);
        //*********************************************************************

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}
