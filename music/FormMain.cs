using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
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
        public void timer1_Tick( object sender , EventArgs e )
        {
            if( musicPlayer.Ctlcontrols.currentPositionString == "" )
                currentTime.Text = "目前時間     : 00:00";
            else
                currentTime.Text = String.Format( "目前時間     : {0}" , musicPlayer.Ctlcontrols.currentPositionString );
        }

        public void button4_Click( object sender , EventArgs e )
        {
            FormMusicUpload formMusicUpload = new FormMusicUpload();
            formMusicUpload.TopLevel = false;
            formMusicUpload.Dock = DockStyle.Fill;
            formMusicUpload.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(formMusicUpload);
            formMusicUpload.BringToFront();
            formMusicUpload.Show();
        }

        public void formMain_FormClosing( object sender , FormClosingEventArgs e )
        {
            if( DB.Connect )
                DB.Close();
            MusicList.save();
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
                    musicList.Nodes[ 0 ].Nodes.Add( m.name );
                }
            }
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

        private void notifyIcon_MouseDoubleClick( object sender , MouseEventArgs e )
        {
            this.ShowInTaskbar = true;
            this.TopMost = true;
            this.Show();
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
            refreshMusiclist();
        }

        private void FormMain_Shown( object sender , EventArgs e )
        {
            timer1.Start();
            network_Detect.Start();
            MusicList.load();
            refreshMusiclist();
            Log.Debug( "start" );
            main = this;
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
        private void list_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();
            formMusicList.Set( MusicList.current );
            formMusicList.Show();
        }

        private void lyrics_Click( object sender , EventArgs e )
        {
            FormMusicLyrics formMusicLyrics = new FormMusicLyrics();
            formMusicLyrics.TopLevel = false;
            formMusicLyrics.Dock = DockStyle.Fill;
            formMusicLyrics.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicLyrics );
            formMusicLyrics.BringToFront();
            formMusicLyrics.Set( MusicList.current[0] );
            formMusicLyrics.Show();
        }

        private void button6_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();
            formMusicList.Show();
        }
    }
}
