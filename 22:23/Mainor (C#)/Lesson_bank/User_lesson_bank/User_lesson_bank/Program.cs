using System;

class Program
{

    static void Main(string[] args)
    {

        // Написать программу вычисления величины дохода по вкладу.
        // Процентная ставка(в процентах годовых)
        // и время хранения(в днях) задаются во время работы программы.

        // Величина вклада: 2500
        // Срок вклада(дней): 30
        // Процентная ставка(годовых): 2
        // Доход: 4.11 euro
        // Сумма по окончании срока вклада: 2504.11 euro

        // Сумма вклада, срок вклада, процентная ставка, доход по вкладу

        double summa, stavka, doxod;
        int srok;

        summa = 2500;
        srok = 30;
        stavka = 2;

        // вычисление дохода по вкладу:
        // 365 - кол-во дней в году
        doxod = (summa * stavka / 100) / 365 * srok;
        summa = summa + doxod;

        Console.WriteLine("doxod: {0}", doxod);

        Console.WriteLine("Сумма по окончанию срока вклада: {0}", summa);

        Console.WriteLine("doxod: {0:f2}", doxod);
        Console.WriteLine("Сумма по окончанию срока вклада: {0:f2}", summa);

        summa = Math.Round(summa, 2);
        doxod = Math.Round(doxod, 2);

        Console.WriteLine("doxod: {0}", doxod);

        Console.WriteLine("Сумма по окончанию срока вклада: {0}", summa);

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}