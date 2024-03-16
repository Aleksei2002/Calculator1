using System;
using Lesson_8_12_11_2022;

class Program
{
    static void Main(string[] args)
    {

        // int[] data; // обьявлен массив (declaration)
        // data = new int[10]; // определение массивов (instalation)
        // Второй этап - выделение
        // Rank - размерность массивов

        int[] data = new int[10];

        //for (int i = 0; i < data.Length; i++)
        //{
        //    Console.Write("{0,4}", data[i]);
        //}
        //Console.WriteLine();
        MyArray.PrintArray(data);

        // третий этап - инициализация

        data[0] = 23; data[1] = 38; data[2] = 14;
        data[3] = -3; data[5] = 14; data[6] = 9;
        data[7] = 103; data[9] = -56;

        //for (int i = 0; i < data.Length; i++)
        //{
        //    Console.Write("{0,4}", data[i]);
        //}
        //Console.WriteLine();
        MyArray.PrintArray(data);

        Console.WriteLine("data[2] = {0}", data[2]);

        // сразу проанализировав массивы конкретных значении
        int[] dataNew = { 23, 38, 14, -3, 0, 14, 9, 103, 0, -56 };

        // количество элементов массива
        Console.WriteLine("dataNew.Length = {0}", dataNew.Length);

        // Размерность массива
        Console.WriteLine("dataNew.Length = {0}", dataNew.Rank);

        //for (int i = 0; i < data.Length; i++)
        //{
        //    Console.Write("{0,4}", dataNew[i]);
        //}
        //Console.WriteLine();
        MyArray.PrintArray(dataNew);

        for (int i = 0; i < data.Length; i++)
        {
            dataNew[i] *= -1;
        }

        for (int i = 0; i < data.Length; i++)
        {
            Console.Write("{0,4}", dataNew[i]);
        }
        Console.WriteLine();

        int[] iA = new int[15];
        MyArray.PrintArray(iA);

        Random obj = new Random();
        // Заполним массив случайными значениями из интервала [-15,15]
        for (int i = 0; i < iA.Length; i++)
        {
            iA[i] = obj.Next(-15, 16);
        }
        MyArray.PrintArray(iA);

        // min & max

        int max;
        int min;
        int pos;

        // 1 - способ
        max = iA[0];
        pos = 1;
        for(int i = 1; i < iA.Length; i++)
        {
            if (iA[i] > max)
            {
                max = iA[i];
                pos = i + 1;
            }
        }
        Console.WriteLine("max = {0,3}", max);
        Console.WriteLine("pos = {0,3}", pos);

        min = iA[0];
        pos = 1;
        for (int i = 1; i < iA.Length; i++)
        {
            if (iA[i] < min)
            {
                min = iA[i];
                pos = i + 1;
            }
        }
        Console.WriteLine("max = {0,3}", max);
        Console.WriteLine("pos = {0,3}", pos);

        // 2 способ
        //max = -20;
        max = Int32.MinValue;
        // Console.WriteLine("Int32.MinValue = {0,15}", Int32.MinValue);
        // Console.WriteLine("Int32.MaxValue = {0,15}", Int32.MaxValue);

        pos = 1;
        for (int i = 0; i < iA.Length; i++)
        {
            if (iA[i] < min)
            {
                min = iA[i];
                pos = i + 1;
            }
        }
        Console.WriteLine("max = {0,3}", max);
        Console.WriteLine("pos = {0,3}", pos);

        //Находим сумму и количество положительных элементов массива
        int summaP = 0;
        int countP = 0;
        for (int i = 0; i < iA.Length; i++)
        {
            if (iA[i] > 0)
            {
                countP++;
                summaP += iA[i]; //summaP = summaP + iA[i];

                Console.WriteLine("{0,3}", iA[i]);
            }
        }
        Console.WriteLine("summaP = {0,3}", summaP);
        Console.WriteLine("countP = {0,3}", countP);
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

        int[] array = new int[45];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        MyArray.PrintArray(array);
        Console.WriteLine(); Console.WriteLine();
        MyArray.PrintArray(array, 25);

        //*********************************************************************

        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        foreach (int a in array)
        {
            Console.Write("{0,4}", a);
        }
        Console.WriteLine();

        double[] arrayD = { 3.5, 4.5, 9.9, 10.0, 15.0 };
        double summa = 0;
        foreach (int d in array)
        {
            Console.Write("{0,4}", d);
            summa += d;
        }
        Console.WriteLine();
        Console.WriteLine("summa = {0}", summa);
        MyArray.PrintArray(arrayD);
        Console.WriteLine();

        float[] arrayF = { 1.1f, 2.2f, 3.3f, 5.5f };
        MyArray.PrintArray(arrayF);
        Console.WriteLine();

        // foreach - открывается для чтения при помощи этого оператора, изменить значение элемента массива нельзя

        int[] temperature = { 10, 5, 2, 8, 5, 34, 44 };
        MyArray.PrintArray(temperature);
        int summaT = 0;
        for (int i = 0; i < temperature.Length; i++)
        {
            summaT += temperature[i];
        }
        double avr = (double)summaT / temperature.Length;

        Console.WriteLine("SummaT = {0}", summaT);
        Console.WriteLine("avr = {0:f2}", avr);

        //Сортировать массив
        Array.Sort(temperature);
        MyArray.PrintArray(temperature);

        //Перевернуть массив
        Array.Reverse(temperature);
        MyArray.PrintArray(temperature);

        Array.Clear(temperature, 0, 5);
        MyArray.PrintArray(temperature);

        int k = 5;
        Console.WriteLine("Number {0} is located in {1} place", k, Array.IndexOf(temperature, k));

        Console.WriteLine(temperature[temperature.Length - 1]);

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}