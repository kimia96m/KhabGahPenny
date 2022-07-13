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
    public partial class NewEmployee : Form
    {
        Function fm = new Function();
        string query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void ButtonAddEmployeeExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ClearAll()
        {
            textBoxEmployeeMobileNumber.Clear();
            textBoxEmployeeName.Clear();
            textBoxEmployeeEmailId.Clear();
            textBoxEmployeeIdProof.Clear();
            textBoxEmployeeAddress.Clear();
            comboBoxEmployeeRoomNumbers.SelectedIndex = -1;
        }

        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeMobileNumber.Text != "" && textBoxEmployeeName.Text != "" && textBoxEmployeeEmailId.Text != "" && textBoxEmployeeIdProof.Text != "" && comboBoxEmployeeRoomNumbers.Text != "" && textBoxEmployeeAddress.Text != "")
            {
                query = $"insert into Employee(Mobile,Name,Email,IdProof,Designation,Address) values({textBoxEmployeeMobileNumber.Text},'{textBoxEmployeeName.Text}','{textBoxEmployeeEmailId.Text}','{textBoxEmployeeIdProof.Text}','{comboBoxEmployeeRoomNumbers.Text}','{textBoxEmployeeAddress.Text}')";
                fm.setData(query, "Successfully Added.");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please Complete The Form.","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
           
        }
    }
}
