namespace CodeSignalSolutions.Solutions
{
    public class AllKnightMoves
    {
        int chessKnightMoves(string c)
        {
            int[][] allKnightMoves = new int[8][]
            {
                new int[]{-2, 1}, new int[]{-1, 2}, new int[]{1, 2}, new int[]{2, 1},
                new int[]{-2, -1}, new int[]{-1, -2}, new int[]{1, -2}, new int[]{2, -1}
            };

            int[] knightPosition = GetNumPosition(c);

            var count = 0;
            for (var i = 0; i < allKnightMoves.Length; i++)
            {
                var row = knightPosition[0] + allKnightMoves[i][0];
                var cell = knightPosition[1] + allKnightMoves[i][1];
                if (IsInBounds(row, cell))
                {
                    count++;
                }
            }

            return count;
        }



        int[] GetNumPosition(string pos)
        {
            return new int[] { (int)pos[0] - 'a' + 1, (int)pos[1] - '0' };
        }


        bool IsInBounds(int row, int cell)
        {
            return row > 0 && row <= 8 && cell > 0 && cell <= 8;
        }

    }
}