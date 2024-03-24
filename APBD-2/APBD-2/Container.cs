namespace APBD_2;

public class Container
{
    public int currentLoad { get; set; }
    public int height { get; }
    public int containerWeight { get; }
    public int depth { get; }
    public string serialNumber { get; }
    public int maxLoad { get; }

    public Container(int currentLoad, int height, int containerWeight, int depth, string serialNumber, int maxLoad)
    {
        this.currentLoad = currentLoad;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.serialNumber = serialNumber;
        this.maxLoad = maxLoad;
    }

    public void Load(int cargoLoad)
    {
        if (cargoLoad > maxLoad)
        {
            throw new OverfillException("Cargo weight larger than container capacity");
        }
        else
        {
             currentLoad=cargoLoad;
        }
    }

    public void Unload()
    {
        currentLoad = 0;
    }
    public override string ToString()
    {
        return $"Container: {serialNumber}, Max Load: {maxLoad} kg, Current Load: {currentLoad} kg";
    }
    
}