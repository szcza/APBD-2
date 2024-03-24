namespace APBD_2;

public class Product
{
    public string name { get; }
    public double minTemperature { get; }
    public string productType { get; }

    public Product(string name, double minTemperature)
    {
        this.name = name;
        this.minTemperature = minTemperature;
    }
}