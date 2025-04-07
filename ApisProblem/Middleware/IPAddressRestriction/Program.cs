using IPAddressRestriction;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseMiddleware<IpRestrictionMiddleware>();

    app.MapGet("/resources", () => "✅ Welcome! Your IP is allowed.");

    app.Run();

}