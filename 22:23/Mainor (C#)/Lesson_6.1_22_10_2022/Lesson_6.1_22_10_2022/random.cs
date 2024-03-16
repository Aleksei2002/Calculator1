using System;
namespace Lesson_6._1_22_10_2022
{
    public class random
    {
        public random()
        {
            Random obj = new Random();

            int a, b;
            int answer;
            int count = 0;

            for (int i = 1; i <= 10; i++)
            {
                a = obj.Next(1, 11);
                b = obj.Next(1, 11);
                Console.WriteLine("{0,2}. {1,2} * {2,2} = ", i, a, b);
                //answer = ConsoleInput.ReadInt();
            }
        }
    }
}

