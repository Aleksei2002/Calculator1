using System;

namespace Exam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            // Добавить товар для склада
            warehouse.AddProduct(new Product("Milk", "Coop", 2));
            warehouse.AddProduct(new Product("Bread", "Maxima", 1));
            warehouse.AddProduct(new Product("Eggs", "Rimi", 2.5));
            warehouse.AddProduct(new Product("Cheese", "coop", 3));

            // Отсортировать товары по именам
            warehouse.SortProduct();

            // Вывести инфо всех товаров
            Console.WriteLine("All products:");
            warehouse.PrintAllProducts();
            Console.WriteLine();

            // Вывести инфо конкретных товаров
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine().ToLower();
            warehouse.PrintProductInfo(productName);

            Console.WriteLine("Press any key to continue...");
            // pause - задержка экрана - пока пользователь не нажмет любую клавишу
            Console.ReadKey();
        }
    }
}