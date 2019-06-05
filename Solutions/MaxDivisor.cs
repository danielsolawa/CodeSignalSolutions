namespace CodeSignalSolutions.Solutions
{
    public class MaxDivisor
    {
        int maxDivisor(int left, int right, int divisor)
        {
            for (var i = right; i >= left; i--)
            {
                if (i % divisor == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}