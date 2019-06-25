using System;

namespace CodeSignalSolutions.Solutions
{
    public class BishopAndPawn
    {
        bool bishopAndPawn(string bishop, string pawn)
        {
            int[] bishopPosition = GetNumPosition(bishop);
            int[] pawnPosition = GetNumPosition(pawn);

            return Math.Abs(bishopPosition[0] - pawnPosition[0]) == Math.Abs(bishopPosition[1] - pawnPosition[1]);
        }


        int[] GetNumPosition(string pos)
        {
            return new int[] { (int)pos[0] - 'a' + 1, (int)pos[1] - '0' };
        }

    }
}