using System;
using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class BoxesPacking
    {
        bool boxesPacking(int[] length, int[] width, int[] height)
        {
            if (length.Length == 1)
            {
                return true;
            }

            List<int[]> list = new List<int[]>();
            for (var i = 0; i < length.Length; i++)
            {
                list.Add(new int[] { length[i] + width[i] + height[i], i });
            }

            list.Sort((a1, a2) =>
            {
                if (a1[0] < a2[0])
                    return 1;
                else
                    return -1;
            });

            for (var i = 1; i < list.Count; i++)
            {
                int l1 = length[list[i - 1][1]], l2 = length[list[i][1]];
                int w1 = width[list[i - 1][1]], w2 = width[list[i][1]];
                int h1 = height[list[i - 1][1]], h2 = height[list[i][1]];

                int[] a1 = new int[] { l1, w1, h1 };
                int[] a2 = new int[] { l2, w2, h2 };

                if (!IsPackable(a1, a2))
                    return false;
            }

            return true;

        }

        bool IsPackable(int[] a1, int[] a2)
        {
            Array.Sort(a1);
            Array.Sort(a2);


            return (a1[0] > a2[0] && a1[1] > a2[1] && a1[2] > a2[2]);
        }

    }
}