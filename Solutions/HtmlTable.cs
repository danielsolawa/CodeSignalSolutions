namespace CodeSignalSolutions.Solutions
{
    public class HtmlTable
    {
        string htmlTable(string table, int row, int column)
        {
            string[] rows = table.Split("</tr>");
            if (rows.Length - 2 < row)
            {
                return "No such cell";
            }

            string[] cells = rows[row].Split("</td>");

            if (cells.Length - 1 < column)
            {
                return "No such cell";
            }



            return string.IsNullOrEmpty(cells[column]) ? "No such cell" : ExtractValue(cells[column]);
        }


        string ExtractValue(string cell)
        {
            var result = "";
            for (var i = cell.Length - 1; i >= 0; i--)
            {
                if (cell[i] == '>')
                {
                    break;
                }

                result = cell[i] + result;
            }
            return result;
        }

    }
}