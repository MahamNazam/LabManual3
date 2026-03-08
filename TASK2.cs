using System;
class Product
{
    public string Name;
    public double Price;
    public int Stock;
    public double TaxRate;
    public Product(string n, double p, int s, double t)
    {
        Name = n;
        Price = p;
        Stock = s;
        TaxRate = t;
    }
}
class Program
{
    static void Main()
    {
        Product[] p = new Product[5];
        p[0] = new Product("Milk", 200, 5, 0.05);
        p[1] = new Product("Bread", 150, 8, 0.05);
        p[2] = new Product("Laptop", 120000, 3, 0.10);
        p[3] = new Product("Mouse", 1500, 20, 0.08);
        p[4] = new Product("Keyboard", 2500, 0, 0.08);
        double totalTax = 0;
        double maxPrice = 0;
        string expensive = "";
       Console.WriteLine("--- STORE SYSTEM STARTED ---");
        for (int i = 0; i < 5; i++)
        {
            if (p[i].Stock > 0)
            {
                totalTax = totalTax + (p[i].Price * p[i].TaxRate);
            }
            if (p[i].Price > maxPrice)
            {
                maxPrice = p[i].Price;
                expensive = p[i].Name;
            }
        }
        Console.WriteLine("Total Store Tax: " + totalTax);
        Console.WriteLine("Low Stock Products:");
        for (int i = 0; i < 5; i++)
        {
            if (p[i].Stock < 10 && p[i].Stock > 0)
            {
                Console.WriteLine(p[i].Name + " (Stock: " + p[i].Stock + ")");
            }
        }
        Console.WriteLine("Most Expensive Product:");
        Console.WriteLine(expensive + " -> Price: " + maxPrice);
        Console.WriteLine("--- STORE REPORT GENERATED ---");
    }
}
