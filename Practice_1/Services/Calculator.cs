namespace Practice_1.Services;

public class Calculator
{
    public int[] Factorize(char[] chars)
    {
        List<int> factors = [];

        var num = SumOfNumberInHash(chars);

        while (num % 2 == 0)
        {
            factors.Add(2);
            num /= 2;
        }

        for (var i = 3; i <= Math.Sqrt(num); i += 2)
        {
            while (num % i == 0)
            {
                factors.Add(i);
                num /= i;
            }
        }

        if (num > 2)
        {
            factors.Add(num);
        }

        return factors.ToArray();
    }

    public int SumOfNumberInHash(char[] charOfNums)
    {
        var resultNum = 0;

        foreach (var num in charOfNums)
        {
            resultNum += Convert.ToInt32(num - '0');
        }

        return resultNum;
    }
}