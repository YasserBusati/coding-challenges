namespace CodingChallenges.Recursions.Simple;

public class PrintDirectoryFileSystem
{
    public static void Run()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine($"Current Directory: {currentDirectory}");
        PrintDirectoryFileWithSize(currentDirectory, 0);
    }

    public static void PrintDirectoryFileWithSize(string path, int indentLevel)
    {
        try
        {

            var files = Directory.GetFiles(path)
                                 .Select(file => new FileInfo(file))
                                 .OrderBy(fileInfo => fileInfo.Length)
                                 .ToList();

            foreach (var file in files)
            {
                string sizeFormatted = FormatFileSize(file.Length);
                Console.WriteLine($"{new string(' ', indentLevel * 2)}📄 {Path.GetFileName(file.FullName),-30} => {sizeFormatted}");
            }

            var directories = Directory.GetDirectories(path).OrderBy(dir => dir);

            foreach (var dir in directories)
            {
                Console.WriteLine($"{new string(' ', indentLevel * 2)}📂 {Path.GetFileName(dir)}/");
                PrintDirectoryFileWithSize(dir, indentLevel + 1);
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"{new string(' ', indentLevel * 2)}🚫 Access denied to {path}");
        }
    }
    private static string FormatFileSize(long bytes)
    {
        if (bytes < 1024)
            return $"{bytes} bytes";
        else if (bytes < 1048576)
            return $"{bytes / 1024.0:F2} KB";
        else if (bytes < 1073741824)
            return $"{bytes / 1048576.0:F2} MB";
        else
            return $"{bytes / 1073741824.0:F2} GB";
    }
}