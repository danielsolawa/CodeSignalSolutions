namespace CodeSignalSolutions.Solutions
{
    public class MetroCard
    {
        int[] metroCard(int lastNumberOfDays)
        {
            if (lastNumberOfDays == 30)
                return new int[] { 31 };
            else if (lastNumberOfDays == 31)
                return new int[] { 28, 30, 31 };

            return new int[] { 31 };
        }
    }
}