using System.Text;
using Practice_1.Interfaces;

namespace Practice_1.Services;

public class FileReader(string filePath) : IFileReader
{
    public string ReadAsString()
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Файл не найден!");

        var result = new StringBuilder();

        using var fileStream = new FileStream(filePath, FileMode.Open);
        using var streamReader = new StreamReader(fileStream);

        result.Append(streamReader.ReadToEnd());

        return result.ToString();
    }

    public async Task<string> ReadAsStringAsync()
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Файл не найден!");

        var result = new StringBuilder();

        await using var fileStream = new FileStream(filePath, FileMode.Open);
        using var streamReader = new StreamReader(fileStream);

        result.Append(await streamReader.ReadToEndAsync());

        return result.ToString();
    }
}