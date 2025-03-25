namespace Program1;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isHazardous;

    public LiquidContainer(double ownWeight, double maxLoad, double depth, double height, bool isHazardous)
        : base(ownWeight, maxLoad, depth, height)
    {
        this.isHazardous = isHazardous;
    }

    protected override string GetContainerType() => "L";

    public override void Load(double weight)
    {
        double maxAllowedLoad = isHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (weight > maxAllowedLoad)
        {
            NotifyHazard("Próba niebezpiecznego załadunku.");
            throw new InvalidOperationException("Przekroczono dopuszczalną ładowność dla tego typu kontenera.");
        }

        base.Load(weight);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"ALERT ({SerialNumber}): {message}");
    }
}