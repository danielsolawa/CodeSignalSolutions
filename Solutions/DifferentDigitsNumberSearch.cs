using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class DifferentDigitsNumberSearch
    {
        int differentDigitsNumberSearch(int[] inputArray)
        {

            for (var i = 0; i < inputArray.Length; i++)
            {
                if (hasUniqueDigits(inputArray[i]))
                {
                    return inputArray[i];
                }
            }


            return -1;
        }

        bool hasUniqueDigits(int n)
        {
            ISet<int> set = new HashSet<int>();
            var count = 0;
            while (n > 0)
            {
                count++;
                set.Add(n % 10);
                n = n / 10;
            }


            return set.Count == count ? true : false;
        }

    }
}