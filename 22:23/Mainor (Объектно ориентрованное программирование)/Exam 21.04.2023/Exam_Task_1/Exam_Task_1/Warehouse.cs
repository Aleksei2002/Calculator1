using System;
using System.Collections.Generic;

namespace Exam_Task_1
{
    class Warehouse
    {
        private List<Product> products;

        public Warehouse()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void SortProduct()
        {
            products.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
        }

        public void PrintProductInfo(string productName)
        {
            bool foundProduct = false;
            foreach (Product product in products)
            {
                if (product.ProductName == productName.ToLower())
                {
                    Console.WriteLine(product.ToString());
                    foundProduct = true;
                }
            }
            if (!foundProduct)
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void PrintAllProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}