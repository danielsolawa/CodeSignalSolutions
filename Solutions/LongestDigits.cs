namespace CodeSignalSolutions.Solutions
{
    public class LongestDigits
    {
        string longestDigitsPrefix(string inputString)
        {
            var longestDigits = "";
            if (!char.IsDigit(inputString[0]))
            {
                return string.Empty;
            }

            var isPrefix = true;
            for (var i = 0; i < inputString.Length; i++)
            {
                var cur = inputString[i];
                if (char.IsDigit(cur) && isPrefix)
                {
                    longestDigits += cur;
                }
                else
                {
                    isPrefix = false;
                }

            }

            return longestDigits;
        }
    }
}