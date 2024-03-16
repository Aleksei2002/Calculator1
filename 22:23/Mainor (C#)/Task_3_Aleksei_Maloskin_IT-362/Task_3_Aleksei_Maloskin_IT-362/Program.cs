using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        int score = 0; // сколько правильных ответов?
        char znak;
        var random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int num1 = random.Next(1, 100); // число от 1 до 100
            int num2 = random.Next(100 - num1); // указываем лимит до 100
            int protsess = random.Next(2);
            int result;
            if (protsess == 0)
            {
                // сложение
                Console.WriteLine("{0} + {1} = ", num1, num2);
                result = num1 + num2;
                znak = '+';
            }
            else
            {
                // вычитание
                if (num1 > num2)
                {
                    Console.WriteLine("{0} - {1} = ", num1, num2);
                    result = num1 - num2;
                    znak = '-';
                }
                else
                {
                    Console.WriteLine("{0} - {1} = ", num2, num1);
                    result = num2 - num1;
                    znak = '-';
                }
            }
            int stroka;
            while (true)
            {
                try
                {
                    stroka = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите цифру"); // если вместо цифры был введена буква
                }
            }
            if (result == stroka)
                score++;
            else
                Console.WriteLine("Error! {0} {1} {2} = {3}", num1, znak, num2, result);

        }
        Console.Write("Correct: {0} ", score);
        Console.Write("Mark: ");
        switch (score)
        {
            case 10:
                Console.WriteLine("5");
                break;
            case 9:
            case 8:
                Console.WriteLine("4");
                break;
            case 7:
            case 6:
                Console.WriteLine("3");
                break;
            default:
                Console.WriteLine("2");
                break;
        }
        Console.ReadKey();
    }
}