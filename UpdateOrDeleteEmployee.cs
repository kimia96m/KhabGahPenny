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
    public partial class UpdateOrDeleteEmployee : Form
    {
        Function fm = new Function();
        string query;
        public UpdateOrDeleteEmployee()
        {
            InitializeComponent();
        }

        private void ButtonExitUDEmployeeDesignationForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSearchEmployee_Click(object sender, EventArgs e)
        {
            query = $"select * from Employee where Mobile={textBoxEmployeeMobileNumbers.Text}";
            DataSet ds = fm.getData(query);
            if (textBoxEmployeeMobileNumbers.Text != ""&& ds.Tables[0].Rows.Count!=0)
            {
                textBoxEmployeeNames.Text =ds.Tables[0].Rows[0][2].ToString();
                textBoxEmployeeEmailIds.Text = ds.Tables[0].Rows[0][3].ToString();
                textBoxEmployeeIdProofs.Text = ds.Tables[0].Rows[0][4].ToString();
                textBoxEmployeeAddresss.Text = ds.Tables[0].Rows[0][5].ToString();
                textBoxEmployeeDesignation.Text = ds.Tables[0].Rows[0][6].ToString();
                comboBoxWorkingStatus.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("Not Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
        }

        private void ButtonClearUDEmployeeForm_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll() {
            textBoxEmployeeMobileNumbers.Clear();
            textBoxEmployeeNames.Clear();
            textBoxEmployeeEmailIds.Clear();
            textBoxEmployeeIdProofs.Clear();
            textBoxEmployeeAddresss.Clear();
            textBoxEmployeeDesignation.Clear();
            
        }

        private void ButtonUpdateEmployee_Click(object sender, EventArgs e)
        {
            query = $"update Employee set Mobile={textBoxEmployeeMobileNumbers.Text},Name='{textBoxEmployeeNames.Text}',Email='{textBoxEmployeeEmailIds.Text}',IdProof='{textBoxEmployeeIdProofs.Text}',Designation='{textBoxEmployeeDesignation.Text}',Address='{textBoxEmployeeAddresss.Text}',Working='{comboBoxWorkingStatus.Text}' where Mobile={textBoxEmployeeMobileNumbers.Text}";
            fm.setData(query, "Updated");
        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = $"delete from Employee where Mobile={textBoxEmployeeMobileNumbers.Text}";
                fm.setData(query, "Deleted Succcessfully.");
                ClearAll();
            }
      
        }
    }
}

