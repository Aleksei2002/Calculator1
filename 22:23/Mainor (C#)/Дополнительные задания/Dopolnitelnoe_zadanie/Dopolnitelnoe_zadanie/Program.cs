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

        int temp;
        int[] lotto = new int[20];

        Random ran = new Random();

        int i = 0;
        while (i < 20)
        {
            temp = ran.Next(1, 59);

            bool alreadyExist = false;
            foreach (int item in lotto)
            {
                if (item == temp)
                {
                    alreadyExist = true;
                    break;
                }
            }
            if (alreadyExist)
                continue;

            lotto[i] = temp;
            i++;

        }
            Console.WriteLine($"Победители под номером: ");

            //Отсортировать числа по порялку
            Array.Sort(lotto);
            for(int j = 1; j < 20; j++)
            {
                Console.Write(lotto[j] + " ");
            }
            Console.ReadKey();

        Console.WriteLine("\nPress any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмёт любую клавишу
        Console.ReadKey();
    }
}