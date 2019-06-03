using System;
using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class IncrementalBackup
    {
        int[] incrementalBackups(int lastBackupTime, int[][] changes)
        {
            if (changes.Length == 0)
            {
                return new int[] { };
            }

            ISet<int> set = new HashSet<int>();

            for (var i = 0; i < changes.Length; i++)
            {
                var currentValue = changes[i][0];
                var currentID = changes[i][1];
                if (currentValue > lastBackupTime)
                {
                    set.Add(currentID);
                }
            }

            int[] result = new int[set.Count];
            set.CopyTo(result, 0);
            Array.Sort(result);

            return result;
        }
    }
}