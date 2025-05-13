using QRCoder;
using System.Drawing.Imaging;

namespace GenerateQRCode.Endpoints;

public static class QRCodeEndpoints
{
    private const string BasePath = "/api/QRCode";
    private const string QRCodeTag = "QRCode";

    public static void MapQRCodeEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(BasePath)
                      .DisableAntiforgery()
                      .WithTags(QRCodeTag);

        group.MapGenerateQRCodeImageEndpoint();
        group.MapGenerateQRCodeBase64Endpoint();

    }
    private static void MapGenerateQRCodeImageEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/generate", (string text) =>
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return Results.BadRequest("Text parameter is required.");
            }

            // Generate QR code
            using var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new QRCode(qrCodeData);
            using var qrCodeImage = qrCode.GetGraphic(20);

            // Convert to PNG
            using var stream = new MemoryStream();
            qrCodeImage.Save(stream, ImageFormat.Png);

            // Return as file
            return Results.File(stream.ToArray(), "image/png", "qrcode.png");
        })
        .WithName("GenerateQRCode")
        .Produces(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status400BadRequest);
    }
    private static void MapGenerateQRCodeBase64Endpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/generate-base64", (string text) =>
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return Results.BadRequest("Text parameter is required.");
                }

                // Generate QR code
                using var qrGenerator = new QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                using var qrCode = new QRCode(qrCodeData);
                using var qrCodeImage = qrCode.GetGraphic(20);

                // Convert to PNG and then to Base64
                using var stream = new MemoryStream();
                qrCodeImage.Save(stream, ImageFormat.Png);
                var base64String = Convert.ToBase64String(stream.ToArray());

                // Return as JSON with Base64 string
                return Results.Ok(new { qrCodeBase64 = $"data:image/png;base64,{base64String}" });
            })
            .WithName("GenerateQRCodeBase64")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);
    }
}