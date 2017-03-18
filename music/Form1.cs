using System;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;

namespace music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click( object sender , EventArgs e )
        {
            new MusicPlayer().Upload();
        }

        private void button2_Click( object sender , EventArgs e )
        {
            comboBox1.Items.Clear();
            foreach ( string file in Directory.GetFiles( "E://web/UploadMusic/" ) )
            {
                comboBox1.Items.Add( Path.GetFileName( file ) );
            }
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
            213312
        }.
        .
        323232
    }
}
