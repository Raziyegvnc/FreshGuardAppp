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
    public partial class frmMain : Sample
    {
        private int IDint = 0;
        private string Username = "";
        
        public frmMain(string a, int b)
        {
            IDint = b;
            Username = a;
            InitializeComponent();
            lblUser.Text = a;
            CenterLabelInPanel(guna2Panel3, lblUser);
            this.rbtnHome.CheckedChanged += new System.EventHandler(this.rbtnHome_CheckedChanged);
            this.rbtnCategory.CheckedChanged += new System.EventHandler(this.rbtnCategory_CheckedChanged);
            this.rbtnProducts.CheckedChanged += new System.EventHandler(this.rbtnProducts_CheckedChanged);
            this.rbtnUsers.CheckedChanged += new System.EventHandler(this.rbtnUsers_CheckedChanged);
            this.rbtnSupplier.CheckedChanged += new System.EventHandler(this.rbtnSupplier_CheckedChanged);
            this.rbtnPurchases.CheckedChanged += new System.EventHandler(this.rbtnPurchases_CheckedChanged);
            this.rbtnSales.CheckedChanged += new System.EventHandler(this.rbtnSales_CheckedChanged);
            this.rbtnReport.CheckedChanged += new System.EventHandler(this.rbtnReport_CheckedChanged);
            LoadControl(new HomeControl());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            btnMax.PerformClick();
            LoadControl(new HomeControl()); // Varsayılan olarak HomeControl yüklenecek
        }

        private void LoadControl(UserControl control)
        {
            pnlMain.Controls.Clear(); // Panel'in önceki içeriğini temizle
            control.Dock = DockStyle.Fill; // UserControl paneli dolduracak şekilde ayarla
            pnlMain.Controls.Add(control); // UserControl'ü panele ekle
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnHome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHome.Checked)
            {
                LoadControl(new HomeControl()); // HomeControl yüklenecek
            }
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCategory.Checked)
            {
                LoadControl(new CategoryControl(IDint, Username)); // CategoryControl yüklenecek
            }
        }

        private void rbtnProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProducts.Checked)
            {
                LoadControl(new ProductControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void rbtnUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsers.Checked)
            {
                LoadControl(new UsersControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void rbtnSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSupplier.Checked)
            {
                LoadControl(new SupplierControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void rbtnPurchases_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPurchases.Checked)
            {
                LoadControl(new PurchasesControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void rbtnSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSales.Checked)
            {
                LoadControl(new SalesControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void rbtnReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReport.Checked)
            {
                LoadControl(new ReportControl(IDint)); // ProductControl yüklenecek
            }
        }

        private void CenterLabelInPanel(Panel panel, Label label)
        {
            // Label'ın genişlik ve yükseklik özelliklerini yeniden hesapla
            label.AutoSize = true; // Label'ın genişliğinin metne göre ayarlanmasını sağla
            label.Refresh(); // Değişiklikleri hemen uygula

            // Ortalamak için yeni konum hesapla
            int x = (panel.Width - label.Width) / 2; // Yatayda ortala
            int y = label.Location.Y; // Dikeyde ortala

            // Yeni konumu ata
            label.Location = new Point(x, y);
        }
    }
}
