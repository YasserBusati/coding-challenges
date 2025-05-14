using CoffeeShopApi.Services.Grinder;

namespace CoffeeShopApi.Services.Brewer;

public class CoffeeBrewerService : ICoffeeBrewerService
{
    private readonly Guid _id = Guid.NewGuid();
    private readonly ICoffeeGrinderService _grinder;

    public CoffeeBrewerService(ICoffeeGrinderService grinder)
    {
        _grinder = grinder;
    }

    public string BrewCoffee(string beanType)
    {
        var groundCoffee = _grinder.GrindCoffee(beanType);
        return $"Brewed coffee using {groundCoffee} (Brewer ID: {_id})";
    }
}