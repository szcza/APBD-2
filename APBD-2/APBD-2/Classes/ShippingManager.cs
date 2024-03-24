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

    public GasContainer GasContainerCreator(double currentLoad, int height, int containerWeight, int depth, int maxLoad, int pressure)
    {
        string serialNumber=
    }

    public CoolingContainer CoolingContainerCreator(double currentLoad, int height, int containerWeight, int depth, int maxLoad, List<Product> products, double containerTemperature)
    {
        string serialNumber=
    }
    
    
}