using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class LaunchSequence
    {
        bool launchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            for (var i = 0; i < systemNames.Length; i++)
            {
                var currentName = systemNames[i];
                var currentNum = stepNumbers[i];
                if (!dict.ContainsKey(currentName))
                {
                    dict.Add(currentName, currentNum);
                }
                else
                {
                    var prevNum = dict[currentName];
                    if (prevNum >= currentNum)
                    {
                        return false;
                    }

                    dict[currentName] = currentNum;
                }
            }


            return true;
        }
    }
}