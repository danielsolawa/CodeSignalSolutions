using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = "2016-08-26 22:40";
            var d1 = "2016-08-29 10:00";


            DateTime someTime = GetDateTime(d);
            DateTime leavingTime = GetDateTime(d1);

            someTime = someTime.AddYears(-1 * (leavingTime.Year - someTime.Year));
            someTime = someTime.AddMonths(-1 * (leavingTime.Month - someTime.Month));
            someTime = someTime.AddDays(-1 * (leavingTime.Day - someTime.Day));

            someTime = someTime.AddHours(-1 * (leavingTime.Hour - someTime.Hour));
            someTime = someTime.AddMinutes(-1 * (leavingTime.Minute - someTime.Minute));

        }


        static DateTime GetDateTime(string d)
        {
            string[] dateTime = d.Split(" ");
            string[] date = dateTime[0].Split("-");
            string[] time = dateTime[1].Split(":");

            return new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]),
                                        Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), 0);

        }

        static string GetDateAsString(DateTime d)
        {
            return $"{d.Year}-{d.Month}-{d.Day} {d.Hour}:{d.Minute}";
        }


    }
}