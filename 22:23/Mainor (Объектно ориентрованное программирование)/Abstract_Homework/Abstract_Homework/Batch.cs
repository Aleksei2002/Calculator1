using Abstract_Homework;

class Batch : Goods
{
    public int Quantity { get; set; }

    public Batch(string name, double price, int quantity, DateTime productionDate, DateTime expiryDate) : base(name, price, productionDate, expiryDate)
    {
        Quantity = quantity;
    }

    public void GetInfo()
    {
        base.GetInfo(); 
        Console.WriteLine("Quantity: {0}", Quantity);
    }
}