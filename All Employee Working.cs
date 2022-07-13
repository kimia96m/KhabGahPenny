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
    public partial class All_Employee_Working : Form
    {
        Function fm = new Function();
        string query;
        public All_Employee_Working()
        {
            InitializeComponent();
        }

        private void ButtonExitEmployeeSt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void All_Employee_Working_Load(object sender, EventArgs e)
        {
            query = "select * from Employee where Working='Yes'";
            DataSet ds = fm.getData(query);
            AllEmployeeTable.DataSource = ds.Tables[0];
        }
    }
}
