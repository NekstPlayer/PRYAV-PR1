namespace Practice_1.Interfaces;

public interface IFileReader
{
    string ReadAsString();

    Task<string> ReadAsStringAsync();
}