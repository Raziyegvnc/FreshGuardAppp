using FreshGuardApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGuardApp
{
    public partial class PurchasesControl : UserControl
    {
        private int UID;
        public PurchasesControl(int a)
        {
            UID = a;
            InitializeComponent();
            dgvPurchases.CellContentClick += dgvPurchases_CellContentClick;
            LoadPurchases();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions"; // Column header text
            btnColumn.Text = "Update"; // Text displayed on the button
            btnColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn.Name = "btnUpdate"; // Name of the column
            dgvPurchases.Columns.Add(btnColumn);
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.HeaderText = "Actions"; // Column header text
            btnColumn2.Text = "Delete"; // Text displayed on the button
            btnColumn2.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn2.Name = "btnDelete"; // Name of the column
            dgvPurchases.Columns.Add(btnColumn2);

        }

        private void LoadPurchases()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable purchases = dbHelper.GetPurchasesByUser(UID);

            dgvPurchases.ColumnHeadersHeight = 50;

            if (purchases != null)
            {
                dgvPurchases.DataSource = purchases;
            }
            else
            {
                MessageBox.Show("Failed to load purchases.");
            }
        }

        private void btnAddPur_Click(object sender, EventArgs e)
        {
            
            pnlPurAdd.Visible = true;
            LoadUserCategories();
            LoadUserSuppliers();
            btnAddPur.Enabled = false;
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlPurAdd.Visible = false;
            btnAddPur.Enabled = true;
        }

        private void btnPurAdd_Click(object sender, EventArgs e)
        {
            string supplierName = cmbSupplier.Text.Trim(); // ComboBox'tan seçilen SupplierName
            string productName = txtProdName.Text.Trim();
            string productCategory = cmbProdCat.Text.Trim();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            DateTime dateTime = dtpExp.Value;

            byte[] imageBytes = null;

            // Select image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageBytes = File.ReadAllBytes(openFileDialog.FileName); // Convert image to byte[]
                }
            }

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                // Now you can use the 'image' object, for example, display or save it
                image.Save("output.jpg"); // Saving the image as a file
                //pbProd.Image(image);
                Console.WriteLine("Image converted and saved.");
            }

            

            if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(productCategory))
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.AddPurchase(UID, supplierName, productName, quantity, price) && dbHelper.AddProductWithBarcode(UID, productName, productCategory, quantity, imageBytes, dateTime))
                {
                    MessageBox.Show("Purchase added successfully.");
                    LoadPurchases(); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Failed to add purchase.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button column
            if (e.ColumnIndex == dgvPurchases.Columns["btnUpdate"].Index && e.RowIndex >= 0)
            {
                
                pnlUpPur.Visible = true;
                btnAddPur.Enabled = false;
                int purID = Convert.ToInt32(dgvPurchases.Rows[e.RowIndex].Cells["PurchaseID"].Value);
                txtUpPurProdName.Text = Convert.ToString(dgvPurchases.Rows[e.RowIndex].Cells["ProductName"].Value);
                txtUpPurQuantity.Text = Convert.ToString(dgvPurchases.Rows[e.RowIndex].Cells["Quantity"].Value);
                txtUpPurPrice.Text = Convert.ToString(dgvPurchases.Rows[e.RowIndex].Cells["Price"].Value);
                LoadUserCategories2();
                LoadUserSuppliers2();

            }
            else if (e.ColumnIndex == dgvPurchases.Columns["btnDelete"].Index)
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                int PurchaseID = Convert.ToInt32(dgvPurchases.Rows[e.RowIndex].Cells["PurchaseID"].Value);
                string pName = Convert.ToString(dgvPurchases.Rows[e.RowIndex].Cells["ProductName"].Value);

                databaseHelper.DeletePurchase(PurchaseID); // Call the delete action
                databaseHelper.DeleteProductbyName(databaseHelper.GetProdIDFromProdName(UID,pName), pName);
                LoadPurchases();
            }
        }

        private void btnUpdatePurc_Click(object sender, EventArgs e)
        {
            if (dgvPurchases.SelectedRows.Count > 0)
            {
                int purchaseId = Convert.ToInt32(dgvPurchases.SelectedRows[0].Cells["PurchaseID"].Value);
                string supplierName = cmbUpPurSupplier.Text.Trim();
                string productName = txtUpPurProdName.Text.Trim();
                int quantity = Convert.ToInt32(txtUpPurQuantity.Text);
                decimal price = Convert.ToDecimal(txtUpPurPrice.Text);
                DateTime date = dtpUpPurExp.Value;
                string productCategory = cmbUpPurProdCat.Text.Trim();


                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.UpdatePurchase(purchaseId, supplierName, productName, quantity, price) && dbHelper.UpdateProductWithImage(dbHelper.GetProdIDFromProdName(UID,productName),productName,productCategory,quantity,date))
                {
                    MessageBox.Show("Purchase updated successfully.");
                    LoadPurchases(); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Failed to update purchase.");
                }
            }
            else
            {
                MessageBox.Show("Please select a purchase to update.");
            }
        }

        private void btnUpBack_Click(object sender, EventArgs e)
        {
            pnlUpPur.Visible = false;
            btnAddPur.Enabled = true;
        }

        private void LoadUserCategories()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetUserCategories(UID);

            if (categories != null)
            {
                cmbProdCat.DataSource = categories; // Bind DataTable to ComboBox
                cmbProdCat.DisplayMember = "CategoryName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }
        }
        private void LoadUserCategories2()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetUserCategories(UID);

            if (categories != null)
            {
                cmbUpPurProdCat.DataSource = categories; // Bind DataTable to ComboBox
                cmbUpPurProdCat.DisplayMember = "CategoryName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }
        }

        private void LoadUserSuppliers()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable suppliers = dbHelper.GetUserSuppliers(UID);

            if (suppliers != null)
            {
                cmbSupplier.DataSource = suppliers; // Bind DataTable to ComboBox
                cmbSupplier.DisplayMember = "SupplierName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load suppliers.");
            }
        }
        private void LoadUserSuppliers2()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable suppliers = dbHelper.GetUserSuppliers(UID);

            if (suppliers != null)
            {
                cmbUpPurSupplier.DataSource = suppliers; // Bind DataTable to ComboBox
                cmbUpPurSupplier.DisplayMember = "SupplierName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load suppliers.");
            }
        }
    }
}
