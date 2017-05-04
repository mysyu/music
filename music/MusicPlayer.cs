using System;
using AxWMPLib;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace music
{
    public partial class MusicPlayer : AxWindowsMediaPlayer
    {
        public MusicPlayer()
        {
        }

        public void Play( bool p )
        {
            URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , MusicList.current[ MusicList.pos ].ID , MusicList.current[ MusicList.pos ].extension );
            Ctlcontrols.currentPosition = Int32.Parse( MusicList.time.Substring( 0 , 2 ) ) * 60 + Int32.Parse( MusicList.time.Substring( 3 , 2 ) );
            if ( !p )
                Ctlcontrols.stop();
            else
                Ctlcontrols.play();
            FormMain.main.name.Text = String.Format( "歌曲名稱     : {0}" , MusicList.current[ MusicList.pos ].name );
            FormMain.main.singer.Text = String.Format( "創作者/團體: {0}" , MusicList.current[ MusicList.pos ].singer );
            FormMain.main.totalTime.Text = String.Format( "歌曲時間     : {0}" , currentMedia.durationString );
        }

    }
}
