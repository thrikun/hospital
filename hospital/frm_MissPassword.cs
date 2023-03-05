using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class frm_MissPassword : Form
    {
        public int check;
        public frm_MissPassword()
        {
            InitializeComponent();
        }

        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            if (this.txb_Number.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空！");
                return;
            }
            if (this.txb_Phone.Text.Trim() == "")
            {
                MessageBox.Show("手机号不能为空！");
                return;
            }
            if (this.txb_CheckNumber.Text.Trim() == "")
            {
                MessageBox.Show("验证码不能为空！");
                return;
            }
            if (this.txb_CheckNumber.Text.Trim() != check.ToString())
            {
                MessageBox.Show("验证码错误！");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=master;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM tb_UserInfo WHERE No=@No AND Phone=@Phone";
            sqlCommand.Parameters.AddWithValue("@No", this.txb_Number.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Phone", this.txb_Phone.Text.Trim());
            sqlConnection.Open();
            int row = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (row == 1)
            {
                MessageBox.Show("验证成功！");
                frm_MissPassword2 form = new frm_MissPassword2(this.txb_Number.Text.Trim());
                form.Show();
            }
            else
            {
                MessageBox.Show("验证失败！");
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            frm_User form = new frm_User();
            form.Show();
        }

        private void btn_Catch_Click(object sender, EventArgs e)
        {
            if (this.txb_Phone.Text.Trim() == "")
            {
                MessageBox.Show($"请输入手机号！");
                this.txb_Phone.Focus();
                this.txb_Phone.Text = "";
                return;
            }
            if (this.txb_Phone.Text.Trim() != "" && this.txb_Phone.Text.Trim() != "请输入手机号！")
            {
                check = int.Parse(this.txb_Phone.Text.Trim().Substring(7, 4)) + DateTime.Now.Hour * 100 + DateTime.Now.Second;
                MessageBox.Show($"验证码为：{check}");
            }
        }
    }
}
