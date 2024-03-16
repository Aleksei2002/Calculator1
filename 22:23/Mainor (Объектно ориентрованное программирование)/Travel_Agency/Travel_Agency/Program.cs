using System;

namespace Travel_Agency {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Tour t1 = new Tour("Suusareis", 75, 40, 15);

            Tour t2 = new Tour("Saaremaareis", 10, 35, 30);

            Tour t3 = new Tour("Tallinnaekskursioon", 2, 5, 10);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("Type: {0} MaxNumberPeople: {1} PriceForGroup(10): {2} PriceForGroup(40) : {3}", t2.Type, t2.MaxNumberPeople, t2.PriceForGroup(10), t2.PriceForGroup(40));

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.ReadKey();
        }
    }
}