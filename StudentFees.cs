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
    public partial class StudentFees : Form
    {
        Function fc = new Function();
        string query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void ButtonExitFee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            dateTimePickerMonthStudentFee.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonthStudentFee.CustomFormat = "MMMM yyyy";
        }

        private void ButtonSearchStudentFees_Click(object sender, EventArgs e)
        {
            if (txtMobileStFee.Text != "") {
                query = $"select Name,Email,RoomNumber from Students where Mobile={txtMobileStFee.Text}";
                DataSet ds=fc.getData(query);
                if (ds.Tables[0].Rows.Count != 0) {
                    txtNameStFee.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailStFee.Text= ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNoStFee.Text= ds.Tables[0].Rows[0][2].ToString();
                    query = $"select * from Fees where MobileNumber={txtMobileStFee.Text}";
                    DataSet d = fc.getData(query);
                    RoomsFeeTable.DataSource = d.Tables[0];
                }
                else
                {
                    MessageBox.Show("NO Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
           
        }

        private void ButtonPayStudentFee_Click(object sender, EventArgs e)
        {
            if (txtMobileStFee.Text != "" && txtAmountStFee.Text != "")
            {
                query = $"select * from Fees where MobileNumber={txtMobileStFee.Text} and Month='{dateTimePickerMonthStudentFee.Text}'";
                DataSet ds = fc.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 Mobile = Int64.Parse(txtMobileStFee.Text);
                    String Month = dateTimePickerMonthStudentFee.Text;
                    Int64 Amount = Int64.Parse(txtAmountStFee.Text);
                    query= $"insert into Fees(MobileNumber,Month,Amount) values({Mobile},'{Month}',{Amount})";
                    fc.setData(query, "Fees Paid");
                    query = $"select * from Fees where MobileNumber={txtMobileStFee.Text}";
                    DataSet d = fc.getData(query);
                    RoomsFeeTable.DataSource = d.Tables[0];
                }
                else
                {
                    MessageBox.Show("Have been paid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
        }

        private void DateTimePickerMonthStudentFee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClearFee_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll() {
            txtMobileStFee.Clear();
            txtNameStFee.Clear();
            txtEmailStFee.Clear();
            txtRoomNoStFee.Clear();
            txtAmountStFee.Clear();
            RoomsFeeTable.ClearSelection();
        }
    }
}
