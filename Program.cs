using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "<table><tr><td>1</td><td>TWO</td></tr><tr><td>three</td><td>FoUr4</td></tr></table>";

            string[] split = s.Split("</tr>");
            string[] cells = split[0].Split("</td>");
            foreach (var s1 in cells)
            {
                Console.WriteLine($"{s1}");
            }

        }
    }
}