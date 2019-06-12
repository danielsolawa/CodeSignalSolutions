namespace CodeSignalSolutions.Solutions
{
    public class ExtractMatrixColumn
    {
        int[] extractMatrixColumn(int[][] matrix, int column)
        {
            int[] result = new int[matrix.Length];

            for (var i = 0; i < matrix.Length; i++)
            {
                result[i] = matrix[i][column];
            }

            return result;
        }
    }
}