namespace CoffeeShopApi.Services.Payment;

public class PaymentProcessorService : IPaymentProcessorService
{
    public bool ProcessPayment(double amount)
    {
        // Simulate payment processing
        return amount > 0;
    }
}