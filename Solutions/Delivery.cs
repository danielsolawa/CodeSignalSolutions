using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class Delivery
    {
        bool[] delivery(int[] order, int[][] shoppers)
        {
            List<bool> result = new List<bool>();
            for (var i = 0; i < shoppers.Length; i++)
            {
                double time = (double)(order[0] + shoppers[i][0]) / shoppers[i][1] + shoppers[i][2];

                if (time < order[1])
                {
                    result.Add(false);
                }
                else
                {
                    if (time <= order[1] + order[2])
                    {
                        result.Add(true);
                    }
                    else
                    {
                        result.Add(false);
                    }

                }
            }

            return result.ToArray();
        }
    }
}