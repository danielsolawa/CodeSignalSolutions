namespace CodeSignalSolutions.Solutions
{
    public class DrawRectangle
    {
        char[][] drawRectangle(char[][] canvas, int[] rectangle)
        {
            int[] topLeftCorner = new int[] { rectangle[0], rectangle[1] };
            int[] topRightCorner = new int[] { rectangle[2], rectangle[1] };
            int[] bottomRightCorner = new int[] { rectangle[2], rectangle[3] };
            int[] bottomLeftCorner = new int[] { rectangle[0], rectangle[3] };

            canvas[topLeftCorner[1]][topLeftCorner[0]] = '*';
            canvas[topRightCorner[1]][topRightCorner[0]] = '*';
            canvas[bottomRightCorner[1]][bottomRightCorner[0]] = '*';
            canvas[bottomLeftCorner[1]][bottomLeftCorner[0]] = '*';

            for (var i = topLeftCorner[0] + 1; i < topRightCorner[0]; i++)
            {
                canvas[topLeftCorner[1]][i] = '-';
                canvas[bottomLeftCorner[1]][i] = '-';
            }

            for (var i = topLeftCorner[1] + 1; i < bottomRightCorner[1]; i++)
            {
                canvas[i][topLeftCorner[0]] = '|';
                canvas[i][topRightCorner[0]] = '|';
            }


            return canvas;
        }
    }
}