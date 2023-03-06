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
    public partial class frm_HospitalSelfHelpSystem : Form
    {
        public string str;
        public string Department;
        public frm_HospitalSelfHelpSystem(string number)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            str = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_HistoricalCases frm_HistoricalCases = new frm_HistoricalCases(str); 
                frm_HistoricalCases.ShowDialog();
        }

        private void lnk_Out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frm_HospitalSelfHelpSystem_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=master;Integrated Security=sspi;";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"SELECT * FROM tb_UserInfo WHERE No=@No";
            sqlCommand.Parameters.AddWithValue("@No", str);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_Status.Text = sqlDataReader["Name"].ToString() + "，您好！";
            }
            sqlDataReader.Close();
        }

        private void btn_OutpatientAppointment_Click(object sender, EventArgs e)
        {
            //if(DateTime.Now.DayOfWeek.ToString()=="Saturday"||DateTime.Now.DayOfWeek.ToString()=="Sunday")
            //{
            //    MessageBox.Show("周末没有医生门诊！");
            //    return;
            //}
            frm_OutpatirntAppointment form = new frm_OutpatirntAppointment(str);
            form.Show();
        }

        private void lbl_Status_Click(object sender, EventArgs e)
        {

        }
    }
}
