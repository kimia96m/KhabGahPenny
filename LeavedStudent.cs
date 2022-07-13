using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhabGahe_Penny
{
    public partial class LeavedStudent : Form
    {
        Function fm = new Function();
        string query;
        public LeavedStudent()
        {
            InitializeComponent();
        }

        private void LeavedStudent_Load(object sender, EventArgs e)
        {
            query = "select * from Students where living='No'";
            DataSet ds = fm.getData(query);
            AllStudentsLeftTable.DataSource = ds.Tables[0];
        }

        private void ButtonExitLeftSt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
