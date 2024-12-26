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
    public partial class SalesControl : UserControl
    {
        private int UID;
        string oldPName;
        int oldQuantity;
        int saleIDD;
        public SalesControl(int a)
        {
            UID = a;
            InitializeComponent();
            dgvSales.CellContentClick += dgvSales_CellContentClick;
            LoadSales();
            
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions"; // Column header text
            btnColumn.Text = "Delete"; // Text displayed on the button
            btnColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn.Name = "btnDelete"; // Name of the column
            dgvSales.Columns.Add(btnColumn);
            

        }

        private void LoadSales()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable sales = dbHelper.GetSalesByUser(UID);

            dgvSales.ColumnHeadersHeight = 50;

            if (sales != null)
            {
                dgvSales.DataSource = sales;
            }
            else
            {
                MessageBox.Show("Failed to load sales.");
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            pnlAddSale.Visible = true;
            LoadUserProducts();
            btnAddSale.Enabled = false;
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlAddSale.Visible = false;
            btnAddSale.Enabled = true;

        }

        private void btnAddSaleP_Click(object sender, EventArgs e)
        {
            string productName = cmbProdName.Text.Trim();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            decimal salePrice = Convert.ToDecimal(txtSalePrice.Text);

            DatabaseHelper dbHelper = new DatabaseHelper();
            if (dbHelper.AddSale(UID, productName, quantity, salePrice) && dbHelper.DecreaseQuantityOfProduct(UID, quantity,productName))
            {
                MessageBox.Show("Sale added successfully.");
                LoadSales(); // Listeyi yenile
            }
            else
            {
                MessageBox.Show("Failed to add sale.");
            }
        }

        private void LoadUserProducts()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetUserProducts(UID);

            if (categories != null)
            {
                cmbProdName.DataSource = categories; // Bind DataTable to ComboBox
                cmbProdName.DisplayMember = "ProductName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }
        }

        private void LoadUserProducts2()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetUserProducts(UID);

            if (categories != null)
            {
                cmbUpProdName.DataSource = categories; // Bind DataTable to ComboBox
                cmbUpProdName.DisplayMember = "ProductName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button column
            if (e.ColumnIndex == dgvSales.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                DatabaseHelper databaseHelper = new DatabaseHelper();
                int saleID = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["SaleID"].Value);
                string pName = Convert.ToString(dgvSales.Rows[e.RowIndex].Cells["ProductName"].Value);
                int numberQ = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["Quantity"].Value);
                databaseHelper.DeleteSale(saleID); // Call the delete action
                databaseHelper.IncreaseQuantityOfProduct(UID, numberQ, pName);
                LoadSales();

            }
            
        }

        private void btnUpSale_Click(object sender, EventArgs e)
        {
            if(dgvSales.SelectedRows.Count > 0)
            {
                string newPName = cmbUpProdName.Text.Trim();
                int newQuantity = Convert.ToInt32(txtUpQuantity.Text.Trim());
                int salePrice = Convert.ToInt32(txtUpSalePrice.Text.Trim());
                
                
                LoadSales();

                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.UpdateSaleWithProductAdjustment(saleIDD, oldPName, newPName, oldQuantity, newQuantity, salePrice, UID))
                {
                    MessageBox.Show("Sales updated successfully.");
                    LoadSales(); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Failed to update sales.");
                }
            }
            else
            {
                MessageBox.Show("Please select a sale to update.");
            }


        }
    }
}
