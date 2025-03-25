namespace Program1;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double ownWeight, double maxLoad, double depth, double height)
        : base(ownWeight, maxLoad, depth, height) { }

    protected override string GetContainerType() => "G";

    public override void Unload()
    {
        LoadWeight *= 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"ALERT ({SerialNumber}): {message}");
    }
}