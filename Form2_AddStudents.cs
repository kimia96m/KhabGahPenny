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
    public partial class Form2_AddStudents : Form
    {
        Function fc = new Function();
        string query;
        public Form2_AddStudents()
        {
            InitializeComponent();
        }

        private void Form2_AddStudents_Load(object sender, EventArgs e)
        {
            query = "select RoomNumber from Rooms where RoomStatus='Yes' and Booked='NO'";
            DataSet ds = fc.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int room = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboBoxRoomNumbers.Items.Add(room);
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void ButtonDeleteStudents_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            textBoxStudentMobileNumber.Clear();
            textBoxStudentName.Clear();
            textBoxFatherName.Clear();
            textBoxMotherName.Clear();
            textBoxCollegeName.Clear();
            textBoxEmailId.Clear();
            textBoxStudentIdProof.Clear();
            textBoxAddress.Clear();
            comboBoxRoomNumbers.SelectedIndex=-1;
        }

        private void ButtonSaveStudent_Click(object sender, EventArgs e)
        {
            if (textBoxStudentMobileNumber.Text.Trim() != "" &&
                 textBoxStudentName.Text.TrimStart().TrimEnd() != "" &&
                 textBoxFatherName.Text.TrimStart().TrimEnd() != "" &&
                    textBoxMotherName.Text.TrimStart().TrimEnd() != "" &&
                textBoxEmailId.Text.Trim() != "" &&
                textBoxAddress.Text.TrimStart().TrimEnd() != "" &&
                textBoxCollegeName.Text.TrimStart().TrimEnd() != "" &&
                textBoxStudentIdProof.Text.Trim() != "" &&
                comboBoxRoomNumbers.Text.Trim() != "")
            {
                Int64 Mobile = Int64.Parse(textBoxStudentMobileNumber.Text.Trim());
                String Name = textBoxStudentName.Text.TrimStart().TrimEnd();
                String FatherName = textBoxFatherName.Text.TrimStart().TrimEnd();
                String MotherName = textBoxMotherName.Text.TrimStart().TrimEnd();
                String Email = textBoxEmailId.Text.Trim();
                String Address = textBoxAddress.Text.TrimStart().TrimEnd();
                String College = textBoxCollegeName.Text.TrimStart().TrimEnd();
                String IdProof = textBoxStudentIdProof.Text.Trim();
                Int64 RoomNumber = Int64.Parse(comboBoxRoomNumbers.Text.Trim());
                query = $"insert into Students (Mobile,Name,FatherName,MotherName,Email,Address,College,IdProof,RoomNumber) values({Mobile},'{Name}','{FatherName}','{MotherName}','{Email}','{Address}','{College}','{IdProof}',{RoomNumber}) update Rooms set Booked = 'Yes' where Rooms.RoomNumber={RoomNumber}";
                fc.setData(query, "Student Registration Completed");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }
    }
}
