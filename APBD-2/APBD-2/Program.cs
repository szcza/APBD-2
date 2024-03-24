// See https://aka.ms/new-console-template for more information

using APBD_2;

public class Program
{
    public static void Main(string[] args)
    {
        Container container = new Container(122, 30, 20, 40, "KON-C-1", 200);
        container.Load(130);
    //    container.ToString();
    Console.WriteLine(container);
    }
}
