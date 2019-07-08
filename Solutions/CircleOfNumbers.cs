using System;

namespace CodeSignalSolutions.Solutions
{
    public class CircleOfNumbers
    {
        int circleOfNumbers(int n, int firstNumber)
        {
            var half = n / 2;

            if (firstNumber + half > n - 1)
            {
                return Math.Abs((firstNumber + half) - (n - 1)) - 1;
            }

            return firstNumber + half;
        }

    }
}