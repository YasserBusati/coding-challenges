namespace CoffeeShopApi.Services.Payment;

public interface IPaymentProcessorService
{
    bool ProcessPayment(double amount);
}