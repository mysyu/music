using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using music.Music_Control;
using System.Collections.Generic;

namespace music
{
    public partial class Form1 : Form
    {
        List <Lyric> songlyric=new List<Lyric>();
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
            listBox1.Items.Clear();
            foreach (String line in textBox1.Text.Split('\n'))
                listBox1.Items.Add("[00:00] " + line);
            listBox1.SelectedIndex = 0;
        }

        private void button3_Click( object sender , EventArgs e )
        {
            int select = listBox1.SelectedIndex;
            String now = null;
            if (musicPlayer1.Ctlcontrols.currentPositionString!="")
            {
                Lyric tmp = new Lyric(musicPlayer1.Ctlcontrols.currentPositionString, listBox1.SelectedItem.ToString().Substring(8));
                if (songlyric.Count != 0)
                {
                    if (tmp.gettime() < songlyric[songlyric.Count - 1].gettime())
                    {
                        MessageBox.Show("Lyric should be set according to time", "Input Error");
                    }
                    else
                    {
                        now = "[" + musicPlayer1.Ctlcontrols.currentPositionString + "] " + listBox1.SelectedItem.ToString().Substring(8);
                        listBox1.Items.RemoveAt(select);
                        listBox1.Items.Insert(select, now);
                        listBox1.SelectedIndex = (select + 1) % listBox1.Items.Count;
                        songlyric.Add(tmp);
                    }
                }
                else
                {
                    now = "[" + musicPlayer1.Ctlcontrols.currentPositionString + "] " + listBox1.SelectedItem.ToString().Substring(8);
                    listBox1.Items.RemoveAt(select);
                    listBox1.Items.Insert(select, now);
                    listBox1.SelectedIndex = (select + 1) % listBox1.Items.Count;
                    songlyric.Add(tmp);
                }
            }
          
        }
    }
}
