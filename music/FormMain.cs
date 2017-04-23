using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
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

        public void button1_Click( object sender , EventArgs e )
        {
            MessageBox.Show( "網路連線中斷!請開啟網路連線後再重新啟動程式!" );
            new Music().Upload();
        }

        public void button2_Click( object sender , EventArgs e )
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add( "IU.mp3" );
            this.ShowInTaskbar = false;
            this.Hide();
        }

        public void comboBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            musicPlayer.URL = "http://mysyu.ddns.net/UploadMusic/" + comboBox1.SelectedItem;
            musicPlayer.Ctlcontrols.stop();
        }

        public void timer1_Tick( object sender , EventArgs e )
        {
            label1.Text = musicPlayer.Ctlcontrols.currentPositionString;
        }

        public void button4_Click( object sender , EventArgs e )
        {
            foreach ( String line in textBox1.Text.Split( '\n' ) )
                listBox1.Items.Add( line );
            listBox1.SelectedIndex = 0;
        }

        public void button3_Click( object sender , EventArgs e )
        {
            int select = listBox1.SelectedIndex;
            String now = "[" + musicPlayer.Ctlcontrols.currentPositionString + "] " + listBox1.SelectedItem;
            listBox1.Items.RemoveAt( select );
            listBox1.Items.Insert( select , now );
            listBox1.SelectedIndex = ( select + 1 ) % listBox1.Items.Count;
        }

        public void Form1_FormClosing( object sender , FormClosingEventArgs e )
        {
            if( DB.Connect )
                DB.Close();
        }
        public void button5_Click(object sender, EventArgs e)
        {
            String tmp="";
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                tmp =tmp+listBox1.Items[i].ToString()+"\n";
            }
            new Lyrics(tmp);
            MessageBox.Show("Success");
        }

        public void refreshPlaylist()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add( "本機" );
            foreach ( String l in PlayList.local.Keys )
            {
                treeView1.Nodes[ 0 ].Nodes.Add( l );
            }
            if ( Account.islogin )
            {
                treeView1.Nodes.Add( Account.email );
                foreach ( String l in PlayList.account.Keys )
                {
                    treeView1.Nodes[ 0 ].Nodes.Add( l );
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
        }

        private void FormMain_Shown( object sender , EventArgs e )
        {
            timer1.Start();
            network_Detect.Start();
            refreshPlaylist();
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
    }
}
