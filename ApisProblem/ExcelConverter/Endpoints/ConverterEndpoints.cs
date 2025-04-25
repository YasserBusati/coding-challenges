using ExcelConverter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace ExcelConverter.Endpoints;

public static class ConverterEndpoints
{
    private const string BasePath = "/api/converter";
    private const string ConverterTag = "Converter";

    public static void MapConverterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(BasePath)
                      .DisableAntiforgery()
                      .WithTags(ConverterTag);

        group.MapConvertExcelEndpoint();
        group.MapDownloadTemplateEndpoint();
    }

    private static void MapConvertExcelEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/convert", async (IFormFile file, IExcelConverterService converter) =>
           {
               var stream = await converter.ConvertAsync(file);
               return Results.File(stream, "application/json", "converted.json");
           })
           .WithName("ConvertExcel")
           .Produces<string>(StatusCodes.Status200OK)
           .Produces(StatusCodes.Status400BadRequest);

    }

    private static void MapDownloadTemplateEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/download-template", async (
            IExcelConverterService converter,
            ILogger<Program> logger) =>
        {
            try
            {
                logger.LogInformation("Excel template download request received");
                var stream = await converter.DownloadDefaultExcelTemplateAsync();
                return Results.File(stream,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "DefaultExcel.xlsx");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during template download");
                return Results.Problem(
                    title: "Template download failed",
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError);
            }
        })
        .WithName("DownloadExcelTemplate")
        .Produces<FileStreamResult>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status500InternalServerError)
        .WithOpenApi(operation =>
        {
            operation.Summary = "Download Excel template";
            operation.Description = "Downloads a template Excel file with the required format";
            return operation;
        });
    }

}
