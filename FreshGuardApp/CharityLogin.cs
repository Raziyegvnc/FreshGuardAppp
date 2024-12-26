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
    public partial class CharityLogin : Sample
    {
        public CharityLogin()
        {
            InitializeComponent();
        }

        private void btnGoCharityRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharityRegister frm = new CharityRegister();
            frm.Show();
        }

        private void btnCharityLogin_Click(object sender, EventArgs e)
        {
            int charityId;
            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isLoggedIn = dbHelper.LoginCharity(txtCharityUsername.Text.Trim(), txtCharityPassword.Text.Trim(), out charityId);

            if (isLoggedIn)
            {
                MessageBox.Show("Login successful!");
                // charityId ile giriş yapan kullanıcı bilgilerini yükleyebilirsiniz.
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void btnCharityBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
