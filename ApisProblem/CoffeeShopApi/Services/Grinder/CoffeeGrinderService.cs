namespace CoffeeShopApi.Services.Grinder;

public class CoffeeGrinderService : ICoffeeGrinderService
{
    private readonly Guid _id = Guid.NewGuid();

    public string GrindCoffee(string beanType)
    {
        return $"Ground coffee from {beanType} (Grinder ID: {_id})";
    }
}