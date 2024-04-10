using System;
public class Flower
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int FreshnessLevel { get; set; }
    public double StemLength { get; set; }

    public Flower(string name, double price, int freshnessLevel, double stemLength)
    {
        Name = name;
        Price = price;
        FreshnessLevel = freshnessLevel;
        StemLength = stemLength;
    }

    public override string ToString()
    {
        return $"Квiтка: {Name}, Цiна: {Price}$, Левл свiжостi: {FreshnessLevel}, Довжина стебла: {StemLength}см";
    }
}
public class Wrapper
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Wrapper(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Обгортка: {Name}, Цiна: {Price}$";
    }
}
public class Bouquet
{
    private List<Flower> flowers;
    public Wrapper Wrapper { get; set; }

    public Bouquet()
    {
        flowers = new List<Flower>();
    }

    public void AddFlower(Flower flower)
    {
        flowers.Add(flower);
    }

    public double CalculateTotalCost()
    {
        double totalCost = flowers.Sum(flower => flower.Price);
        if (Wrapper != null)
        {
            totalCost += Wrapper.Price;
        }
        return totalCost;
    }
    public void DisplayFlowers()
    {
        Console.WriteLine("Квiти в букетi:");
        foreach (Flower flower in flowers)
        {
            Console.WriteLine(flower);
        }
        if (Wrapper != null)
        {
            Console.WriteLine(Wrapper);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Flower rose = new Flower("Rose", 2.5, 5, 10);
        Flower Cornflower = new Flower("Cornflower", 3.0, 4, 12);
        Flower tulip = new Flower("Tulip", 1.8, 6, 8);
        Wrapper wrapper = new Wrapper("Прозора плiвка", 0.5);

        Bouquet bouquet = new Bouquet();
        bouquet.AddFlower(rose);
        bouquet.AddFlower(Cornflower);
        bouquet.AddFlower(tulip);
        bouquet.Wrapper = wrapper;

        bouquet.DisplayFlowers();

        double totalCost = bouquet.CalculateTotalCost();
        Console.WriteLine($"Загальна вартiсть букета з обгорткою: ${totalCost}");
    }
}