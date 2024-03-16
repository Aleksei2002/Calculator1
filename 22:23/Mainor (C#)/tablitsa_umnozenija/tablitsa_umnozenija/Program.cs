using System;

class Program
{

    static void Main(string[] args)
    {
        for (int row = 0; row < 5; row++)
        {

            for(int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
        //Random random = new Random();
        //var score = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    int a = random.Next(1, 10); //числа от 1 до 10
        //    int b = random.Next(1, 10); //числа от 1 до 10
        //    {
        //        Console.WriteLine("{0} * {1} = ", a, b);
        //        int answer = int.Parse(Console.ReadLine());
        //        if (answer == a * b)
        //            score++;
        //    }
        //}
        //Console.Write("Mark: ");
        //switch (score)
        //{
        //    case 10:
        //        Console.WriteLine("5");
        //        break;
        //    case 9:
        //    case 8:
        //        Console.WriteLine("4");
        //        break;
        //    case 7:
        //    case 6:
        //        Console.WriteLine("3");
        //        break;
        //    default:
        //        Console.WriteLine("2");
        //        break;
        //}
        //Console.ReadLine();
    }

}