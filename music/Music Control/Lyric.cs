using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using System.Globalization;

namespace music.Music_Control
{
    class Lyric
    {
        String total="10:00";
        private DateTime time;
        private String words;
        public Lyric(String t,String w)
        {
            this.time = DateTime.ParseExact(t, "mm:ss", CultureInfo.InvariantCulture);
            this.words = w;
        }
        public DateTime gettime()
        {
            return time;
        }
        public String getwords()
        {
            return words;
        }
        public void settime(String t)
        {
            this.time = DateTime.ParseExact(t, "mm:ss", CultureInfo.InvariantCulture);
        }
        public void setword(String w)
        {
            this.words = w;
        }
       public bool checkvaild(ListBox.ObjectCollection tmplyric)
        {
            DateTime totaltime = DateTime.ParseExact(total, "mm:ss", CultureInfo.InvariantCulture);
           for(int i=0; i<tmplyric.Count;i++)
            {
                DateTime currnttime = DateTime.ParseExact(tmplyric[i].ToString().Substring(1,5), "mm:ss", CultureInfo.InvariantCulture);
                if (currnttime > totaltime)
                    return false;
            }
            return true;
        }
    }
}
