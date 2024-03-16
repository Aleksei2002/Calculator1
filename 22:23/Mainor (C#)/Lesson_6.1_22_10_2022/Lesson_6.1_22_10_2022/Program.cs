using System;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConsole.StartCyrillic();

            //Чтение строки символов с клавиатуры
            string str;
            Console.Write("Введите Ваше имя:");
            str = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}!", str);

            //Ввод данных с клавиатуры
            //Ввод целого числа

            int N = 0;
            //string stroka;
            //bool flag;  //!!!
            //do
            //{        //!!!    
            //    flag = true; //!!!
            //    Console.Write("Input int value:");
            //    stroka = Console.ReadLine();
            //    try
            //    {
            //        N = Int32.Parse(stroka);
            //        //   N = Convert.ToInt32(stroka); 
            //    }
            //    catch (Exception exc)
            //    {
            //        Console.WriteLine(exc.Message);
            //        flag = false;  ///!!!
            //    }
            //} while (flag != true);  //!!!

            //Вызываем метод ReadInt() из созданного нами класса
            N = ConsoleInput.ReadInt();
            Console.WriteLine("N = {0}", N);

            int K;
            //повторное обращение к методу ReadInt();
            K = ConsoleInput.ReadInt();

            Console.WriteLine("K = {0}", K);


            //MyConsole.Pause();
            MyConsole.Pause("RUS");
        }
    }
}
