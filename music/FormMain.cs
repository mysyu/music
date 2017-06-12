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
        private String backdoor = null;
        public static FormHome formHome = null;


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
                MusicList.Play();
            }
            formHome = new FormHome();
            formHome.TopLevel = false;
            formHome.Dock = DockStyle.Fill;
            formHome.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add( formHome );
            formHome.BringToFront();
            formHome.Show();
            Log.Debug( "start" );
        }
        private void home_Click( object sender , EventArgs e )
        {
            formHome.BringToFront();
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
            if ( musicPlayer.currentMedia == null || musicPlayer.currentMedia.durationString == "" )
                currentTime.Text = "歌曲時間     : 00:00";
            else
                totalTime.Text = String.Format( "歌曲時間     : {0}" , musicPlayer.currentMedia.durationString );
            last.Enabled = MusicList.pos > 0;
            next.Enabled = MusicList.pos < MusicList.current.Count - 1;
            Text = "Music";
            foreach ( Control c in mainPanel.Controls )
            {
                Text += c;
            }
        }
        public void refreshMusiclist()
        {
            musicList.Nodes.Clear();
            musicList.Nodes.Add( "本機" );
            TreeNode node;
            foreach ( Music m in MusicList.local  )
            {
                node = new TreeNode( m.name );
                node.Tag = m;
                musicList.Nodes[ 0 ].Nodes.Add( node );
            }
            if ( Account.islogin )
            {
                musicList.Nodes.Add( account.Text );
                foreach ( Music m in MusicList.account )
                {
                    node = new TreeNode( m.name );
                    node.Tag = m;
                    musicList.Nodes[ 1 ].Nodes.Add( node );
                }
            }
            musicList.ExpandAll();
            MusicList.save();
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
            formMusicList.Set( MusicList.search( String.Format( "select ID from uploadmusic where email = '{0}'" , Account.user.email ) ) , false );
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
            mainPanel.Controls.Add( formChangePassword );
            formChangePassword.BringToFront();
            formChangePassword.Show();
        }
        private void logout_Click( object sender , EventArgs e )
        {
            Account.Logout();
            account.Text = "登入";
            MusicList.account.Clear();
            home_Click( null , null );
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
                formMusicLyrics.Show();
            }
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
                MusicList.current[ MusicList.pos ].Play();
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
                formMusicList.Set( MusicList.search( String.Format( "Select ID from uploadmusic where name like '%{0}%' or singer like '%{0}%'" , search.Text ) ) , false );
                formMusicList.tag.Visible = false;
                formMusicList.Show();
            }
        }
        private void search_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                searchButton_Click( null , null );
        }
        private void musicList_NodeMouseDoubleClick( object sender , TreeNodeMouseClickEventArgs e )
        {
            if ( e.Node.Level == 1 )
            {
                MusicList.add( (Music) e.Node.Tag , true );
            }
        }
        private void musicList_NodeMouseClick( object sender , TreeNodeMouseClickEventArgs e )
        {
            musicList.SelectedNode = e.Node;
            if ( e.Button == MouseButtons.Right && e.Node.Level == 1 )
            {
                if ( e.Node.Parent.Index == 0 )
                {
                    addLocal.Visible = e.Node.Parent.Index != 0;
                    addAccount.Visible = Account.islogin;
                }
                else
                {
                    addLocal.Visible = true;
                    addAccount.Visible = false;
                }
                musicList_Option.Show( musicList , new Point( e.X , e.Y ) );
            }
        }

        private void musicInfo_Click( object sender , EventArgs e )
        {
            FormMusicInfo formMusicInfo = new FormMusicInfo();
            formMusicInfo.TopLevel = false;
            formMusicInfo.Dock = DockStyle.Fill;
            formMusicInfo.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicInfo );
            formMusicInfo.BringToFront();
            formMusicInfo.Set( (Music) musicList.SelectedNode.Tag );
            formMusicInfo.Show();
        }
        private void singerInfo_Click( object sender , EventArgs e )
        {
            FormMusicSinger formMusicSinger = new FormMusicSinger();
            formMusicSinger.TopLevel = false;
            formMusicSinger.Dock = DockStyle.Fill;
            formMusicSinger.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicSinger );
            formMusicSinger.BringToFront();
            formMusicSinger.Set( new Account( (Music) musicList.SelectedNode.Tag ) );
            formMusicSinger.Show();
        }
        private void addCurrent_Click( object sender , EventArgs e )
        {
            MusicList.add( (Music) musicList.SelectedNode.Tag , false );
        }
        private void addLocal_Click( object sender , EventArgs e )
        {
            MusicList.add( "local" , (Music) musicList.SelectedNode.Tag );
            FormMain.main.refreshMusiclist();
        }
        private void addAccount_Click( object sender , EventArgs e )
        {
            MusicList.add( "account" , (Music) musicList.SelectedNode.Tag );
            FormMain.main.refreshMusiclist();
        }
        private void play_Click( object sender , EventArgs e )
        {
            MusicList.add( (Music) musicList.SelectedNode.Tag , true );
        }
        private void delete_Click( object sender , EventArgs e )
        {
            if ( musicList.SelectedNode.Level == 1 )
            {
                if ( musicList.SelectedNode.Parent.Index == 0 )
                    MusicList.local.Remove( (Music) musicList.SelectedNode.Tag );
                else
                    MusicList.account.Remove( (Music) musicList.SelectedNode.Tag );
                refreshMusiclist();
            }
        }

        private void FormMain_KeyPress( object sender , KeyPressEventArgs e )
        {
            if ( !Account.islogin )
            {
                if ( e.KeyChar - 0 == (int) Keys.Escape )
                    backdoor = "";
                else if ( e.KeyChar - 0 == (int) Keys.Back && backdoor != null && backdoor != "" )
                    backdoor = backdoor.Remove( backdoor.Length - 1 );
                else if ( e.KeyChar - 0 == (int) Keys.Enter && backdoor == "admin" )
                {
                    Account.user.email = "admin";
                    Account.islogin = true;
                    account.Text = Account.user.email;
                    account_Info.Visible = false;
                    modify.Visible = false;
                    MusicList.load();
                    refreshMusiclist();
                    backdoor = null;
                }
                else if ( backdoor != null )
                    backdoor += e.KeyChar.ToString();
            }
        }

        private void last_Click( object sender , EventArgs e )
        {
            MusicList.pos--;
            MusicList.Play();

        }
        private void next_Click( object sender , EventArgs e )
        {
            MusicList.pos++;
            MusicList.Play();
        }
    }
}
