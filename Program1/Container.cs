namespace Program1;

public abstract class Container
{
    private static int counter = 1;
    public string SerialNumber { get; } 
    public double LoadWeight { get; set; }
    public double MaxLoad { get; }
    public double OwnWeight { get; }
    public double Depth { get; }
    public double Height { get; }

    public Container(double ownWeight, double maxLoad, double depth, double height)
    {
        OwnWeight = ownWeight;
        MaxLoad = maxLoad;
        Depth = depth;
        Height = height;
        SerialNumber = GenerateSerialNumber();
        LoadWeight = 0;
    }

    private string GenerateSerialNumber()
    {
        return $"KON-{GetContainerType()}-{counter++}";
    }

    protected abstract string GetContainerType();

    public virtual void Load(double weight)
    {
        if (LoadWeight + weight > MaxLoad)
            throw new InvalidOperationException("OverfillException: Przekroczono maksymalną ładowność kontenera.");

        LoadWeight += weight;
    }

    public virtual void Unload()
    {
        LoadWeight = 0;
    }

    public override string ToString()
    {
        return $"{SerialNumber} - Waga: {OwnWeight}kg, Ładunek: {LoadWeight}/{MaxLoad}kg";
    }
}