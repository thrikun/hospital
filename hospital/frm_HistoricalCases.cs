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
   
    public partial class frm_HistoricalCases : Form
    { public string str;
        public frm_HistoricalCases(string number)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            str = number;
        }

        private void btn_Seek_Click(object sender, EventArgs e)
        {

        }
    }
}
