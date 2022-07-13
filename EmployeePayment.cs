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
    public partial class EmployeePayment : Form
    {
        Function fm = new Function();
        string query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void ButtonExitPayment_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ClearAll()
        {
            txtMobilePayment.Clear();
            txtNamePayment.Clear();
            txtEmailPayment.Clear();
            txtRoomNoStPayment.Clear();
            txtAmountPayment.Clear();
            RoomsPaymentTable.ClearSelection();
        }

        private void ButtonClearPayment_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonExitPayment_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            dateTimePickerMonthPayment.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonthPayment.CustomFormat = "MMMM yyyy";
        }

        private void ButtonSearchPayment_Click(object sender, EventArgs e)
        {
            if (txtMobilePayment.Text!="") {
                query = $"select * from Employee where Mobile={txtMobilePayment.Text}";
                DataSet ds = fm.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtNamePayment.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtEmailPayment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtRoomNoStPayment.Text = ds.Tables[0].Rows[0][6].ToString();
                    PaymentTableSet(Int64.Parse(txtMobilePayment.Text));
                } 
                else
                {
                    MessageBox.Show("Not Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter A Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //select * from Payments,Employee where Mobile=
        }

        private void ButtonPayPayment_Click(object sender, EventArgs e)
        {
            if (txtMobilePayment.Text != "" && txtAmountPayment.Text!="")
            { query = $"select * from Payments where Mobile={txtMobilePayment.Text} and Month='{dateTimePickerMonthPayment.Text}'";
                DataSet ds = fm.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = $"insert into Payments(Month,Amount,Mobile) values('{dateTimePickerMonthPayment.Text}',{txtAmountPayment.Text},{txtMobilePayment.Text})";
                    fm.setData(query, "Inputed Successfully.");
                    PaymentTableSet(Int64.Parse(txtMobilePayment.Text));
                }
                else
                {
                    MessageBox.Show("It has been paid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         
            }
            else {
                MessageBox.Show("Enter A Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PaymentTableSet(Int64 Mobile)
        {
            query = $"select * from Payments where Mobile={txtMobilePayment.Text}";
            DataSet ds = fm.getData(query);
            RoomsPaymentTable.DataSource = ds.Tables[0];
        }

    }
}
