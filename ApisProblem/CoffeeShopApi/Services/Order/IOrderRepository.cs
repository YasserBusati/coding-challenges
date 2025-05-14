namespace CoffeeShopApi.Services.Order;

public interface IOrderRepository
{
    void AddOrder(string order);
    IEnumerable<string> GetOrders();
}