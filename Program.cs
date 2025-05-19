using System;

public interface IPrice
{
    double GetPrice();
}

public class Car : IPrice
{
    public double Price { get; set; }
    public string Name { get; set; }

    public Car(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }

    public string GetName()
    {
        return Name;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", 30000);
        Console.WriteLine($"車名: {myCar.GetName()}");
        Console.WriteLine($"價格: {myCar.GetPrice()}");
    }
}
