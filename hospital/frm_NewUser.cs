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
    public partial class frm_NewUser : Form
    {
        public int time = 1;
        public int a;
        public frm_NewUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string address = this.cmb_Shen.Text.Trim() + this.cmb_Shi.Text.Trim() + this.cmb_Xian.Text.Trim()
               + this.txb_Address.Text.Trim();
            if (this.txb_Number.Text.Trim() == "" || this.txb_Number.Text.Trim() == "请输入账号！")
            {
                MessageBox.Show("请输入账号！");
                return;
            }
            if (this.txb_Password.Text.Trim() == "" || this.txb_Password.Text.Trim() == "请输入密码！")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            if (this.txb_AgainPassword.Text.Trim() == "" || this.txb_AgainPassword.Text.Trim() == "请再次输入密码！")
            {
                MessageBox.Show("请再次输入密码！");
                return;
            }
            if (this.txb_Phone.Text.Trim() == "" || this.txb_Phone.Text.Trim() == "请输入手机号！")
            {
                MessageBox.Show("请输入手机号！");
                return;
            }
            if (this.txb_CheckNumber.Text.Trim() == "" || this.txb_CheckNumber.Text.Trim() == "请输入验证码！")
            {
                MessageBox.Show("请输入验证码！");
                return;
            }
            if (this.txb_IdCard.Text.Trim() == "" || this.txb_IdCard.Text.Trim() == "请输入身份证号！")
            {
                MessageBox.Show("请输入身份证号！");
                return;
            }
            if (this.txb_Address.Text.Trim() == "" || this.txb_Address.Text.Trim() == "请输入地址！")
            {
                MessageBox.Show("请输入地址！");
                return;
            }
            if (this.rdb_Female.Checked == false && this.rdb_Male.Checked == false)
            {
                MessageBox.Show("请选择您的性别！");
                return;
            }
            if (this.txb_Name.Text.Trim() == "" || this.txb_Name.Text.Trim() == "请输入姓名！")
            {
                MessageBox.Show("请输入姓名！");
                return;
            }
            if (a.ToString() != this.txb_CheckNumber.Text.Trim())
            {
                MessageBox.Show("验证码错误！");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=Hospital;Integrated Security=sspi";
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText =
                $"INSERT tb_User (No,Password) VALUES (@No,HASHBYTES('MD5',@Password))";
            sqlCommand1.Parameters.AddWithValue("@No", this.txb_Number.Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand1.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand2.CommandText =
                $"INSERT tb_UserInfo (No,Phone,IdCard,Name,Address) VALUES('{this.txb_Number.Text.Trim()}'" +
                $",'{this.txb_Phone.Text.Trim()}','{this.txb_IdCard.Text.Trim()}'" +
                $",'{this.txb_Name.Text.Trim()}','{address}')";
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand3.CommandText =
                $"INSERT tb_HospitalAccount (No,Money) VALUES ('{this.txb_Number.Text.Trim()}',0)";
            int rowAffected1 = 0;
            int rowAffected2 = 0;
            int rowAffected3 = 0;
            try
            {
                sqlConnection.Open();
                rowAffected1 = sqlCommand1.ExecuteNonQuery();
                rowAffected2 = sqlCommand2.ExecuteNonQuery();
                rowAffected3 = sqlCommand3.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show($"您注册的用户号:{this.txb_Number.Text.Trim()}已存在，请重新输入！\n");
                }
            }
            finally
            {
                sqlConnection.Close();
            }
            if (rowAffected1 == 1 && rowAffected2 == 1 && rowAffected3 == 1)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
        
        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
        private void LoadAddressSheng()
        {
            this.cmb_Shen.Items.Clear();
            this.cmb_Shen.Items.AddRange(Sheng.GetAllShengs());
            this.cmb_Shen.SelectedItem = "福建省";
        }
        private void LoadAddressShi()
        {
            string currentSheng = this.cmb_Shen.SelectedItem.ToString();
            string[] availableShi = Sheng.GetAllShis(currentSheng);
            this.cmb_Shi.Items.Clear();
            this.cmb_Shi.Items.AddRange(availableShi);
            this.cmb_Shi.SelectedItem = "龙岩市";
        }
        private void LoadAddressXian()
        {
            string currentShi = this.cmb_Shi.SelectedItem.ToString();
            string[] availableXian = Sheng.GetAllXians(currentShi);
            this.cmb_Xian.Items.Clear();
            this.cmb_Xian.Items.AddRange(availableXian);
        }
    }
}
