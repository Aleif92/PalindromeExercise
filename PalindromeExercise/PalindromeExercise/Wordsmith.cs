namespace PalindromeExercise;

public class Wordsmith
{
    public bool IsAPalindrome(string word)
    {
        var reversed = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        if (word.ToLower() == reversed.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}