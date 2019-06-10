namespace CodeSignalSolutions.Solutions
{
    public class LookAndSay
    {
        string lookAndSaySequenceNextElement(string element)
        {


            if (element == "1")
            {
                return "11";
            }

            var result = "";
            var current = 'a';
            var count = 0;

            for (var i = 0; i < element.Length; i++)
            {
                if (i == 0 || element[i] == current)
                {
                    current = element[i];
                    count++;
                }
                else
                {
                    result += $"{count}{current}";
                    count = 1;
                    current = element[i]; ;
                }

            }

            result += $"{count}{current}";


            return result;
        }
    }
}