using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class BoxBlur
    {
        int[][] boxBlur(int[][] image)
        {
            List<List<int>> list = new List<List<int>>();

            for (var i = 2; i < image.Length; i++)
            {
                List<int> tempList = new List<int>();
                for (var j = 2; j < image[i].Length; j++)
                {
                    tempList.Add(countAverage(image, i, j));
                }
                list.Add(tempList);
            }

            int[][] result = new int[list.Count][];

            for (var i = 0; i < list.Count; i++)
            {
                result[i] = list[i].ToArray();
            }

            return result;
        }


        int countAverage(int[][] image, int row, int col)
        {
            var count = 0;
            for (var i = row - 2; i <= row; i++)
            {
                for (var j = col - 2; j <= col; j++)
                {
                    count += image[i][j];
                }
            }

            return count / 9;
        }

    }
}