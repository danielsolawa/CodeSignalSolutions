using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class HouseOfCats
    {
        int[] houseOfCats(int legs)
        {
            if (legs < 2)
            {
                return new int[] { 0 };
            }

            List<int> list = new List<int>();
            while (legs >= 0)
            {
                list.Add(legs / 2);
                legs -= 4;
            }
            list.Reverse();

            return list.ToArray();


        }
    }
}