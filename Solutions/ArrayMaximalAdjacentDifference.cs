using System;

namespace CodeSignalSolutions.Solutions
{
    public class ArrayMaximalAdjacentDifference
    {
        int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            var maxDifference = 0;
            for (var i = 1; i < inputArray.Length; i++)
            {
                var currentDifference = Math.Abs(inputArray[i - 1] - inputArray[i]);
                maxDifference = Math.Max(maxDifference, currentDifference);
            }

            return maxDifference;
        }
    }
}