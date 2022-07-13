using System.Drawing;
using System.Drawing.Text;

namespace KhabGahe_Penny
{
    partial class Form1
    {
        public void AddMyFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Mj_Ojan.Length;
            byte[] fontdata = Properties.Resources.Mj_Ojan;
            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            LoginLabel.Font = new Font(pfc.Families[0], LoginLabel.Font.Size);
        }

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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.enterUserNameInput = new System.Windows.Forms.TextBox();
            this.enterPasswordInput = new System.Windows.Forms.TextBox();
            this.labelEnterUserNameInput = new System.Windows.Forms.Label();
            this.labelEnterPasswordInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabelّForgotPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(158, 43);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(103, 37);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "وارد شوید";
            this.LoginLabel.UseCompatibleTextRendering = true;
            // 
            // enterUserNameInput
            // 
            this.enterUserNameInput.BackColor = System.Drawing.Color.MistyRose;
            this.enterUserNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterUserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUserNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(69)))), ((int)(((byte)(50)))));
            this.enterUserNameInput.Location = new System.Drawing.Point(49, 130);
            this.enterUserNameInput.Name = "enterUserNameInput";
            this.enterUserNameInput.Size = new System.Drawing.Size(204, 31);
            this.enterUserNameInput.TabIndex = 1;
            this.enterUserNameInput.Text = "Admin";
            // 
            // enterPasswordInput
            // 
            this.enterPasswordInput.BackColor = System.Drawing.Color.MistyRose;
            this.enterPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(69)))), ((int)(((byte)(50)))));
            this.enterPasswordInput.Location = new System.Drawing.Point(49, 192);
            this.enterPasswordInput.Name = "enterPasswordInput";
            this.enterPasswordInput.PasswordChar = '*';
            this.enterPasswordInput.Size = new System.Drawing.Size(203, 31);
            this.enterPasswordInput.TabIndex = 2;
            this.enterPasswordInput.Text = "mypassword";
            // 
            // labelEnterUserNameInput
            // 
            this.labelEnterUserNameInput.AutoSize = true;
            this.labelEnterUserNameInput.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterUserNameInput.ForeColor = System.Drawing.Color.White;
            this.labelEnterUserNameInput.Location = new System.Drawing.Point(273, 132);
            this.labelEnterUserNameInput.Name = "labelEnterUserNameInput";
            this.labelEnterUserNameInput.Size = new System.Drawing.Size(75, 22);
            this.labelEnterUserNameInput.TabIndex = 3;
            this.labelEnterUserNameInput.Text = "کلمه کاربری";
            // 
            // labelEnterPasswordInput
            // 
            this.labelEnterPasswordInput.AutoSize = true;
            this.labelEnterPasswordInput.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPasswordInput.ForeColor = System.Drawing.Color.White;
            this.labelEnterPasswordInput.Location = new System.Drawing.Point(286, 192);
            this.labelEnterPasswordInput.Name = "labelEnterPasswordInput";
            this.labelEnterPasswordInput.Size = new System.Drawing.Size(62, 22);
            this.labelEnterPasswordInput.TabIndex = 4;
            this.labelEnterPasswordInput.Text = "رمز عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(133, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "به خوابگاه پنی خوش آمدید";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(69)))), ((int)(((byte)(50)))));
            this.buttonLogin.Location = new System.Drawing.Point(147, 260);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(114, 42);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "ورود";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_MouseLeave);
            this.buttonLogin.MouseHover += new System.EventHandler(this.ButtonLogin_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.White;
            this.linkLabelSignUp.Location = new System.Drawing.Point(244, 324);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(45, 16);
            this.linkLabelSignUp.TabIndex = 9;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "ثبت نام ";
            this.linkLabelSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // linkLabelّForgotPassword
            // 
            this.linkLabelّForgotPassword.AutoSize = true;
            this.linkLabelّForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelّForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelّForgotPassword.LinkColor = System.Drawing.Color.White;
            this.linkLabelّForgotPassword.Location = new System.Drawing.Point(80, 324);
            this.linkLabelّForgotPassword.Name = "linkLabelّForgotPassword";
            this.linkLabelّForgotPassword.Size = new System.Drawing.Size(147, 16);
            this.linkLabelّForgotPassword.TabIndex = 10;
            this.linkLabelّForgotPassword.TabStop = true;
            this.linkLabelّForgotPassword.Text = "رمز عبور را فراموش کرده ام";
            this.linkLabelّForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(69)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(384, 377);
            this.Controls.Add(this.linkLabelّForgotPassword);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEnterPasswordInput);
            this.Controls.Add(this.labelEnterUserNameInput);
            this.Controls.Add(this.enterPasswordInput);
            this.Controls.Add(this.enterUserNameInput);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox enterUserNameInput;
        private System.Windows.Forms.TextBox enterPasswordInput;
        private System.Windows.Forms.Label labelEnterUserNameInput;
        private System.Windows.Forms.Label labelEnterPasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.LinkLabel linkLabelّForgotPassword;
    }
}

