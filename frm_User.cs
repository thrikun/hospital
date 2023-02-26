using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class frm_User : Form
    {
        public frm_User()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.No = this.txb_Number.Text.Trim();
            user.Password = this.txb_Password.Text.Trim();
            user.CheckLogin();
            if (user.IsLogin)
            {
                MessageBox.Show(user.Message);
                frm_HospitalSelfHelpSystem form = new frm_HospitalSelfHelpSystem(this.txb_Number.Text.Trim());
                form.Show();
            }
            if (!user.IsLogin)
            {
                MessageBox.Show(user.Message);
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_NewUser form = new frm_NewUser();
            form.Show();
        }

        private void llbl_MissPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
