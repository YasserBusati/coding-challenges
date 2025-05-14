using CoffeeShopApi.Services.Payment;
using CoffeeShopApi.Services.Order;
using CoffeeShopApi.Services.Brewer;
using CoffeeShopApi.Services.Grinder;
using CoffeeShopApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddTransient<ICoffeeGrinderService, CoffeeGrinderService>();
    builder.Services.AddScoped<ICoffeeBrewerService, CoffeeBrewerService>();
    builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
    builder.Services.AddTransient<IPaymentProcessorService, PaymentProcessorService>();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.MapCoffeeEndpoints();

    app.Run();
}

