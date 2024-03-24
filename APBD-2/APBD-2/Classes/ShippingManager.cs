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

    public CoolingContainer CreateCoolingContainer(double currentLoad, int height, int containerWeight, int depth, int maxLoad, double containerTemperature)
    {
        List<Product> products = new List<Product>();
        string serialNumber = "KON-C" + uniqueID++;
        return new CoolingContainer(currentLoad, height, containerWeight, depth, serialNumber, maxLoad, products,
            containerTemperature);
    }

    public void LoadCoolingContainer(List<Product> products)
    {
        ShippingManager.CreateCoolingContainer().products=
    }
    public void LoadContainers(List<Container> containers)
    {
        for (int i = 0; i < containers.Count; i++)
        {
            
        }
    }

    public void UnloadContainer(string serialNumber)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SeriesNumber.Equals(serialNumber))
            {
                Containers.Remove(Containers[i]);
            }
        }
    }

    public void ReplaceContainer(string containerNumber, Container newContainer)
    {
        // Implementacja zastępowania kontenera na statku
    }

    public void SwitchContainersBetweenShips()
    {
        Containers.Remove(container);
        contaierShip.AddContainer(container);
    }
    public void DisplayContainerInfo()
    {
        Container.
    }
    public void DisplayShipInfo()
    {
        // Wypisanie informacji o statku i jego ładunku
    }
    
}