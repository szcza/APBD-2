using System.Text;

namespace APBD_2;

public class LiquidContainer: Container, IHazardNotifier
{
    private bool isHazardous { get; }

    public LiquidContainer(int currentLoad, int height, int containerWeight, int depth, string serialNumber, int maxLoad, bool isHazardous) : base(currentLoad, height, containerWeight, depth, serialNumber, maxLoad)
    {
        this.isHazardous = isHazardous;
    }
    public void NotifyDanger(string containerNumber)
    {
        Console.WriteLine($"Hazard detected in container {containerNumber}");
    }
    public override void Load(double cargoWeight)
    {
        if (isHazardous)
        {
            if (cargoWeight > maxLoad * 0.5) 
            {
                throw new InvalidOperationException("Cannot load hazardous cargo beyond 50% of container capacity.");
            }
        }
        else
        {
            if (cargoWeight > maxLoad * 0.9)
            {
                throw new InvalidOperationException("Cannot load cargo beyond 90% of container capacity.");
            }
        }

        base.Load(cargoWeight);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Is Hazardous: {isHazardous}");

        return sb.ToString();
    }
    
}