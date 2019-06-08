namespace CodeSignalSolutions.Solutions
{
    public class ReverseTwoDigits
    {
        int reverseTwoDigits(int n)
        {
            var digits = countDigits(n);
            if (digits == 1)
            {
                return n;
            }

            var result = 0;
            while (digits >= 10)
            {
                result *= 100;

                var pairOfDigits = n / (digits / 10);
                var first = pairOfDigits / 10;
                var second = pairOfDigits % 10;

                n = n % (digits / 10);
                digits = digits / 100;

                result += (second * 10) + first;
            }

            if (n > 0)
            {
                result = (result * 10) + n;
            }

            return result;
        }


        int countDigits(int n)
        {
            var count = 1;
            while (n > 0)
            {
                count *= 10;
                n = n / 10;
            }

            return count / 10;
        }
    }
}