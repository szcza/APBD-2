namespace APBD_2;

public class Container
{
    private int currentLoad { get; set; }
    private int height { get; }
    private int containerWeight { get; }
    private int depth { get; }
    private string serialNumber { get; }
    private int maxLoad { get; }

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
    }

    public void Unload()
    {
        currentLoad = 0;
    }
    
}