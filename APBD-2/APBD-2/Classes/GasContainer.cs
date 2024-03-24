using System.Text;

namespace APBD_2;

public class GasContainer : Container, IHazardNotifier
{
    public int pressure { get; }

    // Constructor
    public GasContainer(double currentLoad, int height, int containerWeight, int depth, string serialNumber, int maxLoad, int pressure) : base(currentLoad, height, containerWeight, depth, serialNumber, maxLoad)
    {
        this.pressure = pressure;
    }

    public void NotifyDanger(string containerNumber)
    {
        Console.WriteLine($"Hazard detected in container {containerNumber}");
    }
    
    public override void Unload()
    {
        base.Unload();
        currentLoad *= 0.05; // Leave 5% of the load
    }
    
    public override void Load(double cargoWeight)
    {
        if (cargoWeight > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds gas container capacity.");
        }

        base.Load(cargoWeight);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Container Temperature: {pressure}");
        return sb.ToString();
    }
}