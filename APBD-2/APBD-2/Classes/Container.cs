namespace APBD_2;

public class Container
{
    public double currentLoad { get; set; }
    public int height { get; }
    public int containerWeight { get; }
    public int depth { get; }
    public string serialNumber { get; }
    public int maxLoad { get; }

    public Container(double currentLoad, int height, int containerWeight, int depth, string serialNumber, int maxLoad)
    {
        this.currentLoad = currentLoad;
        this.height = height;
        this.containerWeight = containerWeight;
        this.depth = depth;
        this.serialNumber = serialNumber;
        this.maxLoad = maxLoad;
    }

    public virtual void Load(double cargoLoad)
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

    public virtual void Unload()
    {
        currentLoad = 0;
    }
    public override string ToString()
    {
        return $"Container: {serialNumber}, Max Load: {maxLoad} kg, Current Load: {currentLoad} kg";
    }
    
    
}