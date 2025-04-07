using System.Net;

namespace IPAddressRestriction;

public class IpRestrictionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<IpRestrictionMiddleware> _logger;
    private readonly HashSet<string> _allowedIps;

    public IpRestrictionMiddleware(RequestDelegate next, ILogger<IpRestrictionMiddleware> logger, IConfiguration configuration)
    {
        _next = next;
        _logger = logger;

        var allowedIps = configuration.GetSection("AllowedIPs").Get<List<string>>() ?? new();
        _allowedIps = allowedIps.Select(IPAddress.Parse).Select(ip => ip.ToString()).ToHashSet();
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var remoteIp = context.Connection.RemoteIpAddress;

        _logger.LogInformation("Request from IP: {RemoteIp}", remoteIp);

        if (remoteIp != null && !_allowedIps.Contains(remoteIp.ToString()))
        {
            _logger.LogWarning("Blocked request from IP: {BlockedIp}", remoteIp);
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            await context.Response.WriteAsync("403 Forbidden - Your IP is not allowed.");
            return;
        }

        await _next(context);
    }
}
