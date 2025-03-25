namespace Program1;

public class Ship
{
    public string Name { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    public double Speed { get; }
    private List<Container> containers = new List<Container>();

    public Ship(string name, int maxContainers, double maxWeight, double speed)
    {
        Name = name;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Speed = speed;
    }

    public void LoadContainer(Container container)
    {
        if (containers.Count >= MaxContainers || GetTotalWeight() + container.OwnWeight + container.LoadWeight > MaxWeight)
            throw new InvalidOperationException("Statek nie może przyjąć więcej kontenerów.");

        containers.Add(container);
    }

    public void UnloadContainer(string serialNumber)
    {
        containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    public double GetTotalWeight()
    {
        double total = 0;
        foreach (var container in containers)
            total += container.OwnWeight + container.LoadWeight;
        return total;
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"{Name} - Maks. kontenery: {MaxContainers}, Maks. waga: {MaxWeight}kg, Prędkość: {Speed} węzłów");
        foreach (var c in containers)
            Console.WriteLine($"{c}");
    }
}
