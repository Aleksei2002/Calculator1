using System;
namespace Exam_Task_1
{
    public struct Product
    {
        private string productName;
        private string storeName;
        private double price;

        public Product(string productName, string storeName, double price)
        {
            this.productName = productName.ToLower();
            this.storeName = storeName.ToLower();
            this.price = price;
        }

        public string ProductName
        {
            get { return productName; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public double Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            return "Product name: " + productName + ", Store name: " + storeName + ", Price: " + price;
        }
    }
}

