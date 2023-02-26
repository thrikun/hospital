using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace hospital
{
    public class User
    {
        public string No;
        public string Password;
        public string Message;
        public bool IsLogin;
        public void CheckLogin()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=Hospital;Integrated Security=sspi;";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $"SELECT COUNT(1) FROM tb_User" +
                $" WHERE No=@No" +
                $" AND Password=HASHBYTES('MD5',@Password);";
            sqlCommand.Parameters.AddWithValue("@No", No);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if(rowCount==1)
            {
                Message = "登录成功！";
                IsLogin = true;
            }
            else
            {
                Message = "登录失败！账号或密码错误！";
                IsLogin = false;
            }
        }
    }
}
