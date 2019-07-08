namespace CodeSignalSolutions.Solutions
{
    public class DayOfWeek
    {
        int dayOfWeek(string birthdayDate)
        {
            string[] date = birthdayDate.Split("-");
            DateTime d = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[0]), Convert.ToInt32(date[1]));
            DayOfWeek dayOfWeek = d.DayOfWeek;

            return GetNextYear(d, dayOfWeek) - d.Year;
        }

        int GetNextYear(DateTime date, DayOfWeek dayOfWeek)
        {
            var yearsToAdd = 1;
            if (date.Month == 2 && date.Day == 29)
            {
                yearsToAdd = 4;
            }

            date = date.AddYears(yearsToAdd);
            bool isAdjusted = false;
            while (date.DayOfWeek != dayOfWeek)
            {
                date = date.AddYears(yearsToAdd);
                Console.WriteLine($"The year {date.Year} the day of week {date.DayOfWeek}");
                if (date.Year > 2100 && !isAdjusted)
                {
                    isAdjusted = true;
                    date = date.AddDays(1);
                }
            }

            return date.Year;
        }

    }
}