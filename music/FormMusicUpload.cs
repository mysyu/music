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
    public partial class FormMusicUpload : Form
    {
        String lyric = "";
        public FormMusicUpload()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            lyric = "";
            label4.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLyric l = new FormLyric();
            l.Text = "編輯歌詞";
            l.Show();
            lyric = l.getTimeLyric();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Music tmp=new Music("");
            tmp.Upload();
            label4.Text = tmp.name;
        }
    }
}
