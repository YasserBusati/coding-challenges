using Microsoft.Extensions.Options;

namespace RequestTimeoutRestriction;


public class RequestTimeoutMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestTimeoutMiddleware> _logger;
    private readonly TimeSpan _timeout;

    public RequestTimeoutMiddleware(RequestDelegate next, ILogger<RequestTimeoutMiddleware> logger, IOptions<TimeoutOptions> options)
    {
        _next = next;
        _logger = logger;
        _timeout = TimeSpan.FromSeconds(options.Value.RequestTimeoutInSeconds);
    }

    public async Task InvokeAsync(HttpContext context)
    {
        using var cts = new CancellationTokenSource(_timeout);
        var linkedToken = CancellationTokenSource.CreateLinkedTokenSource(cts.Token, context.RequestAborted).Token;

        try
        {
            var task = _next(context);
            var completed = await Task.WhenAny(task, Task.Delay(Timeout.Infinite, linkedToken));

            if (!completed.Equals(task))
            {
                context.Response.StatusCode = StatusCodes.Status408RequestTimeout;
                await context.Response.WriteAsync("⏱️ Request took too long and was cancelled.");
                _logger.LogWarning("Request to {Path} timed out after {Timeout} seconds", context.Request.Path, _timeout.TotalSeconds);
            }
        }
        catch (OperationCanceledException) when (cts.IsCancellationRequested)
        {
            context.Response.StatusCode = StatusCodes.Status408RequestTimeout;
            await context.Response.WriteAsync("⏱️ Request cancelled due to timeout.");
        }
    }

}