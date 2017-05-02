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
    public partial class FormAccountInfo : Form
    {
        public FormAccountInfo()
        {
            InitializeComponent();
            name.Text = Account.user.name;
            sex.Text = Account.user.sex;
            info.Text = Account.user.info;
        }

        private void save_Click(object sender, EventArgs e)
        {
            message.Text = Account.ChangeInfo(name.Text, sex.Text, info.Text);
            if (message.Text.Equals("Success"))
            {
                this.Close();
                if (Account.user.name == "")
                    FormMain.main.account.Text = Account.user.email;
                else
                    FormMain.main.account.Text = Account.user.name;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
