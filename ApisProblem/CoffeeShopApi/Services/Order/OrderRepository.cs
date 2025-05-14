namespace CoffeeShopApi.Services.Order;

public class OrderRepository : IOrderRepository
{
    private readonly List<string> _orders = new();
    private readonly Guid _id = Guid.NewGuid();

    public void AddOrder(string order)
    {
        _orders.Add($"{order} (Repo ID: {_id})");
    }

    public IEnumerable<string> GetOrders()
    {
        return _orders;
    }
}