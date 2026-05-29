using Practice_1.Interfaces;
using Practice_1.Services;

namespace Practice_1.Tests;

public class NumSearcherTests
{
    [Fact]
    public void SearchOf_CorrectlyFindNumbers()
    {
        // Arrange
        INumSearcher numSearcher = new NumSearcher();

        var input = "aaa100bbb200ccc300";

        var expected = new char[]
        {
            '1', '0', '0',
            '2', '0', '0',
            '3', '0', '0'
        };

        // Act
        var result = numSearcher.SearchOf(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SearchOf_ReturnEmptyArray_WhenNoDigits()
    {
        // Arrange
        INumSearcher numSearcher = new NumSearcher();

        var input = "abcdef";

        // Act
        var result = numSearcher.SearchOf(input);

        // Assert
        Assert.Empty(result);
    }
}