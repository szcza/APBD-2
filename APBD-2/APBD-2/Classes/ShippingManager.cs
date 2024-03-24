namespace APBD_2;

public class ShippingManager
{
    private int uniqueID = 1;
    public LiquidContainer CreateLiquidContainer(int currentLoad, int height, int containerWeight, int depth, int maxLoad, bool isHazardous)
    {
        string serialNumber = "KON-L" + uniqueID++;
        return new LiquidContainer(currentLoad, height, containerWeight, depth, serialNumber, maxLoad,
            isHazardous);
    }

    public GasContainer CreateGasContainer(double currentLoad, int height, int containerWeight, int depth, int maxLoad, int pressure)
    {
        string serialNumber = "KON-G" + uniqueID++;
        return new GasContainer(currentLoad, height, containerWeight, depth, serialNumber, maxLoad,
            pressure);
    }

    public CoolingContainer CreateCoolingContainer(double currentLoad, int height, int containerWeight, int depth, int maxLoad, List<Product> products, double containerTemperature)
    {
        string serialNumber = "KON-C" + uniqueID++;
        return new CoolingContainer(currentLoad, height, containerWeight, depth, serialNumber, maxLoad, products,
            containerTemperature);
    }
    
    
}