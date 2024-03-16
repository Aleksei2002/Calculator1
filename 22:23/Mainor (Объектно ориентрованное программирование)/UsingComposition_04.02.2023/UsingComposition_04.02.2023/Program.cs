using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee( //создание класса Employee
            "Bob", "Jones", 24, 12, 1990, 1, 9, 2013); // Указываем данные Employee
            Console.WriteLine(e); // Ввыводим данные в консоль

            Console.ReadKey();
        }
    }
}
