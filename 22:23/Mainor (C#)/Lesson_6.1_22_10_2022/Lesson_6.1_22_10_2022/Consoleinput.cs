using System;

namespace MyLibrary
{
    class ConsoleInput
    {
        //метод для чтения/ввода значений целого типа int
        //с клавиатуры

        public static int ReadInt()
        {
            int N = 0;

            string stroka;
            bool flag;  //!!!
            do
            {        //!!!    
                flag = true; //!!!
                Console.Write("Input int value:");
                stroka = Console.ReadLine();
                try
                {
                    N = Int32.Parse(stroka);
                    //   N = Convert.ToInt32(stroka); 
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    flag = false;  ///!!!
                }
            } while (flag != true);  //!!!

            return N;
        }

    }
}
