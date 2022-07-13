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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ButtonManageRooms_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(170, 20, 92);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            Form_AddNewRoom anr = new Form_AddNewRoom();
            anr.Show();
        }

        private void ButtonNewStudent_Click(object sender, EventArgs e)
        {
            buttonNewStudent.BackColor = Color.FromArgb(170, 20, 92);
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            Form2_AddStudents frm = new Form2_AddStudents();
            frm.Show();
        }

        private void ButtonUpdateAndDeleteStudents_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255,192,255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(170, 20, 92);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);

            UpdateOrDelete_Students frm = new UpdateOrDelete_Students();
            frm.Show();
        }

        private void ButtonStudentsFees_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(170, 20, 92);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            StudentFees frm = new StudentFees();
            frm.Show();
        }

        private void ButtonAllStudentsLiving_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(170, 20, 92);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            AllStudentsLiving frm = new AllStudentsLiving();
            frm.Show();
        }

        private void ButtonLeftedStudents_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(170, 20, 92);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            LeavedStudent frm = new LeavedStudent();
            frm.Show();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(170, 20, 92);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            NewEmployee frm = new NewEmployee();
            frm.Show();
        }

        private void ButtonUpdateAndDeleteEmployee_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(170, 20, 92);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            UpdateOrDeleteEmployee frm = new UpdateOrDeleteEmployee();
            frm.Show();
        }

        private void ButtonEmployeePayments_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(170, 20, 92);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            EmployeePayment frm = new EmployeePayment();
            frm.Show();
        }

        private void ButtonAllEmployeesLiving_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(170, 20, 92);
            buttonLeavedEmployee.BackColor = Color.FromArgb(255, 192, 255);
            All_Employee_Working frm = new All_Employee_Working();
            frm.Show();
        }

        private void ButtonLeavedEmployee_Click(object sender, EventArgs e)
        {
            buttonManageRooms.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewStudent.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonStudentsFees.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllStudentsLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeftedStudents.BackColor = Color.FromArgb(255, 192, 255);
            buttonNewEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonUpdateAndDeleteEmployee.BackColor = Color.FromArgb(255, 192, 255);
            buttonEmployeePayments.BackColor = Color.FromArgb(255, 192, 255);
            buttonAllEmployeesLiving.BackColor = Color.FromArgb(255, 192, 255);
            buttonLeavedEmployee.BackColor = Color.FromArgb(170, 20, 92);
            LeavedEmployee frm = new LeavedEmployee();
            frm.Show();
        }

        private void ButtonLogOut_MouseHover(object sender, EventArgs e)
        {
            buttonLogOut.BackColor= Color.FromArgb(255, 192, 255);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            BlinkingDashbordButton.Enabled = true;
            BlinkingDashbordButton.Start();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isvisible = true;
        private void BlinkingDashbordButton_Tick(object sender, EventArgs e)
        {
            if (isvisible == true)
            {
                labelDashboard.Visible = true;
                isvisible = false;
            }
            else
            {
                labelDashboard.Visible = false;
                isvisible = true;
            }
        }
    }
}
