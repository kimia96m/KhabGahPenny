namespace KhabGahe_Penny
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonLeavedEmployee = new System.Windows.Forms.Button();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonEmployeePayments = new System.Windows.Forms.Button();
            this.buttonLeftedStudents = new System.Windows.Forms.Button();
            this.buttonAllStudentsLiving = new System.Windows.Forms.Button();
            this.buttonStudentsFees = new System.Windows.Forms.Button();
            this.buttonAllEmployeesLiving = new System.Windows.Forms.Button();
            this.buttonUpdateAndDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateAndDeleteStudents = new System.Windows.Forms.Button();
            this.buttonNewStudent = new System.Windows.Forms.Button();
            this.buttonManageRooms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlinkingDashbordButton = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "منو ها";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(712, 26);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(121, 32);
            this.labelDashboard.TabIndex = 2;
            this.labelDashboard.Text = "خوابگاه پنی";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(1259, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(76, 49);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(1086, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(128, 72);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "خروج";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            this.buttonLogOut.MouseHover += new System.EventHandler(this.ButtonLogOut_MouseHover);
            // 
            // buttonLeavedEmployee
            // 
            this.buttonLeavedEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLeavedEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLeavedEmployee.FlatAppearance.BorderSize = 0;
            this.buttonLeavedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeavedEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeavedEmployee.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeavedEmployee.Image")));
            this.buttonLeavedEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLeavedEmployee.Location = new System.Drawing.Point(12, 690);
            this.buttonLeavedEmployee.Name = "buttonLeavedEmployee";
            this.buttonLeavedEmployee.Size = new System.Drawing.Size(229, 44);
            this.buttonLeavedEmployee.TabIndex = 13;
            this.buttonLeavedEmployee.Text = "Leaved Employee";
            this.buttonLeavedEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeavedEmployee.UseVisualStyleBackColor = false;
            this.buttonLeavedEmployee.Click += new System.EventHandler(this.ButtonLeavedEmployee_Click);
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNewEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNewEmployee.FlatAppearance.BorderSize = 0;
            this.buttonNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewEmployee.Image")));
            this.buttonNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewEmployee.Location = new System.Drawing.Point(12, 450);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(229, 44);
            this.buttonNewEmployee.TabIndex = 12;
            this.buttonNewEmployee.Text = "New Employee";
            this.buttonNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewEmployee.UseVisualStyleBackColor = false;
            this.buttonNewEmployee.Click += new System.EventHandler(this.ButtonNewEmployee_Click);
            // 
            // buttonEmployeePayments
            // 
            this.buttonEmployeePayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEmployeePayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEmployeePayments.FlatAppearance.BorderSize = 0;
            this.buttonEmployeePayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeePayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeePayments.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployeePayments.Image")));
            this.buttonEmployeePayments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmployeePayments.Location = new System.Drawing.Point(12, 570);
            this.buttonEmployeePayments.Name = "buttonEmployeePayments";
            this.buttonEmployeePayments.Size = new System.Drawing.Size(229, 44);
            this.buttonEmployeePayments.TabIndex = 11;
            this.buttonEmployeePayments.Text = "Employee Payments";
            this.buttonEmployeePayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeePayments.UseVisualStyleBackColor = false;
            this.buttonEmployeePayments.Click += new System.EventHandler(this.ButtonEmployeePayments_Click);
            // 
            // buttonLeftedStudents
            // 
            this.buttonLeftedStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLeftedStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLeftedStudents.FlatAppearance.BorderSize = 0;
            this.buttonLeftedStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeftedStudents.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeftedStudents.Image")));
            this.buttonLeftedStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLeftedStudents.Location = new System.Drawing.Point(12, 390);
            this.buttonLeftedStudents.Name = "buttonLeftedStudents";
            this.buttonLeftedStudents.Size = new System.Drawing.Size(229, 44);
            this.buttonLeftedStudents.TabIndex = 10;
            this.buttonLeftedStudents.Text = "Lefted Students";
            this.buttonLeftedStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeftedStudents.UseVisualStyleBackColor = false;
            this.buttonLeftedStudents.Click += new System.EventHandler(this.ButtonLeftedStudents_Click);
            // 
            // buttonAllStudentsLiving
            // 
            this.buttonAllStudentsLiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAllStudentsLiving.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAllStudentsLiving.FlatAppearance.BorderSize = 0;
            this.buttonAllStudentsLiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllStudentsLiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllStudentsLiving.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllStudentsLiving.Image")));
            this.buttonAllStudentsLiving.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAllStudentsLiving.Location = new System.Drawing.Point(12, 330);
            this.buttonAllStudentsLiving.Name = "buttonAllStudentsLiving";
            this.buttonAllStudentsLiving.Size = new System.Drawing.Size(229, 44);
            this.buttonAllStudentsLiving.TabIndex = 9;
            this.buttonAllStudentsLiving.Text = "All Students Living";
            this.buttonAllStudentsLiving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllStudentsLiving.UseVisualStyleBackColor = false;
            this.buttonAllStudentsLiving.Click += new System.EventHandler(this.ButtonAllStudentsLiving_Click);
            // 
            // buttonStudentsFees
            // 
            this.buttonStudentsFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonStudentsFees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonStudentsFees.FlatAppearance.BorderSize = 0;
            this.buttonStudentsFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentsFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentsFees.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudentsFees.Image")));
            this.buttonStudentsFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStudentsFees.Location = new System.Drawing.Point(12, 270);
            this.buttonStudentsFees.Name = "buttonStudentsFees";
            this.buttonStudentsFees.Size = new System.Drawing.Size(229, 44);
            this.buttonStudentsFees.TabIndex = 8;
            this.buttonStudentsFees.Text = "Students Fees";
            this.buttonStudentsFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentsFees.UseVisualStyleBackColor = false;
            this.buttonStudentsFees.Click += new System.EventHandler(this.ButtonStudentsFees_Click);
            // 
            // buttonAllEmployeesLiving
            // 
            this.buttonAllEmployeesLiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAllEmployeesLiving.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAllEmployeesLiving.FlatAppearance.BorderSize = 0;
            this.buttonAllEmployeesLiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllEmployeesLiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllEmployeesLiving.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllEmployeesLiving.Image")));
            this.buttonAllEmployeesLiving.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAllEmployeesLiving.Location = new System.Drawing.Point(12, 630);
            this.buttonAllEmployeesLiving.Name = "buttonAllEmployeesLiving";
            this.buttonAllEmployeesLiving.Size = new System.Drawing.Size(229, 44);
            this.buttonAllEmployeesLiving.TabIndex = 7;
            this.buttonAllEmployeesLiving.Text = "All Employees Living";
            this.buttonAllEmployeesLiving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllEmployeesLiving.UseVisualStyleBackColor = false;
            this.buttonAllEmployeesLiving.Click += new System.EventHandler(this.ButtonAllEmployeesLiving_Click);
            // 
            // buttonUpdateAndDeleteEmployee
            // 
            this.buttonUpdateAndDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdateAndDeleteEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdateAndDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.buttonUpdateAndDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateAndDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateAndDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateAndDeleteEmployee.Image")));
            this.buttonUpdateAndDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateAndDeleteEmployee.Location = new System.Drawing.Point(12, 510);
            this.buttonUpdateAndDeleteEmployee.Name = "buttonUpdateAndDeleteEmployee";
            this.buttonUpdateAndDeleteEmployee.Size = new System.Drawing.Size(229, 44);
            this.buttonUpdateAndDeleteEmployee.TabIndex = 6;
            this.buttonUpdateAndDeleteEmployee.Text = "Update And Delete Employee";
            this.buttonUpdateAndDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateAndDeleteEmployee.UseVisualStyleBackColor = false;
            this.buttonUpdateAndDeleteEmployee.Click += new System.EventHandler(this.ButtonUpdateAndDeleteEmployee_Click);
            // 
            // buttonUpdateAndDeleteStudents
            // 
            this.buttonUpdateAndDeleteStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdateAndDeleteStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdateAndDeleteStudents.FlatAppearance.BorderSize = 0;
            this.buttonUpdateAndDeleteStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateAndDeleteStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateAndDeleteStudents.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateAndDeleteStudents.Image")));
            this.buttonUpdateAndDeleteStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateAndDeleteStudents.Location = new System.Drawing.Point(12, 210);
            this.buttonUpdateAndDeleteStudents.Name = "buttonUpdateAndDeleteStudents";
            this.buttonUpdateAndDeleteStudents.Size = new System.Drawing.Size(229, 44);
            this.buttonUpdateAndDeleteStudents.TabIndex = 5;
            this.buttonUpdateAndDeleteStudents.Text = "Update And Delete Students";
            this.buttonUpdateAndDeleteStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateAndDeleteStudents.UseVisualStyleBackColor = false;
            this.buttonUpdateAndDeleteStudents.Click += new System.EventHandler(this.ButtonUpdateAndDeleteStudents_Click);
            // 
            // buttonNewStudent
            // 
            this.buttonNewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNewStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNewStudent.FlatAppearance.BorderSize = 0;
            this.buttonNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewStudent.Image")));
            this.buttonNewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewStudent.Location = new System.Drawing.Point(12, 150);
            this.buttonNewStudent.Name = "buttonNewStudent";
            this.buttonNewStudent.Size = new System.Drawing.Size(229, 44);
            this.buttonNewStudent.TabIndex = 4;
            this.buttonNewStudent.Text = "New Student";
            this.buttonNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewStudent.UseVisualStyleBackColor = false;
            this.buttonNewStudent.Click += new System.EventHandler(this.ButtonNewStudent_Click);
            // 
            // buttonManageRooms
            // 
            this.buttonManageRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonManageRooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonManageRooms.FlatAppearance.BorderSize = 0;
            this.buttonManageRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageRooms.Image = ((System.Drawing.Image)(resources.GetObject("buttonManageRooms.Image")));
            this.buttonManageRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManageRooms.Location = new System.Drawing.Point(12, 90);
            this.buttonManageRooms.Name = "buttonManageRooms";
            this.buttonManageRooms.Size = new System.Drawing.Size(229, 44);
            this.buttonManageRooms.TabIndex = 3;
            this.buttonManageRooms.Text = "Manage Rooms";
            this.buttonManageRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageRooms.UseVisualStyleBackColor = false;
            this.buttonManageRooms.Click += new System.EventHandler(this.ButtonManageRooms_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KhabGahe_Penny.Properties.Resources.hostel;
            this.pictureBox1.Location = new System.Drawing.Point(274, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 644);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BlinkingDashbordButton
            // 
            this.BlinkingDashbordButton.Enabled = true;
            this.BlinkingDashbordButton.Interval = 500;
            this.BlinkingDashbordButton.Tick += new System.EventHandler(this.BlinkingDashbordButton_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1386, 768);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonLeavedEmployee);
            this.Controls.Add(this.buttonNewEmployee);
            this.Controls.Add(this.buttonEmployeePayments);
            this.Controls.Add(this.buttonLeftedStudents);
            this.Controls.Add(this.buttonAllStudentsLiving);
            this.Controls.Add(this.buttonStudentsFees);
            this.Controls.Add(this.buttonAllEmployeesLiving);
            this.Controls.Add(this.buttonUpdateAndDeleteEmployee);
            this.Controls.Add(this.buttonUpdateAndDeleteStudents);
            this.Controls.Add(this.buttonNewStudent);
            this.Controls.Add(this.buttonManageRooms);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Button buttonManageRooms;
        private System.Windows.Forms.Button buttonNewStudent;
        private System.Windows.Forms.Button buttonUpdateAndDeleteStudents;
        private System.Windows.Forms.Button buttonUpdateAndDeleteEmployee;
        private System.Windows.Forms.Button buttonAllEmployeesLiving;
        private System.Windows.Forms.Button buttonStudentsFees;
        private System.Windows.Forms.Button buttonAllStudentsLiving;
        private System.Windows.Forms.Button buttonLeftedStudents;
        private System.Windows.Forms.Button buttonEmployeePayments;
        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonLeavedEmployee;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer BlinkingDashbordButton;
    }
}