using System;

namespace CodeSignalSolutions.Solutions
{
    public class SecondSmallestElement
    {
        int SecondSmallest(int[] arr)
        {
            int first = Math.Min(arr[0], arr[1]);
            int second = Math.Max(arr[0], arr[1]);

            for (var i = 2; i < arr.Length; i++)
            {
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] < second)
                {
                    second = arr[i];
                }
            }

            return second;
        }
    }
}