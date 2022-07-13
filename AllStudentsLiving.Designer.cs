namespace KhabGahe_Penny
{
    partial class AllStudentsLiving
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
            this.labelAllStudents = new System.Windows.Forms.Label();
            this.buttonExitLivingSt = new System.Windows.Forms.Button();
            this.AllStudentsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAllStudents
            // 
            this.labelAllStudents.AutoSize = true;
            this.labelAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllStudents.ForeColor = System.Drawing.Color.White;
            this.labelAllStudents.Location = new System.Drawing.Point(12, 18);
            this.labelAllStudents.Name = "labelAllStudents";
            this.labelAllStudents.Size = new System.Drawing.Size(209, 29);
            this.labelAllStudents.TabIndex = 16;
            this.labelAllStudents.Text = "All Students Living";
            // 
            // buttonExitLivingSt
            // 
            this.buttonExitLivingSt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonExitLivingSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitLivingSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitLivingSt.ForeColor = System.Drawing.Color.White;
            this.buttonExitLivingSt.Location = new System.Drawing.Point(801, 4);
            this.buttonExitLivingSt.Name = "buttonExitLivingSt";
            this.buttonExitLivingSt.Size = new System.Drawing.Size(57, 43);
            this.buttonExitLivingSt.TabIndex = 19;
            this.buttonExitLivingSt.Text = "X";
            this.buttonExitLivingSt.UseVisualStyleBackColor = true;
            this.buttonExitLivingSt.Click += new System.EventHandler(this.ButtonExitLivingSt_Click);
            // 
            // AllStudentsTable
            // 
            this.AllStudentsTable.AllowUserToOrderColumns = true;
            this.AllStudentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllStudentsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.AllStudentsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllStudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStudentsTable.Location = new System.Drawing.Point(53, 63);
            this.AllStudentsTable.Name = "AllStudentsTable";
            this.AllStudentsTable.Size = new System.Drawing.Size(750, 381);
            this.AllStudentsTable.TabIndex = 20;
            // 
            // AllStudentsLiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.AllStudentsTable);
            this.Controls.Add(this.buttonExitLivingSt);
            this.Controls.Add(this.labelAllStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllStudentsLiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllStudentsLiving";
            this.Load += new System.EventHandler(this.AllStudentsLiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllStudents;
        private System.Windows.Forms.Button buttonExitLivingSt;
        private System.Windows.Forms.DataGridView AllStudentsTable;
    }
}