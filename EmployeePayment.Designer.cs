namespace KhabGahe_Penny
{
    partial class EmployeePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePayment));
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonPayPayment = new System.Windows.Forms.Button();
            this.RoomsPaymentTable = new System.Windows.Forms.DataGridView();
            this.dateTimePickerMonthPayment = new System.Windows.Forms.DateTimePicker();
            this.buttonClearPayment = new System.Windows.Forms.Button();
            this.buttonSearchPayment = new System.Windows.Forms.Button();
            this.txtMobilePayment = new System.Windows.Forms.TextBox();
            this.txtRoomNoStPayment = new System.Windows.Forms.TextBox();
            this.txtAmountPayment = new System.Windows.Forms.TextBox();
            this.txtNamePayment = new System.Windows.Forms.TextBox();
            this.txtEmailPayment = new System.Windows.Forms.TextBox();
            this.buttonExitPayment = new System.Windows.Forms.Button();
            this.labelNamePayment = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.labelDesignationPayment = new System.Windows.Forms.Label();
            this.labelEmailPayment = new System.Windows.Forms.Label();
            this.labelMonthStudentFee = new System.Windows.Forms.Label();
            this.labelPaymentMobileNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsPaymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.ForeColor = System.Drawing.Color.White;
            this.labelPayment.Location = new System.Drawing.Point(152, 330);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(160, 20);
            this.labelPayment.TabIndex = 49;
            this.labelPayment.Text = "Previous Payments";
            // 
            // buttonPayPayment
            // 
            this.buttonPayPayment.BackColor = System.Drawing.Color.White;
            this.buttonPayPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonPayPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonPayPayment.Image")));
            this.buttonPayPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayPayment.Location = new System.Drawing.Point(523, 318);
            this.buttonPayPayment.Name = "buttonPayPayment";
            this.buttonPayPayment.Size = new System.Drawing.Size(89, 32);
            this.buttonPayPayment.TabIndex = 48;
            this.buttonPayPayment.Text = "Pay";
            this.buttonPayPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPayPayment.UseVisualStyleBackColor = false;
            this.buttonPayPayment.Click += new System.EventHandler(this.ButtonPayPayment_Click);
            // 
            // RoomsPaymentTable
            // 
            this.RoomsPaymentTable.AllowUserToOrderColumns = true;
            this.RoomsPaymentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomsPaymentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.RoomsPaymentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomsPaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsPaymentTable.Location = new System.Drawing.Point(147, 371);
            this.RoomsPaymentTable.Name = "RoomsPaymentTable";
            this.RoomsPaymentTable.Size = new System.Drawing.Size(600, 150);
            this.RoomsPaymentTable.TabIndex = 47;
            // 
            // dateTimePickerMonthPayment
            // 
            this.dateTimePickerMonthPayment.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.dateTimePickerMonthPayment.CalendarTrailingForeColor = System.Drawing.Color.LightSalmon;
            this.dateTimePickerMonthPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMonthPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonthPayment.Location = new System.Drawing.Point(217, 227);
            this.dateTimePickerMonthPayment.Name = "dateTimePickerMonthPayment";
            this.dateTimePickerMonthPayment.Size = new System.Drawing.Size(500, 29);
            this.dateTimePickerMonthPayment.TabIndex = 46;
            // 
            // buttonClearPayment
            // 
            this.buttonClearPayment.BackColor = System.Drawing.Color.White;
            this.buttonClearPayment.FlatAppearance.BorderSize = 0;
            this.buttonClearPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonClearPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearPayment.Image")));
            this.buttonClearPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearPayment.Location = new System.Drawing.Point(628, 318);
            this.buttonClearPayment.Name = "buttonClearPayment";
            this.buttonClearPayment.Size = new System.Drawing.Size(89, 32);
            this.buttonClearPayment.TabIndex = 45;
            this.buttonClearPayment.Text = "Clear";
            this.buttonClearPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearPayment.UseVisualStyleBackColor = false;
            this.buttonClearPayment.Click += new System.EventHandler(this.ButtonClearPayment_Click);
            // 
            // buttonSearchPayment
            // 
            this.buttonSearchPayment.BackColor = System.Drawing.Color.White;
            this.buttonSearchPayment.FlatAppearance.BorderSize = 0;
            this.buttonSearchPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonSearchPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchPayment.Image")));
            this.buttonSearchPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchPayment.Location = new System.Drawing.Point(461, 40);
            this.buttonSearchPayment.Name = "buttonSearchPayment";
            this.buttonSearchPayment.Size = new System.Drawing.Size(89, 29);
            this.buttonSearchPayment.TabIndex = 44;
            this.buttonSearchPayment.Text = "Search";
            this.buttonSearchPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchPayment.UseVisualStyleBackColor = false;
            this.buttonSearchPayment.Click += new System.EventHandler(this.ButtonSearchPayment_Click);
            // 
            // txtMobilePayment
            // 
            this.txtMobilePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobilePayment.Location = new System.Drawing.Point(217, 40);
            this.txtMobilePayment.Name = "txtMobilePayment";
            this.txtMobilePayment.Size = new System.Drawing.Size(177, 29);
            this.txtMobilePayment.TabIndex = 43;
            // 
            // txtRoomNoStPayment
            // 
            this.txtRoomNoStPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNoStPayment.Location = new System.Drawing.Point(217, 178);
            this.txtRoomNoStPayment.Name = "txtRoomNoStPayment";
            this.txtRoomNoStPayment.Size = new System.Drawing.Size(500, 29);
            this.txtRoomNoStPayment.TabIndex = 42;
            // 
            // txtAmountPayment
            // 
            this.txtAmountPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPayment.Location = new System.Drawing.Point(217, 274);
            this.txtAmountPayment.Name = "txtAmountPayment";
            this.txtAmountPayment.Size = new System.Drawing.Size(500, 29);
            this.txtAmountPayment.TabIndex = 41;
            // 
            // txtNamePayment
            // 
            this.txtNamePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePayment.Location = new System.Drawing.Point(217, 83);
            this.txtNamePayment.Name = "txtNamePayment";
            this.txtNamePayment.Size = new System.Drawing.Size(500, 29);
            this.txtNamePayment.TabIndex = 40;
            // 
            // txtEmailPayment
            // 
            this.txtEmailPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPayment.Location = new System.Drawing.Point(217, 130);
            this.txtEmailPayment.Name = "txtEmailPayment";
            this.txtEmailPayment.Size = new System.Drawing.Size(500, 29);
            this.txtEmailPayment.TabIndex = 39;
            // 
            // buttonExitPayment
            // 
            this.buttonExitPayment.FlatAppearance.BorderSize = 0;
            this.buttonExitPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitPayment.ForeColor = System.Drawing.Color.White;
            this.buttonExitPayment.Location = new System.Drawing.Point(806, 3);
            this.buttonExitPayment.Name = "buttonExitPayment";
            this.buttonExitPayment.Size = new System.Drawing.Size(58, 47);
            this.buttonExitPayment.TabIndex = 38;
            this.buttonExitPayment.Text = "X";
            this.buttonExitPayment.UseVisualStyleBackColor = true;
            this.buttonExitPayment.Click += new System.EventHandler(this.ButtonExitPayment_Click_1);
            // 
            // labelNamePayment
            // 
            this.labelNamePayment.AutoSize = true;
            this.labelNamePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamePayment.ForeColor = System.Drawing.Color.White;
            this.labelNamePayment.Location = new System.Drawing.Point(61, 92);
            this.labelNamePayment.Name = "labelNamePayment";
            this.labelNamePayment.Size = new System.Drawing.Size(55, 20);
            this.labelNamePayment.TabIndex = 37;
            this.labelNamePayment.Text = "Name";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentAmount.ForeColor = System.Drawing.Color.White;
            this.labelPaymentAmount.Location = new System.Drawing.Point(61, 283);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(145, 20);
            this.labelPaymentAmount.TabIndex = 36;
            this.labelPaymentAmount.Text = "Payment Amount";
            // 
            // labelDesignationPayment
            // 
            this.labelDesignationPayment.AutoSize = true;
            this.labelDesignationPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignationPayment.ForeColor = System.Drawing.Color.White;
            this.labelDesignationPayment.Location = new System.Drawing.Point(61, 187);
            this.labelDesignationPayment.Name = "labelDesignationPayment";
            this.labelDesignationPayment.Size = new System.Drawing.Size(105, 20);
            this.labelDesignationPayment.TabIndex = 35;
            this.labelDesignationPayment.Text = "Designation";
            // 
            // labelEmailPayment
            // 
            this.labelEmailPayment.AutoSize = true;
            this.labelEmailPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailPayment.ForeColor = System.Drawing.Color.White;
            this.labelEmailPayment.Location = new System.Drawing.Point(61, 139);
            this.labelEmailPayment.Name = "labelEmailPayment";
            this.labelEmailPayment.Size = new System.Drawing.Size(53, 20);
            this.labelEmailPayment.TabIndex = 34;
            this.labelEmailPayment.Text = "Email";
            // 
            // labelMonthStudentFee
            // 
            this.labelMonthStudentFee.AutoSize = true;
            this.labelMonthStudentFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthStudentFee.ForeColor = System.Drawing.Color.White;
            this.labelMonthStudentFee.Location = new System.Drawing.Point(61, 236);
            this.labelMonthStudentFee.Name = "labelMonthStudentFee";
            this.labelMonthStudentFee.Size = new System.Drawing.Size(59, 20);
            this.labelMonthStudentFee.TabIndex = 33;
            this.labelMonthStudentFee.Text = "Month";
            // 
            // labelPaymentMobileNumber
            // 
            this.labelPaymentMobileNumber.AutoSize = true;
            this.labelPaymentMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentMobileNumber.ForeColor = System.Drawing.Color.White;
            this.labelPaymentMobileNumber.Location = new System.Drawing.Point(61, 46);
            this.labelPaymentMobileNumber.Name = "labelPaymentMobileNumber";
            this.labelPaymentMobileNumber.Size = new System.Drawing.Size(128, 20);
            this.labelPaymentMobileNumber.TabIndex = 32;
            this.labelPaymentMobileNumber.Text = "Mobile Number";
            // 
            // EmployeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(867, 551);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.buttonPayPayment);
            this.Controls.Add(this.RoomsPaymentTable);
            this.Controls.Add(this.dateTimePickerMonthPayment);
            this.Controls.Add(this.buttonClearPayment);
            this.Controls.Add(this.buttonSearchPayment);
            this.Controls.Add(this.txtMobilePayment);
            this.Controls.Add(this.txtRoomNoStPayment);
            this.Controls.Add(this.txtAmountPayment);
            this.Controls.Add(this.txtNamePayment);
            this.Controls.Add(this.txtEmailPayment);
            this.Controls.Add(this.buttonExitPayment);
            this.Controls.Add(this.labelNamePayment);
            this.Controls.Add(this.labelPaymentAmount);
            this.Controls.Add(this.labelDesignationPayment);
            this.Controls.Add(this.labelEmailPayment);
            this.Controls.Add(this.labelMonthStudentFee);
            this.Controls.Add(this.labelPaymentMobileNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePayment";
            this.Load += new System.EventHandler(this.EmployeePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsPaymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonPayPayment;
        private System.Windows.Forms.DataGridView RoomsPaymentTable;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonthPayment;
        private System.Windows.Forms.Button buttonClearPayment;
        private System.Windows.Forms.Button buttonSearchPayment;
        private System.Windows.Forms.TextBox txtMobilePayment;
        private System.Windows.Forms.TextBox txtRoomNoStPayment;
        private System.Windows.Forms.TextBox txtAmountPayment;
        private System.Windows.Forms.TextBox txtNamePayment;
        private System.Windows.Forms.TextBox txtEmailPayment;
        private System.Windows.Forms.Button buttonExitPayment;
        private System.Windows.Forms.Label labelNamePayment;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.Label labelDesignationPayment;
        private System.Windows.Forms.Label labelEmailPayment;
        private System.Windows.Forms.Label labelMonthStudentFee;
        private System.Windows.Forms.Label labelPaymentMobileNumber;
    }
}