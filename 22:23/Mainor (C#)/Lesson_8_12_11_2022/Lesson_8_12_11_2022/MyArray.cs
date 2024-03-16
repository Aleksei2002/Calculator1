using System;
namespace Lesson_8_12_11_2022
{
    class MyArray
    {
        public static void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0,4}", data[i]);
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] data, int N)
        {
            for (int i = 0; i<data.Length; i++)
            {
                Console.Write("{0,4}", data[i]);
                if((i+1)%N == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public static void PrintArray(double[] data) 
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0,4}", data[i]);
            }
            Console.WriteLine();
        }
        public static void PrintArray(float[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0,4}", data[i]);
            }
            Console.WriteLine();
        }
    }
}