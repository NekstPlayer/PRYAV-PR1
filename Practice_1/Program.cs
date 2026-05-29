using Practice_1.Interfaces;
using Practice_1.Services;

var path = "hash.txt";

IFileReader fileReader = new FileReader(path);

INumSearcher numSearcher = new NumSearcher();

var calculator = new Calculator();

var hash = fileReader.ReadAsString();

var numbers = numSearcher.SearchOf(hash);

var sum = calculator.SumOfNumberInHash(numbers);

var factors = calculator.Factorize(numbers);

Console.WriteLine($"Сумма цифр: {sum}");

Console.WriteLine("Простые множители:");

foreach (var factor in factors)
{
    Console.WriteLine(factor);
}