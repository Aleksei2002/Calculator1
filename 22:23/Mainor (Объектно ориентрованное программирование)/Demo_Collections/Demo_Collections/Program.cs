using System;

using System.Collections; //ArrayList

using System.Collections.Generic;  //List<T>


namespace Demo_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Egor", "Boris", "Anna", "Oleg", "Ivan", "Lena", "Aleksander" };

            //Отобразить кол-во элементов в массиве при помощи свойства Length
            Console.WriteLine("name.Length = {0}", name.Length);  //7

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine();

            // name[8] = "Jana"; error

            ArrayList arr = new ArrayList();
            int size = arr.Count;
            Console.WriteLine("size = {0}", size);  //0

            arr.Add(25); arr.Add(5); arr.Add(15);

            size = arr.Count;
            Console.WriteLine("size = {0}", size); //3
            PrintArrayList(arr);  // 25 5 15

            //arr.Add(2.5);

            arr.Sort();

            PrintArrayList(arr);  // 5 15 25

            arr.Clear();
            size = arr.Count;
            Console.WriteLine("size = {0}", size); //0

            arr.Add(100);
            arr.Add(10);
            arr.Add(1000);
            arr.Add(10);

            size = arr.Count;
            Console.WriteLine("size = {0}", size); //4
            PrintArrayList(arr);  // 100 10  1000 10

            arr.Remove(10); PrintArrayList(arr);  // 100 1000 10

            arr.RemoveAt(1); PrintArrayList(arr);  // 100 10

            arr.Add(500); PrintArrayList(arr);  // 100 10 500

            arr.RemoveRange(0, 2); PrintArrayList(arr);  // 500

            arr.Insert(0, 100); PrintArrayList(arr);  // 100 500

            arr.Insert(0, 1000); PrintArrayList(arr);  //1000 100 500

            arr.Insert(arr.Count, 10); PrintArrayList(arr);  // 1000 100 500 10

            Object[] array = arr.ToArray();

            arr.Add("Sveta"); arr.Add("Lena"); arr.Add(5); arr.Add(5.5);
            PrintArrayList(arr); // 1000 100 500 10 sveta lena 5 5.5

            //arr.Sort();
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(15);
            list.Add(5);
            list.Add(55);

            // list.Add(1.0);
            // list.Add("lena");

            PrintArrayList(list);

            Console.WriteLine("Press any key to continue...");
            //pause - задержка экрана - пока пользователь не нажмет любую клавишу
            Console.ReadKey();
        }

        static void PrintArrayList(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0,5}", arr[i]);    //.ToString()
            }

            Console.WriteLine();
        }
        static void PrintArrayList(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0,5}", arr[i]);    //.ToString()
            }

            Console.WriteLine();
        }

    }
}
