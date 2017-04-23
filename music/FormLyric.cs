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
    public partial class FormLyric : Form
    {
        String tmp = "";

        public FormLyric()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                FormSetTime t = new FormSetTime(this);
                t.TopMost = true;
                t.Text = "設定時間";
                t.ShowDialog();
                int select = listBox1.SelectedIndex;
                String now = "[" + t.getTime() + "] " + listBox1.SelectedItem;
                listBox1.Items.RemoveAt(select);
                listBox1.Items.Insert(select, now);
                listBox1.SelectedIndex = (select + 1) % listBox1.Items.Count;
            }
            else
                MessageBox.Show("請先輸入歌詞");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLyricInput input = new FormLyricInput(this);
            input.Text = "輸入歌詞";
            input.ShowDialog();
            listBox1.Items.Clear();
            foreach (String line in input.getlyric().Split('\n'))
                listBox1.Items.Add(line);
            listBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tmp = tmp + listBox1.Items[i].ToString() + "\n";
            }
            Lyrics test=new Lyrics(tmp);
            if (test != null)
            {
                this.Close();
            }
            else
                tmp = "";
        }
        public String getTimeLyric()
        {
            return tmp;
        }
    }
}
