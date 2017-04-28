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
    public partial class FormMusicInfo : Form
    {
        public FormMusicInfo()
        {
            InitializeComponent();
            Singer.Text = Music.singer;
            Type.Text = Music.tag;
            Info.Text = Music.info;
        }

        private void correct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
