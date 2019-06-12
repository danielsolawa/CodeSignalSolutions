using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class FileNaming
    {
        string[] fileNaming(string[] names)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            string[] result = new string[names.Length];

            for (var i = 0; i < names.Length; i++)
            {
                if (dict.ContainsKey(names[i]))
                {
                    var count = dict[names[i]]++;
                    while (dict.ContainsKey($"{names[i]}({count})"))
                    {
                        count++;
                    }
                    result[i] = $"{names[i]}({count})";
                    dict.Add($"{names[i]}({count})", 1);
                }
                else
                {
                    result[i] = names[i];
                    dict.Add(names[i], 1);
                }
            }

            return result;
        }
    }
}