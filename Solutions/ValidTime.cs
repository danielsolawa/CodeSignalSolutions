using System;

namespace CodeSignalSolutions.Solutions
{
    public class ValidTime
    {
        bool validTime(string time)
        {
            string[] splited = time.Split(":");
            var hours = Convert.ToInt32(splited[0]);
            var minutes = Convert.ToInt32(splited[1]);

            return hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60;
        }
    }
}