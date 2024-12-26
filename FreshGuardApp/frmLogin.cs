using FreshGuardApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGuardApp
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            int userID = dbHelper.LoginUser(txtUser.Text, txtPassword.Text);

            if (userID > 0)
            {
                MessageBox.Show($"Login successful! Welcome, User ID: {userID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to the next form or dashboard
                this.Hide();
                frmInsideLogin frm = new frmInsideLogin(txtUser.Text, userID);
                frm.Show();
            }
            else if (userID == -1)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("An error occurred during login. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToCharity_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharityLogin frm = new CharityLogin();
            frm.Show();
        }
    }
}
