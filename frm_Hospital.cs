using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 闽侯县医院门诊系统
{
    public partial class frm_Hospital : Form
    {
        public frm_Hospital()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            frm_DoctorUser form = new frm_DoctorUser();
            form.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            frm_User form = new frm_User();
            form.Show();
        }

        private void btn_Administator_Click(object sender, EventArgs e)
        {
            frm_AdminLogin form = new frm_AdminLogin();
            form.Show();
        }

        private void frm_Hospital_Load(object sender, EventArgs e)
        {

        }
    }
}
