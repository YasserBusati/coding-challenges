namespace ExcelConverter.Services;
public interface IExcelConverterService
{
    Task<MemoryStream> DownloadDefaultExcelTemplateAsync();
    Task<MemoryStream> ConvertAsync(IFormFile file);
}