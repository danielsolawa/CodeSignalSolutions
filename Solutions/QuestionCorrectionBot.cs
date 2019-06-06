using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Solutions
{
    public class QuestionCorrectionBot
    {
        string questionCorrectionBot(string question)
        {

            var s = $"{question.Trim()}?";
            s = Regex.Replace(s, @"[?]{2,}", "?");
            s = Regex.Replace(s, @"\s+,|,", ", ");
            s = Regex.Replace(s, @"\s{2,}", " ");

            return $"{char.ToUpperInvariant(s[0])}{s.Substring(1)}";
        }
    }
}