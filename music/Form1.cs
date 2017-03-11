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
    }
}
