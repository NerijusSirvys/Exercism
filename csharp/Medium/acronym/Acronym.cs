using System;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        // characters that will be used as a seperators to split phrase into individual strings
        char[] seperators = new char[] { ' ', '-' };

        // characters that will be trimed off from individual strings
        char[] scrapCharacters = new[] { ',', '-', '_' };

        // sprits string using seperators and remove any array item that is empty
        string[] words = phrase.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder builder = new StringBuilder();

        foreach (var item in words)
        {
            string trimedWord = item.Trim(scrapCharacters);

            if (char.IsLetter(trimedWord[0]))
            {
                builder.Append(trimedWord[0].ToString().ToUpper());
            }
        }

        return builder.ToString();
    }
}