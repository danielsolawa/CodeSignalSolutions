using System;

namespace CodeSignalSolutions.Solutions
{
    public class BishopDiagonal
    {
        string[] bishopDiagonal(string bishop1, string bishop2)
        {
            int[] b1 = GetNumPosition(bishop1);
            int[] b2 = GetNumPosition(bishop2);

            if (!IsSameDiagonal(b1, b2))
            {
                string[] a = new string[] { bishop1, bishop2 };
                Array.Sort(a);
                return a;
            }

            int[][] directions = new int[4][] {new int[]{1, 1}, new int[]{-1, -1},
                                       new int[]{-1, 1}, new int[]{1, -1}};
            int[] b1Direction = new int[1];
            int[] b2Direction = new int[1];

            if (b1[1] > b2[1])
            {
                if (b1[0] > b2[0])
                {
                    b1Direction = directions[0];
                    b2Direction = directions[1];
                }
                else
                {
                    b1Direction = directions[2];
                    b2Direction = directions[3];
                }


            }
            else
            {
                if (b1[0] > b2[0])
                {
                    b1Direction = directions[3];
                    b2Direction = directions[2];
                }
                else
                {

                    b1Direction = directions[1];
                    b2Direction = directions[0];
                }

            }

            while (IsInBounds(b1[0] + b1Direction[0], b1[1] + b1Direction[1]))
            {

                b1[0] += b1Direction[0];
                b1[1] += b1Direction[1];

            }

            while (IsInBounds(b2[0] + b2Direction[0], b2[1] + b2Direction[1]))
            {
                b2[0] += b2Direction[0];
                b2[1] += b2Direction[1];

            }

            string[] result = new string[] { ToLetter(b1[0], b1[1]), ToLetter(b2[0], b2[1]) };
            Array.Sort(result);

            return result;
        }

        int[] GetNumPosition(string pos)
        {
            return new int[] { (int)pos[0] - 'a' + 1, (int)pos[1] - '0' };
        }

        string ToLetter(int b1, int b2)
        {
            return new string($"{(char)(b1 + 'a' - 1)}{b2}");
        }

        bool IsInBounds(int b1, int b2)
        {
            return b1 > 0 && b1 <= 8 && b2 > 0 && b2 <= 8;
        }


        bool IsSameDiagonal(int[] b1, int[] b2)
        {
            return Math.Abs(b1[0] - b2[0]) == Math.Abs(b1[1] - b2[1]);
        }
    }
}