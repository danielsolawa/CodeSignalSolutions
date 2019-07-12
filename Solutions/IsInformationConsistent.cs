namespace CodeSignalSolutions.Solutions
{
    public class IsInformationConsistent
    {
        bool isInformationConsistent(int[][] evidences)
        {
            for (var j = 0; j < evidences[0].Length; j++)
            {
                var first = int.MinValue;
                for (var i = 0; i < evidences.Length; i++)
                {
                    var current = evidences[i][j];
                    if (current == 0)
                        continue;

                    if (first == int.MinValue)
                    {
                        first = current;
                    }
                    else if (first != current)
                    {
                        return false;
                    }

                }
            }

            return true;
        }
    }
}