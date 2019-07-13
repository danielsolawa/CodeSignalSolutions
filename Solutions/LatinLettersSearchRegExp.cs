using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Solutions
{
    public class LatinLettersSearchRegExp
    {
        bool latinLettersSearchRegExp(string input)
        {
            Regex rx = new Regex("[a-zA-Z]{1}");
            return rx.IsMatch(input);
        }
    }
}