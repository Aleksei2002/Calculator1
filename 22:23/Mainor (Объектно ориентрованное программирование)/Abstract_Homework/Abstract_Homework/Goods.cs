using System;

namespace Abstract_Homework
{
    class Goods 
    {
        static void Main(string[] args)
        {
            // Создание массива из n товаров
            int n = 4;
            Product[] products = new Product[n];
            products[0] = new Product("Cheese", 4.99, new DateTime(2023, 3, 29), new DateTime(2023, 4, 6));
            products[1] = new Product("Milk", 1.49, new DateTime(2023, 3, 30), new DateTime(2023, 4, 10));
            products[2] = new Product("Egg", 1.99, new DateTime(2023, 3, 20), new DateTime(2023, 3, 25));
            products[3] = new Product("Meal", 5.50, new DateTime(2023, 3, 1), new DateTime(2023, 4, 1));

            Batch batch = new Batch("Bread", 1.49, 20, new DateTime(2023, 3, 20), new DateTime(2023, 3, 26));

            // Вывод информации о товарах
            Console.WriteLine("Products:");
            foreach (Product product in products)
            {
                product.GetInfo();
            }

            Console.WriteLine("\nBatch:");
            batch.GetInfo();
            // Поиск просроченных товаров
            Console.WriteLine("\nExpired products:");
            foreach (Product product in products)
            {
                if (!product.CheckDate())
                {
                    Console.WriteLine(product.Name);
                }
            }

            if (!batch.CheckDate())
            {
                Console.WriteLine(batch.Name);
            }

            Console.ReadLine();
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Goods(string name, double price, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }

        public void GetInfo()
        {
            Console.WriteLine("Product Name: {0}", Name);
            Console.WriteLine("Price: {0}€", Price);
            Console.WriteLine("Production Date: {0:dd/MM/yyyy}", ProductionDate);
            Console.WriteLine("Expiry Date: {0:dd/MM/yyyy}", ExpiryDate);
        }

        public bool CheckDate()
        {
            DateTime currentDate = DateTime.Now;

            return currentDate <= ExpiryDate;
        }
    }
}