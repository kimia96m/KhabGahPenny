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
    public partial class AllStudentsLiving : Form
    {
        Function fm = new Function();
        string query;
        public AllStudentsLiving()
        {
            InitializeComponent();
        }

        private void ButtonExitLivingSt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllStudentsLiving_Load(object sender, EventArgs e)
        {
            query = "select * from Students where Living='Yes'";
            DataSet ds = fm.getData(query);
            AllStudentsTable.DataSource = ds.Tables[0];
        }
    }
}
