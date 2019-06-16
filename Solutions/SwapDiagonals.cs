namespace CodeSignalSolutions.Solutions
{
    public class SwapDiagonals
    {
        int[][] swapDiagonals(int[][] matrix)
        {
            if (matrix.Length == 1)
            {
                return matrix;
            }

            int[] topLeft = new int[] { 0, 0 };
            int[] topRight = new int[] { 0, matrix.Length - 1 };

            while (topLeft[0] < matrix.Length)
            {
                if (topLeft[1] != topRight[1])
                {
                    var temp = matrix[topRight[0]][topRight[1]];
                    matrix[topRight[0]][topRight[1]] = matrix[topLeft[0]][topLeft[1]];
                    matrix[topLeft[0]][topLeft[1]] = temp;
                }

                topLeft[0]++;
                topLeft[1]++;

                topRight[0]++;
                topRight[1]--;
            }

            return matrix;
        }
    }
}