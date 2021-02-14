public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lCaseWord = word.ToLower();
        bool isLetterUnique = true;

        foreach (var letter in lCaseWord)
        {
            if (CountMach(letter, lCaseWord) > 1)
            {
                isLetterUnique = false;
            }


            // checks if current letter is white space or hyphen
            // restores isLetterUnique back to TRUE to avoid false fail
            if (string.IsNullOrWhiteSpace(letter.ToString()) || letter == '-')
            {
                isLetterUnique = true;
            }
        }
        return isLetterUnique;
    }



    // counts how many times given character appears in the word
    // and returns count 
    private static int CountMach(char character, string word)
    {
        int counter = 0;

        foreach (var letter in word)
        {
            if (letter == character)
            {
                counter++;
            }
        }

        return counter;
    }
}
