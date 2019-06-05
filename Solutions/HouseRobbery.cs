using System;

namespace CodeSignalSolutions.Solutions
{
    public class HouseRobbery
    {
        public int HouseRobber(int[] nums)
        {
            int[] memo = new int[nums.Length + 1];
            Array.Fill(memo, -1);
            return Helper(nums, memo, 0);
        }

        public int Helper(int[] input, int[] memo, int currentIndex)
        {
            if (currentIndex > input.Length)
            {
                return 0;
            }

            if (memo[currentIndex] != -1)
            {
                return memo[currentIndex];
            }

            memo[currentIndex] =
             Math.Max(input[currentIndex] + Helper(input, memo, currentIndex + 2), Helper(input, memo, currentIndex + 1));

            return memo[currentIndex];
        }
    }
}