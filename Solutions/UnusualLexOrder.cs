using System;

namespace CodeSignalSolutions.Solutions
{
    public class UnusualLexOrder
    {
        string[] unusualLexOrder(string[] words)
        {

            Array.Sort(words, (c1, c2) =>
                       {

                           var rC1 = ReverseWord(c1);
                           var rC2 = ReverseWord(c2);

                           return rC1.CompareTo(rC2);

                       });


            return words;
        }

        string ReverseWord(string word)
        {
            var r = "";
            for (var i = word.Length - 1; i >= 0; i--)
            {
                r += word[i];
            }

            return r;
        }
    }
}