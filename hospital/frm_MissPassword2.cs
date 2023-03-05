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
    public partial class frm_MissPassword2 : Form
    {
        public string str;
        public frm_MissPassword2(string number)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            str = number;
        }

        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            if (this.txb_NewPassword.Text.Trim() != this.txb_AgainPassword.Text.Trim())
            {
                MessageBox.Show("新密码与确认密码不一致！");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=master;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE tb_User SET Password=HASHBYTES('MD5',@Password) WHERE No=@No";
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_NewPassword.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@No", this.txb_Number.Text.Trim());
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 1)
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.txb_NewPassword.Text = "";
            this.txb_AgainPassword.Text = "";
        }

        private void frm_MissPassword2_Load(object sender, EventArgs e)
        {
            this.txb_Number.Text = str;
        }
    }
}
