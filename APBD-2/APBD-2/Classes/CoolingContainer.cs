namespace APBD_2;

public class CoolingContainer:Container
{
    public List<Product> products { get; }
    public double containerTemperature { get; }

    public CoolingContainer(double currentLoad, int height, int containerWeight, int depth, string serialNumber, int maxLoad, List<Product> products, double containerTemperature) : base(currentLoad, height, containerWeight, depth, serialNumber, maxLoad)
    {
        this.products = products;
        this.containerTemperature = containerTemperature;
    }

    public override void Load(double cargoWeight)
    {
        if (cargoWeight > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds container capacity.");
        }
        if (currentLoad > 0 && !AreAllProductTypesTheSame(products))
        {
            throw new InvalidOperationException("Cannot load a different product type into the container.");
        }
        if (currentLoad>0&&(containerTemperature<products.First().minTemperature))
        {
            throw new InvalidOperationException("Container temperature is different from the required temperature for the product.");
        }

        base.Load(cargoWeight);
    }

    public bool AreAllProductTypesTheSame(List<Product> products)
    {
        SortedSet<string> productSet=new SortedSet<string>();
        foreach (var product in products)
        {
            productSet.Add(product.productType);
        }

        return productSet.Count == 1;
    }
    
}