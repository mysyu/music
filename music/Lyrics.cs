using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;
using System.Windows;

namespace music
{
    class Lyrics
    {
        public Lyrics(String line)
        {   try
            {
                complete = line.Replace("\r", "");
                foreach (String l in complete.Split('\n'))
                {
                    if (l != "")
                    {
                        DateTime t = DateTime.ParseExact(l.Substring(1, 5), "mm:ss", CultureInfo.InvariantCulture);
                        String w = l.Substring(7); 
                        if (this.time.Count > 0)
                        {
                            if (t < time[time.Count - 1])
                            {
                                throw new Exception("Lyric should be set according to time");
                            }
                        }
                        this.words.Add(w);
                        this.time.Add(t);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private String complete;
        private List<DateTime> time=new List<DateTime>();
        private List<String> words=new List<String>();
    }
}
