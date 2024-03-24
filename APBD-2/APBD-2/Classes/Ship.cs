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
}