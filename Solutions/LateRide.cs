namespace CodeSignalSolutions.Solutions
{
    public class LateRide
    {
        int lateRide(int n)
        {
            return n < 60 ? SumDigits(n) : SumDigits(n / 60) + SumDigits(n % 60);
        }

        int SumDigits(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }

            return sum;
        }
    }
}