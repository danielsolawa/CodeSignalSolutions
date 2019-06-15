namespace CodeSignalSolutions.Solutions
{
    public class ReverseOnDiagonals
    {
        int[][] reverseOnDiagonals(int[][] matrix)
        {
            if (matrix.Length == 1)
            {
                return matrix;
            }
            int[] topLeft = new int[] { 0, 0 };
            int[] bottomRight = new int[] { matrix.Length - 1, matrix.Length - 1 };

            while (topLeft[0] < bottomRight[0])
            {
                var temp = matrix[bottomRight[0]][bottomRight[1]];
                matrix[bottomRight[0]][bottomRight[1]] = matrix[topLeft[0]][topLeft[1]];
                matrix[topLeft[0]][topLeft[1]] = temp;

                topLeft[0]++;
                topLeft[1]++;
                bottomRight[0]--;
                bottomRight[1]--;

            }

            int[] topRight = new int[] { 0, matrix.Length - 1 };
            int[] bottomLeft = new int[] { matrix.Length - 1, 0 };

            while (topRight[0] < bottomLeft[0])
            {
                var temp = matrix[bottomLeft[0]][bottomLeft[1]];
                matrix[bottomLeft[0]][bottomLeft[1]] = matrix[topRight[0]][topRight[1]];
                matrix[topRight[0]][topRight[1]] = temp;

                topRight[0]++;
                topRight[1]--;
                bottomLeft[0]--;
                bottomLeft[1]++;

            }

            return matrix;
        }

    }
}