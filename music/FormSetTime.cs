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
    public partial class FormSetTime : Form
    {
        String time;
        FormLyric Ref;
        public FormSetTime(FormLyric temp)
        {
            InitializeComponent();
            Ref = temp;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            time = maskTextBox1.Text;
            //Ref.settime(time);
            this.Close();
        }
        public String getTime()
        {
            return time;
        }
    }
}
