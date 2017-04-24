using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace music
{
    public partial class FormMusicUpload : Form
    {
        public FormMusicUpload()
        {
            InitializeComponent();
        }

        private void tag1_CheckedChanged(object sender, EventArgs e)
        {
            if (tag1.Checked == true)
                tag2.Checked = false;
        }

        private void tag2_CheckedChanged(object sender, EventArgs e)
        {
            if (tag2.Checked == true)
                tag1.Checked = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void music_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "text file ( *.txt )|*.txt";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lyric.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void lyric_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "audio files ( *.wav , *.mp3 )|*.wav;*.mp3";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                music.Text = openFileDialog.FileName;
            }
        }
    }
}
