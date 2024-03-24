// See https://aka.ms/new-console-template for more information

using APBD_2;

public class Program
{
    public static void Main(string[] args)
    {
        ShippingManager shippingManager = new ShippingManager();

            // Tworzenie kontenerów
            LiquidContainer liquidContainer = shippingManager.CreateLiquidContainer(100, 10, 20, 5, 200, true);
            GasContainer gasContainer = shippingManager.CreateGasContainer(50.5, 8, 15, 4, 100, 10);
            CoolingContainer coolingContainer = shippingManager.CreateCoolingContainer(80.3, 12, 25, 6, 150, 5.0);

            // Załadowanie produktów do kontenera chłodzącego
            List<Product> products = new List<Product>()
            {
                new Product("Apple", 0.5),
                new Product("Orange", 0.3),
                new Product("Banana", 0.4)
            };
            shippingManager.LoadCoolingContainer(coolingContainer, products);

            // Tworzenie statków
            Ship ship1 = new Ship("Ship1");
            Ship ship2 = new Ship("Ship2");

            // Załadowanie kontenerów na statki
            List<Container> containers = new List<Container>()
            {
                liquidContainer,
                gasContainer,
                coolingContainer
            };
            shippingManager.LoadContainers(ship1, containers);

            // Wypisanie informacji o statkach i ich ładunku
            Console.WriteLine("Informacje o statku 1:");
            Console.WriteLine(ship1.ToString());

            Console.WriteLine("\nInformacje o statku 2:");
            Console.WriteLine(ship2.ToString());

            // Usunięcie kontenera ze statku
            shippingManager.UnloadContainer(ship1, liquidContainer.serialNumber);

            // Zastąpienie kontenera na statku
            LiquidContainer newLiquidContainer = shippingManager.CreateLiquidContainer(150, 12, 22, 6, 250, false);
            shippingManager.ReplaceContainer(ship1, gasContainer.serialNumber, newLiquidContainer);

            // Przeniesienie kontenera między statkami
            shippingManager.SwitchContainersBetweenShips(ship1, coolingContainer, ship2);

            // Wypisanie informacji o statkach i ich ładunku po wykonaniu akcji
            Console.WriteLine("\nInformacje o statku 1 po wykonaniu akcji:");
            Console.WriteLine(ship1.ToString());

            Console.WriteLine("\nInformacje o statku 2 po wykonaniu akcji:");
            Console.WriteLine(ship2.ToString());
    }
}
