using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital
{
    public partial class frm_AdminLogin : Form
    {
        public frm_AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=Hospital;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT COUNT(1) FROM tb_Admin WHERE No=@No AND Password=HASHBYTES('MD5',@Password) AND Power=@Power";
            sqlCommand.Parameters.AddWithValue("@No", this.txb_Number.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@Power", this.txb_Power.Text.Trim());
            sqlCommand.Parameters["@Power"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();
            int row = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (row == 1)
            {
                MessageBox.Show("登录成功！");
                //frm_PrescribeSystem form = new frm_PrescribeSystem();
                //form.Show();
            }
            else
            {
                MessageBox.Show("登录失败！账号或密码或权限错误！");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
