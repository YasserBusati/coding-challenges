using RequestTimeoutRestriction;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.Configure<TimeoutOptions>(
    builder.Configuration.GetSection("TimeoutOptions"));
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseMiddleware<RequestTimeoutMiddleware>();


    app.MapGet("/slow", async () =>
    {
        // 7 seconds delay to simulate a long-running task
        await Task.Delay(7000);
        return "Completed!";
    });

    app.MapGet("/fast", () => "Hello, World!");
    app.Run();
}
