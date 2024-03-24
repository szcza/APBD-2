using System.Text;

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

    public void LoadCoolingContainer(CoolingContainer container,List<Product> products)
    {
        container.products = products;
    }
    public void LoadContainers(Ship ship,List<Container> containers)
    {
        for (int i = 0; i < containers.Count; i++)
        {
            ship.Containers.Add(containers[i]);
        }
    }

    public void UnloadContainer(Ship ship,string serialNumber)
    {
        for (int i = 0; i < ship.Containers.Count; i++)
        {
            if (ship.Containers[i].serialNumber.Equals(serialNumber))
            {
                ship.Containers.RemoveAt(i);
            }
        }
    }

    public void ReplaceContainer(Ship ship,string serialNumber, Container newContainer)
    {
        for (int i = 0; i < ship.Containers.Count; i++)
        {
            if (ship.Containers[i].serialNumber.Equals(serialNumber))
            {
                ship.Containers.RemoveAt(i);
                ship.Containers.Insert(i,newContainer);
            }
        }
    }

    public void SwitchContainersBetweenShips(Ship FromShip, Container container, Ship ToShip)
    {
        FromShip.Containers.Remove(container);
        ToShip.Containers.Add(container);
    }
    
}