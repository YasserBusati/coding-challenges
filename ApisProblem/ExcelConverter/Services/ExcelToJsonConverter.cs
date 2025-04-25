using System.Collections.Specialized;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using OfficeOpenXml;

namespace ExcelConverter.Services;
public static class ExcelToJsonConverter
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };
    public static async Task<string> ConvertAsync(IFormFile file)
    {
        using var stream = new MemoryStream();
        await file.CopyToAsync(stream);
        stream.Position = 0;

        using var package = new ExcelPackage(stream);
        var worksheet = ValidateAndGetWorksheet(package);

        var result = new OrderedDictionary
        {
            ["header"] = CreateHeader(),
            ["transactions"] = ExtractTransactions(worksheet)
        };

        return JsonSerializer.Serialize(result, JsonOptions);
    }

    private static ExcelWorksheet ValidateAndGetWorksheet(ExcelPackage package)
    {
        if (package.Workbook.Worksheets.Count == 0)
        {
            throw new Exception("No worksheets found in the Excel file.");
        }

        var worksheet = package.Workbook.Worksheets[0];

        if (worksheet.Dimension == null || worksheet.Dimension.Rows == 0 || worksheet.Dimension.Columns == 0)
        {
            throw new Exception("The worksheet is empty.");
        }

        return worksheet;
    }

    private static OrderedDictionary CreateHeader()
    {
        var timestamp = new Dictionary<string, object>
        {
            ["timestamp"] = DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")
        };

        return new OrderedDictionary
        {
            ["file_type"] = Config.FileType,
            ["fi"] = Config.FinancialInstitution,
            ["sender_notes"] = timestamp
        };
    }

    private static List<OrderedDictionary> ExtractTransactions(ExcelWorksheet worksheet)
    {
        var transactions = new List<OrderedDictionary>();
        int rowCount = worksheet.Dimension.Rows;
        int colCount = worksheet.Dimension.Columns;

        for (int row = 2; row <= rowCount; row++)
        {
            if (IsRowEmpty(worksheet, row, colCount))
            {
                break;
            }

            transactions.Add(CreateTransaction(worksheet, row, colCount));
        }

        return transactions;
    }

    private static OrderedDictionary CreateTransaction(ExcelWorksheet worksheet, int row, int colCount)
    {
        var transaction = new OrderedDictionary();
        var transactionFields = new OrderedDictionary();

        for (int col = 1; col <= colCount; col++)
        {
            string header = worksheet.Cells[1, col].Text;
            string cellValue = (worksheet.Cells[row, col].Text ?? string.Empty).Trim();

            ProcessTransactionField(header, cellValue, transaction, transactionFields);
        }

        // Add common fields
        transactionFields["transaction_ref_number"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        transactionFields["currency"] = Config.DefaultCurrency;

        transaction["transaction"] = transactionFields;
        return transaction;
    }

    private static void ProcessTransactionField(string header, string cellValue,
        OrderedDictionary transaction, OrderedDictionary transactionFields)
    {
        if (string.IsNullOrWhiteSpace(header)) return;

        if (header.Equals("Card_number", StringComparison.OrdinalIgnoreCase))
        {
            transaction["card_number"] = cellValue;
        }
        else if (header.Equals("Transaction_Type", StringComparison.OrdinalIgnoreCase))
        {
            ProcessTransactionType(cellValue, transactionFields);
        }
        else if (header.Equals("Amount", StringComparison.OrdinalIgnoreCase))
        {
            ProcessAmount(cellValue, transactionFields);
        }
        else if (header.Equals("Description", StringComparison.OrdinalIgnoreCase))
        {
            transactionFields["description"] = cellValue;
        }
    }

    private static void ProcessTransactionType(string transactionType, OrderedDictionary transactionFields)
    {
        if (string.IsNullOrWhiteSpace(transactionType)) return;

        transactionFields["transaction_code"] = transactionType.Equals("Credit", StringComparison.OrdinalIgnoreCase)
            ? Config.CreditTransactionCode
            : Config.DebitTransactionCode;
    }

    private static void ProcessAmount(string amountValue, OrderedDictionary transactionFields)
    {
        if (decimal.TryParse(amountValue, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount))
        {
            transactionFields["amount"] = amount;
        }
        else
        {
            transactionFields["amount"] = 0;
        }
    }

    private static bool IsRowEmpty(ExcelWorksheet worksheet, int row, int colCount)
    {
        for (int col = 1; col <= colCount; col++)
        {
            if (!string.IsNullOrWhiteSpace(worksheet.Cells[row, col].Text))
            {
                return false;
            }
        }
        return true;
    }
}