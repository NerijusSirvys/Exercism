public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // create collection of letters in alphabet, so we can match each of them with characters from given input
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        bool isPalendrome = true;

        // check if each letter in alphabet collection appears in the given input
        // if it doesn't, isPalendrome gets flagged as FALSE
        foreach (var item in alphabet)
        {
            if (!input.ToLower().Contains(item))
            {
                isPalendrome = false;
            }

        }

        return isPalendrome;


    }
}
