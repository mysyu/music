using System;
using AxWMPLib;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Data;

namespace music
{
    public class Music
    {
        public String ID;
        public String name;
        public String singer;
        public String tag;
        public String info;
        public Lyrics lyrics;

        public Music()
        {
            ID = "";
            name = "";
            singer = "";
            tag = "";
            info = "";
            lyrics = new Lyrics("");
        }

        public Music(String id)
        {
            DataTable result = DB.Select(String.Format("select name , singer , tag , info from uploadmusic where ID = '{0}'", id));
            if (result.Rows.Count == 1)
            {
                ID = id;
                name = result.Rows[0][0].ToString();
                singer = result.Rows[0][1].ToString();
                tag = result.Rows[0][2].ToString();
                tag = result.Rows[0][3].ToString();
            }
        }

        public Music( String n , String s , String t , String i , String l )
        {
            ID = "";
            name = n;
            singer = s;
            tag = t;
            info = i;
            lyrics = new Lyrics(l);
        }

        public String Upload( String filename )
        {
            try
            {
                using ( Stream musicStream = new FileStream(filename, FileMode.Open))
                {
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://1.34.30.96:21/" + Path.GetFileName(filename));
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.Credentials = new NetworkCredential("UploadMusic", "UploadMusic");

                        using (Stream requestStream = request.GetRequestStream())
                        {
                            musicStream.CopyTo(requestStream);
                        }

                        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        {
                            return "Upload File Complete, status " + response.StatusDescription;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "Fail";
        }
    }

}