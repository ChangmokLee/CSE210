public class VendingMachine
{
    private List<Item> items = new List<Item>();

    public VendingMachine()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("\nI'm a vending machine\n");
        Console.WriteLine("--------------------------");
    }

    public void Populate()
    {
        items.Add(new Item("Cool Ranch Doritos", 2.5, "A1"));
        items.Add(new Item("Reeses", 5.5, "A2"));
        items.Add(new Item("Coke", 7.8, "A3"));

    }

    public void getList()
    {
        Console.WriteLine("Items in the vending machine: ");
        Console.WriteLine("--------------------------");
        foreach (Item item in items)
        {
            item.showItem();
        }
    }
}