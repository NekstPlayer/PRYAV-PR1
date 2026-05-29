using Practice_1.Interfaces;
using Practice_1.Services;

namespace Practice_1.Tests;

public class FileReaderTests
{
    [Fact]
    public void ReadAsString_ReadCorrectContent()
    {
        // Arrange
        var path = "test.txt";

        File.WriteAllText(path, "12345");

        IFileReader fileReader = new FileReader(path);

        // Act
        var result = fileReader.ReadAsString();

        // Assert
        Assert.Equal("12345", result);

        File.Delete(path);
    }

    [Fact]
    public async Task ReadAsStringAsync_ReadCorrectContent()
    {
        // Arrange
        var path = "testAsync.txt";

        await File.WriteAllTextAsync(path, "abcdef");

        IFileReader fileReader = new FileReader(path);

        // Act
        var result = await fileReader.ReadAsStringAsync();

        // Assert
        Assert.Equal("abcdef", result);

        File.Delete(path);
    }

    [Fact]
    public void ReadAsString_ThrowException_WhenFileNotExists()
    {
        // Arrange
        IFileReader fileReader = new FileReader("wrong.txt");

        // Assert
        Assert.Throws<FileNotFoundException>(() =>
        {
            fileReader.ReadAsString();
        });
    }
}