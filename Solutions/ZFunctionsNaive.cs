namespace CodeSignalSolutions.Solutions
{
    public class ZFunctionsNaive
    {
        int[] zFunctionNaive(string s)
        {
            int[] r = new int[s.Length];

            var sub = s;
            var index = 0;
            while (sub.Length > 0)
            {
                var count = 0;
                for (var i = 0; i < sub.Length; i++)
                {
                    if (sub[i] == s[i])
                        count++;
                    else
                        break;
                }
                r[index++] = count;
                sub = sub.Substring(1);
            }

            return r;
        }
    }
}