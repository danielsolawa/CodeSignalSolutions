using System;

namespace CodeSignalSolutions.Solutions
{
    public class SodukuSolver
    {
        bool sudoku(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (!isValid(grid, i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        bool isValid(int[][] grid, int row, int col)
        {
            var value = grid[row][col];

            for (var i = 0; i < grid.Length; i++)
            {
                if (i == row)
                {
                    continue;
                }

                if (grid[i][col] == value)
                {

                    return false;
                }
            }

            for (var i = 0; i < grid.Length; i++)
            {
                if (grid[row][i] == value)
                {
                    if (i == col)
                    {
                        continue;
                    }


                    return false;
                }
            }

            var regionSize = (int)Math.Sqrt(grid.Length);

            var rowInRegion = row / regionSize;
            var colInRegion = col / regionSize;

            var topLeftRow = rowInRegion * regionSize;
            var topLeftCol = colInRegion * regionSize;

            for (var i = topLeftRow; i < topLeftRow + 3; i++)
            {
                for (var j = topLeftCol; j < topLeftCol + 3; j++)
                {
                    if (i == row && j == col)
                    {
                        continue;
                    }

                    if (grid[i][j] == value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}