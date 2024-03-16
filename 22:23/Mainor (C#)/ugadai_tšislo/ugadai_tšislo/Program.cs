using System;

    class Program
    {

        static void Main(string[] args)
        {
            int ugodat = 0;
            int i = 0;
            Random random = new Random(1);
            int number = random.Next(1, 100);
            string message = "Угадайте число от 1 до 1000:";
            Console.WriteLine(message);

            while(ugodat != number)
            {
                try
                {
                    ugodat = Convert.ToInt32(Console.ReadLine());

                    if (ugodat > number)
                    {
                        Console.WriteLine("Слишком большое число");
                    }
                    else
                    {
                        Console.WriteLine("Слишком маленькое число");
                    }
                }
                catch
                {
                    Console.WriteLine("Guess must be a number");
                    i--;
                }

                i++;
            }

            Console.WriteLine("Congrats, it took you " + i + " tries");
            Console.ReadLine();
        }
    }
