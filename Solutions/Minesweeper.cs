namespace CodeSignalSolutions.Solutions
{
    public class Minesweeper
    {
        int[][] minesweeper(bool[][] matrix)
        {
            int[][] result = new int[matrix.Length][];
            for (var i = 0; i < matrix.Length; i++)
            {
                result[i] = new int[matrix[i].Length];
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    result[i][j] = countMines(matrix, i, j);
                }
            }

            return result;
        }

        int countMines(bool[][] matrix, int row, int col)
        {
            var count = 0;

            //check top
            if (isInBounds(matrix.Length, matrix[0].Length, row - 1, col))
            {
                if (matrix[row - 1][col])
                {
                    count++;
                }
            }

            //check bottom
            if (isInBounds(matrix.Length, matrix[0].Length, row + 1, col))
            {
                if (matrix[row + 1][col])
                {
                    count++;
                }
            }

            //check left
            if (isInBounds(matrix.Length, matrix[0].Length, row, col - 1))
            {
                if (matrix[row][col - 1])
                {
                    count++;
                }
            }

            //check right 
            if (isInBounds(matrix.Length, matrix[0].Length, row, col + 1))
            {
                if (matrix[row][col + 1])
                {
                    count++;
                }
            }


            //check top left
            if (isInBounds(matrix.Length, matrix[0].Length, row - 1, col - 1))
            {
                if (matrix[row - 1][col - 1])
                {
                    count++;
                }
            }

            //check top right
            if (isInBounds(matrix.Length, matrix[0].Length, row - 1, col + 1))
            {
                if (matrix[row - 1][col + 1])
                {
                    count++;
                }
            }

            //check bottom left
            if (isInBounds(matrix.Length, matrix[0].Length, row + 1, col - 1))
            {
                if (matrix[row + 1][col - 1])
                {
                    count++;
                }
            }

            //check bottom right
            if (isInBounds(matrix.Length, matrix[0].Length, row + 1, col + 1))
            {
                if (matrix[row + 1][col + 1])
                {
                    count++;
                }
            }

            return count;

        }

        bool isInBounds(int maxRowLength, int maxColLength, int row, int col)
        {
            return row >= 0 && row < maxRowLength && col >= 0 && col < maxColLength;
        }

    }
}