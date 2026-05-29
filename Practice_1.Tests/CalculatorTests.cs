using Practice_1.Services;

namespace Practice_1.Tests;

public class CalculatorTests
{
    [Fact]
    public void SumOfNumberInHash_ReturnCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        var chars = new char[]
        {
            '1', '2', '3'
        };

        // Act
        var result = calculator.SumOfNumberInHash(chars);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Factorize_ReturnPrimeFactors()
    {
        // Arrange
        var calculator = new Calculator();

        var chars = new char[]
        {
            '1', '2', '3'
        };

        // Сумма = 6
        // Простые множители = 2 и 3

        var expected = new int[]
        {
            2, 3
        };

        // Act
        var result = calculator.Factorize(chars);

        // Assert
        Assert.Equal(expected, result);
    }
}