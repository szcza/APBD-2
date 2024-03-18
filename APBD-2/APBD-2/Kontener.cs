namespace APBD_2;

public class Kontener
{
    private int mass;
    private int height;
    //properties getter i setter - autoproperty
    public string Depth { get; set; }
    //Full property
    private double _weight;

    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Weight cannot be less than zero");
            }
            _weight = value;
        }
    }
    
    
}