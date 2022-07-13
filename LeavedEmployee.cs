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
    public partial class LeavedEmployee : Form
    {
        Function fm = new Function();
        string query;
        public LeavedEmployee()
        {
            InitializeComponent();
        }

        private void ButtonExitEmployeeLeft_Click(object sender, EventArgs e)
        { //
            Close();
        }

        private void LeavedEmployee_Load(object sender, EventArgs e)
        {
            query = "select * from Employee where Working='No'";
            DataSet ds = fm.getData(query);
            AllEmployeeLeftTable.DataSource = ds.Tables[0];
        }
        private void test1()
        {

        }
    }
}
