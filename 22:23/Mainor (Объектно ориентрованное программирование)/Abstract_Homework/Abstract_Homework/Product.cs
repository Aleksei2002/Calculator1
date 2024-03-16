using System;

namespace Abstract_Homework
{
    class Product : Goods
    {
        public Product(string name, double price, DateTime productionDate, DateTime expiryDate) : base(name, price, productionDate, expiryDate)
        {
        }
    }
}