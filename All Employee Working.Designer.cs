namespace KhabGahe_Penny
{
    partial class All_Employee_Working
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
            this.AllEmployeeTable = new System.Windows.Forms.DataGridView();
            this.buttonExitEmployeeSt = new System.Windows.Forms.Button();
            this.labelAllEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllEmployeeTable
            // 
            this.AllEmployeeTable.AllowUserToOrderColumns = true;
            this.AllEmployeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllEmployeeTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.AllEmployeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployeeTable.Location = new System.Drawing.Point(51, 63);
            this.AllEmployeeTable.Name = "AllEmployeeTable";
            this.AllEmployeeTable.Size = new System.Drawing.Size(750, 381);
            this.AllEmployeeTable.TabIndex = 23;
            // 
            // buttonExitEmployeeSt
            // 
            this.buttonExitEmployeeSt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonExitEmployeeSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitEmployeeSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitEmployeeSt.ForeColor = System.Drawing.Color.White;
            this.buttonExitEmployeeSt.Location = new System.Drawing.Point(799, 4);
            this.buttonExitEmployeeSt.Name = "buttonExitEmployeeSt";
            this.buttonExitEmployeeSt.Size = new System.Drawing.Size(57, 43);
            this.buttonExitEmployeeSt.TabIndex = 22;
            this.buttonExitEmployeeSt.Text = "X";
            this.buttonExitEmployeeSt.UseVisualStyleBackColor = true;
            this.buttonExitEmployeeSt.Click += new System.EventHandler(this.ButtonExitEmployeeSt_Click);
            // 
            // labelAllEmployee
            // 
            this.labelAllEmployee.AutoSize = true;
            this.labelAllEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAllEmployee.Location = new System.Drawing.Point(10, 18);
            this.labelAllEmployee.Name = "labelAllEmployee";
            this.labelAllEmployee.Size = new System.Drawing.Size(155, 29);
            this.labelAllEmployee.TabIndex = 21;
            this.labelAllEmployee.Text = "All Employee";
            // 
            // All_Employee_Working
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.AllEmployeeTable);
            this.Controls.Add(this.buttonExitEmployeeSt);
            this.Controls.Add(this.labelAllEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "All_Employee_Working";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Employee_Working";
            this.Load += new System.EventHandler(this.All_Employee_Working_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllEmployeeTable;
        private System.Windows.Forms.Button buttonExitEmployeeSt;
        private System.Windows.Forms.Label labelAllEmployee;
    }
}