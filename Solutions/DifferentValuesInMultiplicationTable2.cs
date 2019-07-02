using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class DifferentValuesInMultiplicationTable2
    {
        int differentValuesInMultiplicationTable2(int n, int m)
        {
            ISet<int> set = new HashSet<int>();
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    set.Add((i + 1) * (j + 1));
                }
            }

            return set.Count;
        }
    }
}