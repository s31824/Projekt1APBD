// See https://aka.ms/new-console-template for more information

using Program1;

class Program
{
    static void Main()
    {
        Ship ship = new Ship("Czarna Perła", 5, 100000, 30);

        LiquidContainer liquid = new LiquidContainer(1000, 5000, 10, 10, true);
        GasContainer gas = new GasContainer(800, 4000, 8, 8);
        RefrigeratedContainer fridge = new RefrigeratedContainer(1200, 6000, 12, 12, -18);

        liquid.Load(2000);
        gas.Load(3000);
        fridge.Load(4000);

        ship.LoadContainer(liquid);
        ship.LoadContainer(gas);
        ship.LoadContainer(fridge);
        ship.PrintShipInfo();
        
        gas.Unload();
        Console.WriteLine();
        ship.PrintShipInfo();
        
        
        ship.UnloadContainer(gas.SerialNumber);
        Console.WriteLine();
        ship.PrintShipInfo();
    }
}



