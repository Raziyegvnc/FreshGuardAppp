using FreshGuardApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace FreshGuardApp
{
    public partial class frmInsideLogin : Sample
    {
        private string ab = "";
        private int IDint = 0;
        public frmInsideLogin(string a, int b)
        {
            ab = a;
            IDint = b;
            InitializeComponent();
            CB1.CheckedChanged += CheckBox_CheckedChanged;
            CB2.CheckedChanged += CheckBox_CheckedChanged;
        }
        
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox current = sender as CheckBox;

            if (current == CB1 && CB1.Checked)
            {
                CB2.Checked = false;
            }
            else if (current == CB2 && CB2.Checked)
            {
                CB1.Checked = false;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CB1.Checked && !CB2.Checked)
            {
                MessageBox.Show("Please check one of the boxes");
            }
            else if (CB1.Checked)
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string username = txtUser.Text;
                string password = txtPassword.Text;

                if (dbHelper.StoreManInsideLog(username, password, out DataRow userData))
                {
                    Console.WriteLine("Store Manager girişi başarılı!");
                    Console.WriteLine($"Kullanıcı ID: {userData["UserID"]}");
                    
                    this.Hide();
                    frmMain frm = new frmMain(ab,IDint);
                    frm.Show();

                }
                else
                {
                    Console.WriteLine("Store Manager girişi başarısız.");
                }
            }
            else if (CB2.Checked)
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                string username = txtUser.Text;
                string password = txtPassword.Text;

                if (dbHelper.InventoryManInsideLog(username, password, out DataRow userData))
                {
                    Console.WriteLine("Inventory Manager girişi başarılı!");
                    Console.WriteLine($"Kullanıcı ID: {userData["ManagerID"]}");
                    
                    this.Hide();
                    frmMain frm = new frmMain(ab,IDint);
                    frm.rbtnUsers.Enabled = false;
                    frm.rbtnReport.Enabled = false;
                    frm.Show();
                }
                else
                {
                    Console.WriteLine("Inventory Manager girişi başarısız.");
                }

            }
        }
    }
}
