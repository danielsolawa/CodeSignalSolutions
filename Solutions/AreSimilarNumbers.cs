namespace CodeSignalSolutions.Solutions
{
    public class AreSimilarNumbers
    {
        bool areSimilarNumbers(int a, int b, int divisor)
        {
            return (a % divisor == 0 && b % divisor == 0) || (a % divisor != 0 && b % divisor != 0);
        }
    }
}