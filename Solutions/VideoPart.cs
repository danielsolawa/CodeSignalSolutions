using System;

namespace CodeSignalSolutions.Solutions
{
    public class VideoPart
    {
        int[] videoPart(string part, string total)
        {
            string[] p = part.Split(":");
            string[] t = total.Split(":");

            var partInSeconds = ConvertToSeconds(p);
            var totalInSeconds = ConvertToSeconds(t);

            if (partInSeconds == totalInSeconds)
            {
                return new int[] { 1, 1 };
            }

            var gcd = GCD(partInSeconds, totalInSeconds);


            return new int[] { partInSeconds / gcd, totalInSeconds / gcd };
        }


        int ConvertToSeconds(string[] time)
        {
            var hours = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);
            var seconds = Convert.ToInt32(time[2]);


            return seconds + (minutes * 60) + (hours * 3600);

        }

        public int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

    }
}