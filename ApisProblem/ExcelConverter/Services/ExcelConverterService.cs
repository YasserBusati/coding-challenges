using System.Text;
using OfficeOpenXml;

namespace ExcelConverter.Services;

public class ExcelConverterService : IExcelConverterService
{

    public async Task<MemoryStream> DownloadDefaultExcelTemplateAsync()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "DefaultExcel.xlsx");
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Default Excel template not found.", filePath);
        }
        var memoryStream = new MemoryStream();
        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            await fileStream.CopyToAsync(memoryStream);
        }
        memoryStream.Position = 0;
        return memoryStream;

    }

    public async Task<MemoryStream> ConvertAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            throw new ArgumentException("File is empty or null.");
        }

        string jsonResult = await ExcelToJsonConverter.ConvertAsync(file);
        var byteArray = Encoding.UTF8.GetBytes(jsonResult);

        return new MemoryStream(byteArray);
    }


}