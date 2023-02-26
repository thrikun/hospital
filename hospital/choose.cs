using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_Administator_Click(object sender, EventArgs e)
        {
            frm_AdminLogin form = new frm_AdminLogin();
            form.Show();
        }
    }
}
