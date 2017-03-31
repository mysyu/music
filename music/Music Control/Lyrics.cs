using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;
using System.Windows;

namespace music.Music_Control
{
    class Lyrics
    {
        public Lyrics(String line)
        {   try
            {
                complete = line.Replace("\r", "");
                foreach (String l in complete.Split('\n'))
                {
                    if (!(String.IsNullOrWhiteSpace(l)))
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
                    else
                    {
                        if(this.time.Count <= 0)
                        {
                            throw new Exception("First line cannot be space");
                        }
                        DateTime t = this.time[this.time.Count - 1];
                        String w = "";
                        this.words.Add(w);
                        this.time.Add(t);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
        public String getTime(int n)
        {
            try
            {
                if (n > this.time.Count)
                    throw new Exception("The number is out of range");
                return this.time[n - 1].ToString("mm:ss");
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
        public int getLine(DateTime t)
        {   try
            {
                int line=0;
                if (t > this.time[this.time.Count-1])
                    throw new Exception("The time is out of range");
                for (int i = 0; i < this.time.Count; i++)
                {
                    if (this.time[i] > t)
                    {
                        if (this.words[i] != "")
                            line = i + 1;
                        else
                        {
                            for(int j=i-1;j>0;j--)
                            {
                                if(this.words[j]!="")
                                {
                                    line = j + 1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                return line;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
        private String complete;
        private List<DateTime> time=new List<DateTime>();
        private List<String> words=new List<String>();
    }
}
