VendingMachine v = new VendingMachine();
v.Populate();
v.getList();

public class Item
{
    private string name;
    private double price;
    private string location;
    private int quantity;

    public Item(string name, double price, string location, int quantity = 1)
    {
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;
    }

    private double totalValue()
    {
        return quantity * price;
    }

    public void showItem()
    {
        Console.WriteLine($"{name} - {price} - {location} QTY:{quantity}");
        Console.WriteLine($"TOTAL VALUE: {totalValue()}");
        Console.WriteLine("--------------------------");
    }
}
