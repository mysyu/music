using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using WMPLib;
using System.Linq;
using log4net;



namespace music
{
    public partial class FormMain : Form
    {
        public static ILog Log = LogManager.GetLogger( "" );
        public static FormMain main = null;

        public FormMain()
        {
            InitializeComponent();
        }
        public void FormMain_Shown( object sender , EventArgs e )
        {
            main = this;
            music_Timer.Start();
            network_Detect.Start();
            MusicList.load();
            refreshMusiclist();
            if ( MusicList.pos != -1 )
            {
                musicPlayer.URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , MusicList.current[ MusicList.pos ].ID , MusicList.current[ MusicList.pos ].extension );
                musicPlayer.Ctlcontrols.currentPosition = Int32.Parse( MusicList.time.Substring( 0 , 2 ) ) * 60 + Int32.Parse( MusicList.time.Substring( 3 , 2 ) );
            }
            home_Click( null , null );
            Log.Debug( "start" );
        }
        private void home_Click( object sender , EventArgs e )
        {
            FormHome formHome = new FormHome();
            formHome.TopLevel = false;
            formHome.Dock = DockStyle.Fill;
            formHome.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formHome );
            formHome.BringToFront();
            formHome.Show();
        }
        public void formMain_FormClosing( object sender , FormClosingEventArgs e )
        {
            if ( DB.Connect )
                DB.Close();
            MusicList.time = currentTime.Text.Substring( 11 );
            MusicList.save();
        }
        private void network_Detect_Tick( object sender , EventArgs e )
        {
            if ( !NetworkInterface.GetIsNetworkAvailable() )
            {
                network_Detect.Stop();
                this.TopMost = true;
                MessageBox.Show( "網路連線中斷!請開啟網路連線後再重新啟動程式!" );
                DB.Connect = false;
                this.Close();
            }
            if ( !DB.Connect )
            {
                network_Detect.Stop();
                this.TopMost = true;
                MessageBox.Show( "資料庫無法連線" );
                this.Close();
            }
        }
        public void music_Timer_Tick( object sender , EventArgs e )
        {
            if ( MusicList.pos == -1 )
            {
                name.Text = "歌曲名稱     : ";
                singer.Text = "創作者/團體: ";
            }
            else
            {
                name.Text = String.Format( "歌曲名稱     : {0}" , MusicList.current[ MusicList.pos ].name );
                singer.Text = String.Format( "創作者/團體: {0}" , MusicList.current[ MusicList.pos ].singer );
            }
            if ( musicPlayer.Ctlcontrols.currentPositionString == "" )
                currentTime.Text = "目前時間     : 00:00";
            else
                currentTime.Text = String.Format( "目前時間     : {0}" , musicPlayer.Ctlcontrols.currentPositionString );
            if ( musicPlayer.currentMedia.durationString == "" )
                currentTime.Text = "歌曲時間     : 00:00";
            else
                totalTime.Text = String.Format( "歌曲時間     : {0}" , musicPlayer.currentMedia.durationString );
        }
        public void refreshMusiclist()
        {
            musicList.Nodes.Clear();
            musicList.Nodes.Add( "本機" );
            foreach ( Music m in MusicList.local  )
            {
                musicList.Nodes[ 0 ].Nodes.Add( m.name );
            }
            if ( Account.islogin )
            {
                musicList.Nodes.Add( account.Text );
                foreach ( Music m in MusicList.account )
                {
                    musicList.Nodes[ 1 ].Nodes.Add( m.name );
                }
            }
            musicList.ExpandAll();
        }

        private void account_Click( object sender , EventArgs e )
        {
            if ( !Account.islogin )
            {
                FormLogin formLogin = new FormLogin();
                formLogin.TopLevel = false;
                formLogin.Dock = DockStyle.Fill;
                formLogin.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add( formLogin );
                formLogin.BringToFront();
                formLogin.Show();
            }
            else
            {
                account_Option.Show( account , new Point( account.Width - account_Option.Width , account.Height ) );
            }
        }

        private void account_Info_Click( object sender , EventArgs e )
        {
            FormAccountInfo formAccountInfo = new FormAccountInfo();
            formAccountInfo.TopLevel = false;
            formAccountInfo.Dock = DockStyle.Fill;
            formAccountInfo.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add(formAccountInfo);
            formAccountInfo.BringToFront();
            formAccountInfo.Show();
        }

        private void account_music_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();
            formMusicList.Set( MusicList.search( String.Format( "select ID from uploadmusic where email = '{0}'" , Account.user.email ) ) );
            formMusicList.tag.Visible = false;
            formMusicList.Show();
        }
        private void upload_Click( object sender , EventArgs e )
        {
            FormMusicUpload formMusicUpload = new FormMusicUpload();
            formMusicUpload.TopLevel = false;
            formMusicUpload.Dock = DockStyle.Fill;
            formMusicUpload.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicUpload );
            formMusicUpload.BringToFront();
            formMusicUpload.Show();
        }
        private void modify_Click( object sender , EventArgs e )
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.TopLevel = false;
            formChangePassword.Dock = DockStyle.Fill;
            formChangePassword.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formChangePassword );
            formChangePassword.BringToFront();
            formChangePassword.Show();
        }
        private void logout_Click( object sender , EventArgs e )
        {
            Account.Logout();
            account.Text = "登入";
            MusicList.account.Clear();
            refreshMusiclist();
        }
        private void list_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();
            formMusicList.Set( MusicList.current );
            formMusicList.tag.Visible = false;
            formMusicList.Show();
        }

        private void lyrics_Click( object sender , EventArgs e )
        {
            if ( MusicList.current.Count > 0 )
            {
                FormMusicLyrics formMusicLyrics = new FormMusicLyrics();
                formMusicLyrics.TopLevel = false;
                formMusicLyrics.Dock = DockStyle.Fill;
                formMusicLyrics.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add( formMusicLyrics );
                formMusicLyrics.BringToFront();
                formMusicLyrics.Set( MusicList.current[ MusicList.pos ] );
                formMusicLyrics.Show();
            }
        }

        private void button6_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicList );
            formMusicList.tag.Visible = false;
            formMusicList.BringToFront();
            formMusicList.Show();
        }
        private void musicPlayer_PlayStateChange( object sender , AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e )
        {
            Log.Debug( e.newState );
            if ( e.newState == 10 )
            {
                try
                {
                    musicPlayer.Ctlcontrols.play();
                }
                catch
                {
                }
            }
            else if ( e.newState == 8 )
            {
                MusicList.pos = ( MusicList.pos + 1 ) % MusicList.current.Count;
                musicPlayer.URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , MusicList.current[ MusicList.pos ].ID , MusicList.current[ MusicList.pos ].extension );
            }
        }
        private void searchButton_Click( object sender , EventArgs e )
        {
            if ( search.Text != "" )
            {
                FormMusicList formMusicList = new FormMusicList();
                formMusicList.TopLevel = false;
                formMusicList.Dock = DockStyle.Fill;
                formMusicList.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add( formMusicList );
                formMusicList.BringToFront();
                formMusicList.Set( MusicList.search( String.Format( "Select ID from uploadmusic where name like '%{0}%' or singer like '%{0}%'" , search.Text ) ) );
                formMusicList.tag.Visible = false;
                formMusicList.Show();
            }
        }
        private void search_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                searchButton_Click( null , null );
        }
        private void notifyIcon_MouseDoubleClick( object sender , MouseEventArgs e )
        {
            this.ShowInTaskbar = true;
            this.TopMost = true;
            this.Show();
        }

    }
}
