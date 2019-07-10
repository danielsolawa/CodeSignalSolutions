namespace CodeSignalSolutions.Solutions
{
    public class CountWaysToChangeDigit
    {
        int countWaysToChangeDigit(int value)
        {
            var count = 0;
            while (value > 0)
            {
                count += (9 - (value % 10));
                value = value / 10;
            }

            return count;
        }
    }
}