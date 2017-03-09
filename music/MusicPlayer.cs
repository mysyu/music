using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Media;
using NAudio.Wave;
using WMPLib;

namespace music
{
    public partial class MusicPlayer : UserControl
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        public void Upload()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "audio files ( *.wav , *.mp3 )|*.wav;*.mp3";
            openFileDialog.FilterIndex = 1;
            Stream musicStream = null;
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    if ( ( musicStream = openFileDialog.OpenFile() ) != null )
                    {
                        using ( musicStream )
                        {
                            {
                                FtpWebRequest request = (FtpWebRequest) WebRequest.Create( "ftp://1.34.30.96:21/" + Path.GetFileName( openFileDialog.FileName ) );
                                request.Method = WebRequestMethods.Ftp.UploadFile;
                                request.Credentials = new NetworkCredential( "UploadMusic" , "UploadMusic" );

                                using ( Stream requestStream = request.GetRequestStream() )
                                {
                                    musicStream.CopyTo( requestStream );
                                }

                                using ( FtpWebResponse response = (FtpWebResponse) request.GetResponse() )
                                {
                                    MessageBox.Show( "Upload File Complete, status " + response.StatusDescription );
                                }
                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }
        private void button1_Click( object sender , EventArgs e )
        {
            try
            {
                WindowsMediaPlayer music = new WindowsMediaPlayer();
                music.URL = "http://mysyu.ddns.net/UploadMusic/IU.mp3";
                trackBar1.Maximum = (int)music.currentMedia.duration;
                trackBar1.Enabled = true;
                music.controls.play();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

    }
}
