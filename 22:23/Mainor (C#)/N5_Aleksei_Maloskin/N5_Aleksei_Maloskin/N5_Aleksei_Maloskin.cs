using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        #region Задание 4

        /* Написать программу, которая проверяет, является ли четным, введенное 
        пользователем целое число */

        Random random = new Random();
        int number;

        number = random.Next(1, 10001);
        Console.WriteLine("number = {0}", number);

        Console.WriteLine();


        #endregion

        #region Задание 5

        /* Написать программу, вычисляющу стоимоть поездки на автомобиле на дачу (туда и обратно) */

        //double stoimost;

        //Console.Write("Исходные данные:\n");
        //Console.Write("Расстояние до дачи(км): ");
        //double z = Convert.ToSingle(Console.ReadLine());
        //Console.Write("Кол-во бензина, которое потребляет автомобиль на 100 км пробега: ");
        //double x = Convert.ToSingle(Console.ReadLine());
        //Console.Write("Цена одного литра бензина (euro): ");
        //double o = Convert.ToSingle(Console.ReadLine());
        //stoimost = 2 * z * x / 100 * o;

        //Console.WriteLine("Поездка обойдется в {0:f2} евро ", stoimost);
        //Console.ReadLine();

        #endregion

        #region Задание 5

        /* Написать программу, вычисляющу стоимоть поездки на автомобиле на дачу (туда и обратно) */

        double stoimost;

        Console.Write("Исходные данные:\n");
        Console.Write("Расстояние: ");
        double z = Convert.ToSingle(Console.ReadLine());
        Console.Write("Кол-во бензина, которое потребляет автомобиль на 100 км пробега: ");
        double x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Цена одного литра бензина (euro): ");
        double o = Convert.ToSingle(Console.ReadLine());
        stoimost = 2 * z * x / 100 * o;

        Console.WriteLine("Поездка обойдется в {0:f2} евро ", stoimost);
        Console.ReadLine();

        #endregion

        #region Задание 6

        /* Написать программу, которая вычисляет дату следующего дня */

        DateTime data;
        string input;

        do
        {
            Console.WriteLine("Введите дату в формате дд.ММ.гггг (день.месяц.год):");
            input = Console.ReadLine();
            DateTime dateForButton = DateTime.Now.AddDays(-1);

        }
        while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out data));

        Console.WriteLine($"Завтра: {data}");

        #endregion
    }

}