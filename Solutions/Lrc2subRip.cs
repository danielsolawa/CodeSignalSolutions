using System;
using System.Collections.Generic;

namespace CodeSignalSolutions.Solutions
{
    public class Lrc2subRip
    {
        string[] lrc2subRip(string[] lrcLyrics, string songLength)
        {
            List<string> list = new List<string>();
            songLength = songLength + ",000";


            for (var i = 0; i < lrcLyrics.Length; i++)
            {
                string songStart = GetValidTime(lrcLyrics[i].Substring(1, 8));
                string title = lrcLyrics[i].Substring(10).TrimStart();

                list.Add((i + 1).ToString());
                if (i == lrcLyrics.Length - 1)
                {
                    list.Add($"{songStart} --> {songLength}");
                    list.Add(title);
                }
                else
                {
                    string nextSongStart = GetValidTime(lrcLyrics[i + 1].Substring(1, 8));
                    list.Add($"{songStart} --> {nextSongStart}");
                    list.Add(title);
                    list.Add("");
                }

            }

            return list.ToArray();
        }


        string GetValidTime(string time)
        {
            var hour = Convert.ToInt32(time.Substring(0, 2));
            if (hour > 60)
            {
                var minutes = hour - 60 < 10 ? $"0{hour - 60}" : $"{hour - 60}";
                return $"01:{minutes}{time.Substring(2, 3)},{time.Substring(6)}0";
            }

            return $"00:{time.Substring(0, 2)}{time.Substring(2, 3)},{time.Substring(6)}0";
        }



    }
}