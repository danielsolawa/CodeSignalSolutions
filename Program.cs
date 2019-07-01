using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a2", "a1" };
            Array.Sort(arr);

            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }




    }
}
