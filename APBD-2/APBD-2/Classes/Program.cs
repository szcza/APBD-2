// See https://aka.ms/new-console-template for more information

using System.Xml;
using APBD_2;

public class Program
{
    static void Main(string[] args)
{
    // Tworzenie menedżera wysyłek
    ShippingManager shippingManager = new ShippingManager();

    // Tworzenie kontenerów
    LiquidContainer liquidContainer1 = shippingManager.CreateLiquidContainer(100, 10, 20, 5, 200, true);
    LiquidContainer liquidContainer2 = shippingManager.CreateLiquidContainer(150, 12, 25, 6, 250, true);
    GasContainer gasContainer1 = shippingManager.CreateGasContainer(50.5, 8, 15, 4, 100, 10);
    GasContainer gasContainer2 = shippingManager.CreateGasContainer(60.5, 9, 16, 5, 120, 12);
    CoolingContainer coolingContainer1 = shippingManager.CreateCoolingContainer(80.3, 12, 25, 6, 150, 5.0);
    CoolingContainer coolingContainer2 = shippingManager.CreateCoolingContainer(90.5, 14, 28, 7, 180, 6.0);

    // Załadowanie produktów do kontenera chłodzącego
    List<Product> products1 = new List<Product>()
    {
        new Product("Apple", 0.5),
        new Product("Orange", 0.3),
        new Product("Banana", 0.4)
    };
    shippingManager.LoadCoolingContainer(coolingContainer1, products1);

    List<Product> products2 = new List<Product>()
    {
        new Product("Milk", 1.0),
        new Product("Cheese", 0.8),
        new Product("Yogurt", 0.6)
    };
    shippingManager.LoadCoolingContainer(coolingContainer2, products2);

    // Tworzenie statków
    Ship ship1 = new Ship(new List<Container>(), 20.5, 10, 500.0);
    Ship ship2 = new Ship(new List<Container>(), 18.0, 8, 400.0);

    // Załadowanie kontenerów na statki
    List<Container> containersShip1 = new List<Container>()
    {
        liquidContainer1,
        gasContainer1,
        coolingContainer1
    };
    shippingManager.LoadContainers(ship1, containersShip1);

    List<Container> containersShip2 = new List<Container>()
    {
        liquidContainer2,
        gasContainer2,
        coolingContainer2
    };
    shippingManager.LoadContainers(ship2, containersShip2);

    // Wypisanie informacji o statkach i ich ładunku
    Console.WriteLine("Informacje o statku 1:");
    Console.WriteLine(ship1.ToString());

    Console.WriteLine("\nInformacje o statku 2:");
    Console.WriteLine(ship2.ToString());

    // Usunięcie kontenera ze statku
    shippingManager.UnloadContainer(ship1, liquidContainer1.serialNumber);
    Console.WriteLine("Usunięcie kontenera ze statku");
    Console.WriteLine(ship1.ToString());

    // Zastąpienie kontenera na statku
    LiquidContainer newLiquidContainer = shippingManager.CreateLiquidContainer(120, 15, 30, 7, 300, false);
    shippingManager.ReplaceContainer(ship1, gasContainer1.serialNumber, newLiquidContainer);

    // Przeniesienie kontenera między statkami
    shippingManager.SwitchContainersBetweenShips(ship1, coolingContainer1, ship2);

    // Wypisanie informacji o statkach i ich ładunku po wykonaniu akcji
    Console.WriteLine("\nInformacje o statku 1 po wykonaniu akcji:");
    Console.WriteLine(ship1.ToString());

    Console.WriteLine("\nInformacje o statku 2 po wykonaniu akcji:");
    Console.WriteLine(ship2.ToString());
}

}
