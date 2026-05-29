using Practice_1.Interfaces;

namespace Practice_1.Services;

public class NumSearcher : INumSearcher
{
    public char[] SearchOf(string initialString)
    {
        var findChars = new List<char>();

        foreach (var ch in initialString)
        {
            if (char.IsDigit(ch))
            {
                findChars.Add(ch);
            }
        }

        return findChars.ToArray();
    }
}