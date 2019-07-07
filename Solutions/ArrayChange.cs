using System;

namespace CodeSignalSolutions.Solutions
{
    public class ArrayChange
    {
        int arrayChange(int[] inputArray)
        {
            var count = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                var previous = inputArray[i - 1];
                var current = inputArray[i];
                if (current <= previous)
                {
                    var diff = (Math.Abs(current - previous) + 1);
                    count += diff;
                    inputArray[i] += diff;
                }
            }

            return count;
        }
    }
}