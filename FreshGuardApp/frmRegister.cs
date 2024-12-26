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
    public partial class frmRegister : Sample
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            
           
            int result = dbHelper.RegisterUser(txtUser.Text, txtPassword.Text, txtEmail.Text);

            if (result != -1)
            {
                MessageBox.Show($"User registered successfully. User ID: {result}");
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm=new frmLogin();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
