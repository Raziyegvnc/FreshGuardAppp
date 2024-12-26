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
    public partial class CharityRegister : Sample
    {
        public CharityRegister()
        {
            InitializeComponent();
            LoadCities();

        }

        private void LoadCities()
        {
            List<string> cities = new List<string>(new string[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            cmbChaCity.DataSource = cities;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isRegistered = dbHelper.RegisterCharity(
                txtChaName.Text.Trim(),
                txtChaEmail.Text.Trim(),
                txtChaUsername.Text.Trim(),
                txtChaPassword.Text.Trim(),
                txtChaContactInfo.Text.Trim(),
                txtChaAddress.Text.Trim(),
                Convert.ToString(cmbChaCity.SelectedValue)
            );

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void btnRegisterBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharityLogin frm = new CharityLogin();
            frm.Show();
        }
    }
}
