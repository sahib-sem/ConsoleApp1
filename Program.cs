using System;

public class Program
{
    public static Dictionary<char, int> countFrequency(string literal)
    {
        HashSet<char> alphabet = new HashSet<char>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet.Add(c);
        }

        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char c in literal)
        {

            char n_C = char.ToLower(c);
            if (alphabet.Contains(n_C))
            {
                if (!letterCount.ContainsKey(n_C))
                {
                    letterCount[n_C] = 0;
                }
                letterCount[n_C]++;
            }
        }

        return letterCount;


    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to frequency count program");
        Console.WriteLine("input your string literal to count the frequecy");

        string literal = Console.ReadLine();
        Dictionary<char, int> frequencyCount = countFrequency(literal);
        foreach (var kvp in frequencyCount)
        {
            Console.WriteLine($"key: {kvp.Key}  value: {kvp.Value}");
        }
    }
}
