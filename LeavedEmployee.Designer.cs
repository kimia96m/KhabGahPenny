namespace KhabGahe_Penny
{
    partial class LeavedEmployee
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
            this.AllEmployeeLeftTable = new System.Windows.Forms.DataGridView();
            this.buttonExitEmployeeLeft = new System.Windows.Forms.Button();
            this.labelAllEmployeeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeLeftTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllEmployeeLeftTable
            // 
            this.AllEmployeeLeftTable.AllowUserToOrderColumns = true;
            this.AllEmployeeLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllEmployeeLeftTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.AllEmployeeLeftTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllEmployeeLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmployeeLeftTable.Location = new System.Drawing.Point(50, 69);
            this.AllEmployeeLeftTable.Name = "AllEmployeeLeftTable";
            this.AllEmployeeLeftTable.Size = new System.Drawing.Size(750, 381);
            this.AllEmployeeLeftTable.TabIndex = 26;
            // 
            // buttonExitEmployeeLeft
            // 
            this.buttonExitEmployeeLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.buttonExitEmployeeLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitEmployeeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitEmployeeLeft.ForeColor = System.Drawing.Color.White;
            this.buttonExitEmployeeLeft.Location = new System.Drawing.Point(800, 3);
            this.buttonExitEmployeeLeft.Name = "buttonExitEmployeeLeft";
            this.buttonExitEmployeeLeft.Size = new System.Drawing.Size(57, 43);
            this.buttonExitEmployeeLeft.TabIndex = 25;
            this.buttonExitEmployeeLeft.Text = "X";
            this.buttonExitEmployeeLeft.UseVisualStyleBackColor = true;
            this.buttonExitEmployeeLeft.Click += new System.EventHandler(this.ButtonExitEmployeeLeft_Click);
            // 
            // labelAllEmployeeLeft
            // 
            this.labelAllEmployeeLeft.AutoSize = true;
            this.labelAllEmployeeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllEmployeeLeft.ForeColor = System.Drawing.Color.White;
            this.labelAllEmployeeLeft.Location = new System.Drawing.Point(30, 17);
            this.labelAllEmployeeLeft.Name = "labelAllEmployeeLeft";
            this.labelAllEmployeeLeft.Size = new System.Drawing.Size(195, 29);
            this.labelAllEmployeeLeft.TabIndex = 24;
            this.labelAllEmployeeLeft.Text = "Lefted Employee";
            // 
            // LeavedEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.AllEmployeeLeftTable);
            this.Controls.Add(this.buttonExitEmployeeLeft);
            this.Controls.Add(this.labelAllEmployeeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeavedEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeavedEmployee";
            this.Load += new System.EventHandler(this.LeavedEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployeeLeftTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllEmployeeLeftTable;
        private System.Windows.Forms.Button buttonExitEmployeeLeft;
        private System.Windows.Forms.Label labelAllEmployeeLeft;
    }
}