using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class TaskMaker
    {
        string[] taskMaker(string[] source, int challengeId)
        {
            List<string> result = new List<string>();
            var toRemove = $"//DB {challengeId}//";

            for (var i = 0; i < source.Length; i++)
            {
                var currentLine = source[i];


                if (currentLine.Contains(toRemove))
                {
                    currentLine = currentLine.Replace(toRemove, "");
                    result.RemoveAt(result.Count - 1);
                }

                if (currentLine.Trim().StartsWith("//DB"))
                {
                    continue;
                }

                result.Add(currentLine);

            }

            return result.ToArray();
        }
    }
}