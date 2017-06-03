using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class FormMusicList : Form
    {
        public FormMusicList()
        {
            InitializeComponent();
        }

        public void Set( List<Music> musiclist , bool current )
        {
            musicList.Columns[ 8 ].Visible = current;
            musicList.Rows.Clear();
            if ( musiclist == null )
                return;
            for ( int i = 0 ; i < musiclist.Count ; i++ )
            {
                musicList.Rows.Add( 1 );
                musicList.Rows[ i ].Cells[ 0 ].Value = musiclist[ i ];
                musicList.Rows[ i ].Cells[ 1 ].Value = ( (Music) musicList.Rows[ i ].Cells[ 0 ].Value ).singer;
            }
        }

        private void musicList_CellContentClick( object sender , DataGridViewCellEventArgs e )
        {
            switch ( e.ColumnIndex )
            {
                case 2:
                    FormMusicInfo formMusicInfo = new FormMusicInfo();
                    formMusicInfo.TopLevel = false;
                    formMusicInfo.Dock = DockStyle.Fill;
                    formMusicInfo.FormBorderStyle = FormBorderStyle.None;
                    FormMain.main.mainPanel.Controls.Add( formMusicInfo );
                    formMusicInfo.BringToFront();
                    formMusicInfo.Set( (Music) musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value );
                    formMusicInfo.Show();
                    break;
                case 3:
                    FormMusicSinger formMusicSinger = new FormMusicSinger();
                    formMusicSinger.TopLevel = false;
                    formMusicSinger.Dock = DockStyle.Fill;
                    formMusicSinger.FormBorderStyle = FormBorderStyle.None;
                    FormMain.main.mainPanel.Controls.Add( formMusicSinger );
                    formMusicSinger.BringToFront();
                    formMusicSinger.Set( new Account( (Music) musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value ) );
                    formMusicSinger.Show();
                    break;
                case 4:
                    MusicList.add( (Music)  musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value , false );
                    break;
                case 5:
                    MusicList.add( "local" , (Music) musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value );
                    FormMain.main.refreshMusiclist();
                    break;
                case 6:
                    MusicList.add( "account" , (Music) musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value );
                    FormMain.main.refreshMusiclist();
                    break;
                case 7:
                    MusicList.add( (Music) musicList.Rows[ e.RowIndex ].Cells[ 0 ].Value , true );
                    MusicList.time = "00:00";
                    FormMain.main.musicPlayer.URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , MusicList.current[ MusicList.pos ].ID , MusicList.current[ MusicList.pos ].extension );
                    MusicList.current[ MusicList.pos ].Play();
                    break;
                case 8:
                    MusicList.current.RemoveAt( e.RowIndex );
                    musicList.Rows.RemoveAt( e.RowIndex );
                    if ( MusicList.current.Count == 0 )
                    {
                        MusicList.pos = -1;
                        FormMain.main.musicPlayer.Ctlcontrols.stop();
                        FormMain.main.musicPlayer.currentPlaylist.clear();
                    }
                    else if ( e.RowIndex == MusicList.pos )
                    {
                        MusicList.pos %= MusicList.current.Count;
                        MusicList.time = "00:00";
                        FormMain.main.musicPlayer.URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , MusicList.current[ MusicList.pos ].ID , MusicList.current[ MusicList.pos ].extension );
                        MusicList.current[ MusicList.pos ].Play();
                    }
                    break;

            }
        }

        private void CheckedChanged( object sender , EventArgs e )
        {
            String command = "Select ID from uploadmusic where 1 = 0";
            foreach ( CheckBox c in tag.Controls.OfType<CheckBox>().Where( r => r.Checked ) )
                command += String.Format( " or tag like '%{0}%'" , c.Text );
            Set( MusicList.search( command ) , false );
        }

        private void checkLogin_Tick( object sender , EventArgs e )
        {
            musicList.Columns[ 6 ].Visible = Account.islogin;
        }
    }
}
