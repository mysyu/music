using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
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
            timer1.Start();
            refreshPlaylist();
            Log.Debug( "start" );
            main = this;
        }

        private void button1_Click( object sender , EventArgs e )
        {
            new Music().Upload();
        }

        private void button2_Click( object sender , EventArgs e )
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add( "IU.mp3" );
        }

        private void comboBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            musicPlayer.URL = "http://mysyu.ddns.net/UploadMusic/" + comboBox1.SelectedItem;
            musicPlayer.Ctlcontrols.stop();
        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            label1.Text = musicPlayer.Ctlcontrols.currentPositionString;
        }

        private void button4_Click( object sender , EventArgs e )
        {
            foreach ( String line in textBox1.Text.Split( '\n' ) )
                listBox1.Items.Add( line );
            listBox1.SelectedIndex = 0;
        }

        private void button3_Click( object sender , EventArgs e )
        {
            int select = listBox1.SelectedIndex;
            String now = "[" + musicPlayer.Ctlcontrols.currentPositionString + "] " + listBox1.SelectedItem;
            listBox1.Items.RemoveAt( select );
            listBox1.Items.Insert( select , now );
            listBox1.SelectedIndex = ( select + 1 ) % listBox1.Items.Count;
        }

        private void Form1_FormClosing( object sender , FormClosingEventArgs e )
        {
            DB.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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
                Account.Logout();
            }
        }
    }
}
