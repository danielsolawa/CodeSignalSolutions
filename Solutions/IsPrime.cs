namespace CodeSignalSolutions.Solutions
{
    public class IsPrime
    {
        bool isPrime(int n)
        {

            var remainder = 0;

            for (var i = 2; i <= n / 2; i++)
            {
                remainder = n % i;

                if (remainder == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}