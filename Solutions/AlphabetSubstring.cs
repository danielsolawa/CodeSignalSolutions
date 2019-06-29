namespace CodeSignalSolutions.Solutions
{
    public class AlphabetSubstring
    {
        bool alphabetSubstring(string s)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            return alphabet.Contains(s);
        }
    }
}