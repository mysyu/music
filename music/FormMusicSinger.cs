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
    public partial class FormMusicSinger : Form
    {
        public FormMusicSinger()
        {
            InitializeComponent();
        }
        public void Set( Account singer )
        {
            name.Text = singer.name;
            sex.Text = singer.sex;
            info.Text = singer.info;
        }

        private void correct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
