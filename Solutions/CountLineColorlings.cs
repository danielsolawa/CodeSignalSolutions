namespace CodeSignalSolutions.Solutions
{
    public class CountLineColorlings
    {
        int countLineColorings(int points, int colors)
        {
            return helper(points, colors, 0);

        }
        int helper(int points, int colors, int index)
        {
            if (index == points)
            {
                return 1;
            }

            if (index == 0)
            {
                return colors * helper(points, colors, ++index);
            }

            return (colors - 1) * helper(points, colors, ++index);
        }
    }
}