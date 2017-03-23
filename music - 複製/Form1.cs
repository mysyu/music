using System;
using System.Windows.Forms;
using music.DB_Control;
using System.Data;
using log4net;

namespace music
{
    public partial class Form1 : Form
    {
        public static ILog Log = LogManager.GetLogger( "" );

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            Log.Debug( "start" );
        }

        private void button1_Click( object sender , EventArgs e )
        {
            new MusicPlayer().Upload();
        }

        private void button2_Click( object sender , EventArgs e )
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add( "IU.mp3" );
        }

        private void comboBox1_SelectedIndexChanged( object sender , EventArgs e )
        {
            musicPlayer1.URL = "http://mysyu.ddns.net/UploadMusic/" + comboBox1.SelectedItem;
            musicPlayer1.Ctlcontrols.stop();
        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            label1.Text = musicPlayer1.Ctlcontrols.currentPositionString;
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
            String now = "[" + musicPlayer1.Ctlcontrols.currentPositionString + "] " + listBox1.SelectedItem;
            listBox1.Items.RemoveAt( select );
            listBox1.Items.Insert( select , now );
            listBox1.SelectedIndex = ( select + 1 ) % listBox1.Items.Count;
        }

        private void Form1_FormClosing( object sender , FormClosingEventArgs e )
        {
            DB.Close();
        }
    }
}
