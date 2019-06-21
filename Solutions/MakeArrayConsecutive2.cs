using System;

namespace CodeSignalSolutions.Solutions
{
    public class MakeArrayConsecutive2
    {
        int makeArrayConsecutive2(int[] statues)
        {
            var count = 0;
            Array.Sort(statues);

            for (var i = 1; i < statues.Length; i++)
            {
                var diff = statues[i] - statues[i - 1];
                if (diff != 1)
                {
                    count += (diff - 1);
                }
            }

            return count;
        }
    }
}