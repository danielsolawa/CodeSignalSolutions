namespace CodeSignalSolutions.Solutions
{
    public class CountInversionsNaive
    {
        int countInversionsNaive(int[] inputArray)
        {

            var count = 0;
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                for (var j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j]) count++;
                }
            }

            return count;
        }
    }
}