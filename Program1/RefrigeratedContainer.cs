namespace Program1;

public class RefrigeratedContainer : Container
{
    private double requiredTemperature;

    public RefrigeratedContainer(double ownWeight, double maxLoad, double depth, double height, double requiredTemperature)
        : base(ownWeight, maxLoad, depth, height)
    {
        this.requiredTemperature = requiredTemperature;
    }

    protected override string GetContainerType() => "C";

    public bool CanStoreProduct(string product, double productTemp)
    {
        return productTemp >= requiredTemperature;
    }
}
