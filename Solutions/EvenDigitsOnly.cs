namespace CodeSignalSolutions.Solutions
{
    public class EvenDigitsOnly
    {
        bool evenDigitsOnly(int n)
        {
            while (n > 0)
            {
                var currentDigit = n % 10;
                if (currentDigit % 2 != 0)
                {
                    return false;
                }
                n = n / 10;
            }
            return true;
        }
    }
}