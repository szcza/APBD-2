using System.Text;

namespace APBD_2;

public class Ship
{
    public List<Container> Containers;
    public double speed;
    public int maxContainers;
    public double maxWeight;

    public Ship(List<Container> containers, double speed, int maxContainers, double maxWeight)
    {
        Containers = containers;
        this.speed = speed;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Speed: {speed} knots");
        sb.AppendLine($"Max Containers: {maxContainers}");
        sb.AppendLine($"Max Weight: {maxWeight} tons");
        sb.AppendLine("Containers:");
    
        foreach (var container in Containers)
        {
            sb.AppendLine(container.ToString());
        }
        return sb.ToString();
    }
}