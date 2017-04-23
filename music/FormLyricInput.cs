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
    public partial class FormLyricInput : Form
    {
        String tmplyric;
        FormLyric Ref;
        public FormLyricInput(FormLyric temp)
        {
            InitializeComponent();
            Ref = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmplyric = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        public String getlyric()
        {
            return tmplyric;
        }
    }
}
