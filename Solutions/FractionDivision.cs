using System;

namespace CodeSignalSolutions.Solutions
{
    public class FractionDivision
    {
        int[] fractionDivision(int[] a, int[] b)
        {
            var numerator = a[0] * b[1];
            var denominator = a[1] * b[0];


            for (var i = Math.Min(numerator, denominator); i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                    break;
                }
            }

            return new int[] { numerator, denominator };
        }
    }
}