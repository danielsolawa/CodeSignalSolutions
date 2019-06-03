namespace CodeSignalSolutions.Solutions
{
    public class BuildPalindrome
    {
        string buildPalindrome(string s)
        {
            if (IsPalindrome(s))
            {
                return s;
            }

            var reversed = Reverse(s);
            var temp = s;
            var index = reversed.Length - 1;
            while (!IsPalindrome(temp))
            {
                temp = s + reversed.Substring(index);
                index--;
            }


            return temp;
        }

        string Reverse(string s)
        {
            var r = "";
            for (var i = s.Length - 2; i >= 0; i--)
            {
                r += s[i];
            }


            return r;
        }


        bool IsPalindrome(string s)
        {
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}