using System;

class Program
{   
    public abstract class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime ProductDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string Name, string Price, DateTime ProductDate, DateTime ExpiryDate)
        {
            this.Name = Name;
            this.Price = Price;
            this.ProductDate = ProductDate;
            this.ExpiryDate = ExpiryDate;
        }

        public void GetInfo()
        {
            //Конструктор, который принимает 4 аргумента
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Price: {0}€", Price);
            Console.WriteLine("ProductDate: {0:d}", ProductDate);
            Console.WriteLine("ExpiryDate: {0:d}", ExpiryDate);
        }

        public bool CheckDate()
        {
            // Проверка является ли свойство больше или равно текущей дате
            DateTime currentDate = DateTime.Now;

            return currentDate <= ExpiryDate;
        }
    }
}