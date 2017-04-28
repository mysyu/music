using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;
using System.Windows;
using System.Text.RegularExpressions;

namespace music
{
    public class Lyrics
    {
        public string completeLyrics;
        public List<TimeSpan> time;
        public List<String> lyrics;

        public Lyrics(String l)
        {
            completeLyrics = l;
            string pattern = Regex.Escape("[") + ":]";
            MatchCollection matches = Regex.Matches(l, pattern);
            if(matches.Count>0)
            {
                String pre = "00:00";
                foreach(String line in l.Split('\n'))
                {
                    Match match = Regex.Match(line, pattern);
                    if(match.Success)
                    {
                        lyrics.Add(line);
                        time.Add(new TimeSpan(0, int.Parse(match.Value.Substring(1, 2)), int.Parse(match.Value.Substring(4, 2))));
                        pre = match.Value.Substring(1,5);
                    }
                    else
                    {
                        lyrics.Add(line);
                        time.Add(new TimeSpan(0, int.Parse(pre.Substring(1, 2)), int.Parse(pre.Substring(4, 2))));
                    }
                }
            }
            else
            {
                foreach (String line in l.Split('\n'))
                {
                    lyrics.Add(line);
                }
            }
        }

        public String getTime(int n)
        {
            if (time.Count > 0)
            {
                return time[n].ToString().Substring(4, 5);
            }
            else
                return null;
        }

        public int getLine(TimeSpan t)
        {
            if(time.Count > 0)
            {
                for(int i=0;i<time.Count;i++)
                {
                    if(time[i]>t)
                    {
                        for(int j=i;j>=0;j--)
                        {
                            if (!String.IsNullOrWhiteSpace(lyrics[j]))
                                return j;
                        }
                        return i-1;
                    }
                }
                return time.Count - 1;
            }
            return 0;
        }
    }
}
