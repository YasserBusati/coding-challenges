using CoffeeShopApi.Services.Payment;
using CoffeeShopApi.Services.Order;
using CoffeeShopApi.Services.Brewer;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApi.Endpoints;
public static class CoffeeEndpoints
{
    private const string BasePath = "/api/coffee";
    private const string CoffeeTag = "Coffee";

    public static void MapCoffeeEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(BasePath)
                      .DisableAntiforgery()
                      .WithTags(CoffeeTag);

        group.MapOrderCoffeeEndpoint();
        group.MapGetOrdersEndpoint();
    }

    private static void MapOrderCoffeeEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/order", (
            [FromQuery] string beanType,
            [FromQuery] double amount,
            ICoffeeBrewerService brewer,
            IOrderRepository orderRepository,
            IPaymentProcessorService paymentProcessor,
            ILogger<Program> logger) =>
        {
            try
            {
                logger.LogInformation("Coffee order request received for {BeanType}", beanType);

                if (!paymentProcessor.ProcessPayment(amount))
                {
                    return Results.BadRequest("Payment failed");
                }

                var coffee = brewer.BrewCoffee(beanType);
                orderRepository.AddOrder(coffee);

                return Results.Ok(new
                {
                    Message = "Coffee ordered successfully",
                    Coffee = coffee,
                    AmountPaid = amount
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing coffee order");
                return Results.Problem(
                    title: "Order failed",
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError);
            }
        })
        .WithName("OrderCoffee")
        .Produces<Ok<object>>(StatusCodes.Status200OK)
        .Produces<BadRequest<string>>(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status500InternalServerError)
        .WithOpenApi(operation =>
        {
            operation.Summary = "Order a coffee";
            operation.Description = "Orders a coffee of specified type after processing payment";
            operation.Parameters[0].Description = "Type of coffee beans (Arabica, Robusta, etc.)";
            operation.Parameters[1].Description = "Payment amount";
            return operation;
        });
    }

    private static void MapGetOrdersEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/orders", (IOrderRepository orderRepository) =>
        {
            return Results.Ok(orderRepository.GetOrders());
        })
        .WithName("GetAllOrders")
        .Produces<Ok<IEnumerable<string>>>(StatusCodes.Status200OK)
        .WithOpenApi(operation =>
        {
            operation.Summary = "Get all coffee orders";
            operation.Description = "Returns a list of all coffee orders made";
            return operation;
        });
    }


}