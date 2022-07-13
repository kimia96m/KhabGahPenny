namespace KhabGahe_Penny
{
    partial class LeavedStudent
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
            this.buttonExitLeftSt = new System.Windows.Forms.Button();
            this.labelAllLeftedStudents = new System.Windows.Forms.Label();
            this.AllStudentsLeftTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsLeftTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExitLeftSt
            // 
            this.buttonExitLeftSt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonExitLeftSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitLeftSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitLeftSt.ForeColor = System.Drawing.Color.White;
            this.buttonExitLeftSt.Location = new System.Drawing.Point(801, 3);
            this.buttonExitLeftSt.Name = "buttonExitLeftSt";
            this.buttonExitLeftSt.Size = new System.Drawing.Size(57, 43);
            this.buttonExitLeftSt.TabIndex = 20;
            this.buttonExitLeftSt.Text = "X";
            this.buttonExitLeftSt.UseVisualStyleBackColor = true;
            this.buttonExitLeftSt.Click += new System.EventHandler(this.ButtonExitLeftSt_Click);
            // 
            // labelAllLeftedStudents
            // 
            this.labelAllLeftedStudents.AutoSize = true;
            this.labelAllLeftedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllLeftedStudents.ForeColor = System.Drawing.Color.White;
            this.labelAllLeftedStudents.Location = new System.Drawing.Point(25, 17);
            this.labelAllLeftedStudents.Name = "labelAllLeftedStudents";
            this.labelAllLeftedStudents.Size = new System.Drawing.Size(185, 29);
            this.labelAllLeftedStudents.TabIndex = 21;
            this.labelAllLeftedStudents.Text = "All Students Left";
            // 
            // AllStudentsLeftTable
            // 
            this.AllStudentsLeftTable.AllowUserToOrderColumns = true;
            this.AllStudentsLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllStudentsLeftTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.AllStudentsLeftTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllStudentsLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStudentsLeftTable.Location = new System.Drawing.Point(54, 75);
            this.AllStudentsLeftTable.Name = "AllStudentsLeftTable";
            this.AllStudentsLeftTable.Size = new System.Drawing.Size(750, 381);
            this.AllStudentsLeftTable.TabIndex = 22;
            // 
            // LeavedStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.AllStudentsLeftTable);
            this.Controls.Add(this.labelAllLeftedStudents);
            this.Controls.Add(this.buttonExitLeftSt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeavedStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeavedStudent";
            this.Load += new System.EventHandler(this.LeavedStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsLeftTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitLeftSt;
        private System.Windows.Forms.Label labelAllLeftedStudents;
        private System.Windows.Forms.DataGridView AllStudentsLeftTable;
    }
}