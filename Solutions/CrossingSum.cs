namespace CodeSignalSolutions.Solutions
{
    public class CrossingSum
    {
        int crossingSum(int[][] matrix, int a, int b)
        {

            var sum = 0;

            for (var i = 0; i < matrix[a].Length; i++)
            {

                sum += matrix[a][i];
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                if (i == a)
                {
                    continue;
                }
                sum += matrix[i][b];
            }


            return sum;
        }
    }
}