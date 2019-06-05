using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class DomainType
    {
        string[] domainType(string[] domains)
        {
            List<string> list = new List<string>();

            for (var i = 0; i < domains.Length; i++)
            {
                string[] arr = domains[i].Split(".");
                if (arr[arr.Length - 1] == "org")
                {
                    list.Add("organization");
                }
                else if (arr[arr.Length - 1] == "net")
                {
                    list.Add("network");
                }
                else if (arr[arr.Length - 1] == "com")
                {
                    list.Add("commercial");
                }
                else
                {
                    list.Add("information");
                }

            }

            return list.ToArray();
        }
    }
}