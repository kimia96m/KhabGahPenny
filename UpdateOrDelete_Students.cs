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
    public partial class UpdateOrDelete_Students : Form
    {
        Function fc = new Function();
        string query;
        public UpdateOrDelete_Students()
        {
            InitializeComponent();
        }

        private void ButtonExitUDForm_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearAll()
        {
            textBoxStudentMobileNumbers.Clear();
            textBoxStudentNames.Clear();
            textBoxFatherNames.Clear();
            textBoxMotherNames.Clear();
            textBoxCollegeNames.Clear();
            textBoxEmailIds.Clear();
            textBoxStudentIdProofs.Clear();
            textBoxAddresss.Clear();
            textBoxRoomNumbers.Clear();
            comboBoxLivingStatus.SelectedIndex = -1;
        }

        private void ButtonClearUDForm_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonSearchStudent_Click(object sender, EventArgs e)
        {
            long n;
            if (textBoxStudentMobileNumbers.Text.Trim() != "" && Int64.TryParse(textBoxStudentMobileNumbers.Text.Trim(), out n))
            {
                query = $" select * from Students where Mobile={Int64.Parse(textBoxStudentMobileNumbers.Text)}";
                DataSet ds = fc.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {

                    textBoxStudentNames.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBoxFatherNames.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBoxMotherNames.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBoxCollegeNames.Text = ds.Tables[0].Rows[0][7].ToString();
                    textBoxEmailIds.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBoxStudentIdProofs.Text = ds.Tables[0].Rows[0][8].ToString();
                    textBoxAddresss.Text = ds.Tables[0].Rows[0][6].ToString();
                    textBoxRoomNumbers.Text = ds.Tables[0].Rows[0][9].ToString();
                    comboBoxLivingStatus.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    ClearAll();
                    MessageBox.Show("Not Record Is Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ClearAll();
                MessageBox.Show("Insert A Valid Number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUpdateStudent_Click(object sender, EventArgs e)
        {
            Int64 Mobile = Int64.Parse(textBoxStudentMobileNumbers.Text.Trim());
            String Name = textBoxStudentNames.Text.TrimStart().TrimEnd();
            String FatherName = textBoxFatherNames.Text.TrimStart().TrimEnd();
            String MotherName = textBoxMotherNames.Text.TrimStart().TrimEnd();
            String Email = textBoxEmailIds.Text.Trim();
            String Address = textBoxAddresss.Text.TrimStart().TrimEnd();
            String College = textBoxCollegeNames.Text.TrimStart().TrimEnd();
            String IdProof = textBoxStudentIdProofs.Text.Trim();
            Int64 RoomNumber = Int64.Parse(textBoxRoomNumbers.Text.Trim());
            String Living= comboBoxLivingStatus.Text.Trim();
            query = $"update Students set Mobile ={Mobile},Name='{Name}',FatherName='{FatherName}' ,MotherName='{MotherName}', Email='{Email}', Address='{Address}', College='{College}', IdProof='{IdProof}', RoomNumber={RoomNumber}, Living='{Living}' update Rooms set Booked ='{Living}' where Rooms.RoomNumber={RoomNumber}";
       
            fc.setData(query, "Changes Added");
            ClearAll();
        }

        private void ButtonRemoveStudent_Click(object sender, EventArgs e)
        {
            //manage deleting without input
            //manage inputing correct numbers
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = $"delete from Students where Mobile={textBoxStudentMobileNumbers.Text} update Rooms set Booked='NO' where Rooms.RoomNumber={textBoxRoomNumbers.Text}";
                fc.setData(query, "Student Deleted.");
                ClearAll();
            }
            
        }
    }
}
