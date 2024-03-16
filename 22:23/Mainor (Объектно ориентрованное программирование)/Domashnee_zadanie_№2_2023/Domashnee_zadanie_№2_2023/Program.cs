using System;
using System.Text;

namespace Task_class_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            Card card1 = new Card();

            Card card2 = new Card("Herbert Schildt", "C#", 5);

            card1.Info();
            card2.Info();

            Card card3 = new Card("Лев Толстой", "Война и мир", 10);
            card3.Info();

            Console.WriteLine("\n");

            Console.WriteLine(card1); //ToString()
            Console.WriteLine(card2); //ToString()
            Console.WriteLine(card3); //ToString()

            int n = 52;
            Console.WriteLine(n); //ToString() 52

            Console.WriteLine(card3.Title); //get
            //******************************************
            Console.WriteLine("\n\n");
            //******************************************

            Card[] arrayCard =
            {
                new Card(),
                new Card("Лев Толстой", "Война и мир", 10),
                new Card("Herbert Schildt", "C#", 5),
                new Card("Herbert Schildt", "Java", 25),
                new Card("Эндрю Троелсен", "C# 7.0", 15),
                new Card("Юрий Лермонтов", "Бородино", 3),
        };
            Console.WriteLine("Length = {0}", arrayCard.Length);

            foreach(Card card in arrayCard)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();

            Array.Sort(arrayCard);

            foreach (Card card in arrayCard)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
