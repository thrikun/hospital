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
    public partial class frm_OutpatirntAppointment : Form
    {
        public string str;
        public frm_OutpatirntAppointment(string number)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            str = number;
            NameLoad();
        }
        public void NameLoad()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=master;Integrated Security=sspi;";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"SELECT * FROM tb_UserInfo WHERE No='{str}'";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_Status.Text = sqlDataReader["Name"].ToString();
            }
            sqlDataReader.Close();
        }

        private void frm_OutpatirntAppointment_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=master;Integrated Security=sspi;";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM tb_Department";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable department = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(department);
            sqlConnection.Close();
            this.cmb_Select.DataSource = department;
            this.cmb_Select.DisplayMember = "Name";
            this.cmb_Select.ValueMember = "No";
        }
    }
}
