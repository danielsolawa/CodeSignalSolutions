using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class IsLucky
    {
        bool isLucky(int n)
        {
            return helper(n);
        }


        bool helper(int n)
        {
            List<int> list = new List<int>();
            while (n > 0)
            {
                list.Add(n % 10);
                n = n / 10;
            }

            var leftCount = 0;
            for (var i = 0; i < list.Count / 2; i++)
            {
                leftCount += list[i];
            }

            var rightCount = 0;
            for (var i = list.Count / 2; i < list.Count; i++)
            {
                rightCount += list[i];
            }


            return leftCount == rightCount;
        }
    }
}