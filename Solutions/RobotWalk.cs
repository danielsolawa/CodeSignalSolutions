using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class RobotWalk
    {
        bool robotWalk(int[] arr)
        {
            bool vertical = true;
            ISet<string> set = new HashSet<string>();
            int x = 0, y = 0;
            int xVal = 1, yVal = 1;
            set.Add($"{x}{y}");
            for (var i = 0; i < arr.Length; i++)
            {
                if (vertical)
                {
                    for (var j = 0; j < arr[i]; j++)
                    {
                        y += yVal;
                        if (y < 0)
                        {
                            y = 0;
                        }

                        if (set.Contains($"{x}{y}"))
                        {

                            return true;
                        }
                        set.Add($"{x}{y}");
                    }
                    yVal = -1 * yVal;
                }
                else
                {
                    for (var j = 0; j < arr[i]; j++)
                    {
                        x += xVal;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        if (set.Contains($"{x}{y}"))
                        {
                            return true;
                        }
                        set.Add($"{x}{y}");

                    }
                    xVal = -1 * xVal;
                }

                vertical = !vertical;
            }

            return false;
        }
    }
}