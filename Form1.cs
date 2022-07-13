using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhabGahe_Penny
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(enterUserNameInput.Text=="Admin" && enterPasswordInput.Text == "mypassword")
            {
                Hide();
                Dashboard db = new Dashboard();
                db.Show();  
            }
            else
            {
                enterPasswordInput.Clear();
            }
        }

        private void ButtonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.BackColor = System.Drawing.Color.FromArgb(215, 69, 50);
            buttonLogin.ForeColor = Color.White;
            
        }

        private void ButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = System.Drawing.Color.FromArgb(215, 69, 50);
            buttonLogin.BackColor = Color.White;
            
        }
    }
}
