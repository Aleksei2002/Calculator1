using System;

namespace Test {
    class Program {
        static int F(int a)
        {
            return a % 10;
        }

        static int F(int a, int b)
        {
            return (a + b) % 10;
        }

        static void Main()
        {
            int a = 17, b = 21;

            Console.WriteLine(F(a, b));

            Console.ReadKey();
        }
    }
}