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
    public partial class ProductControl : UserControl
    {
        private int UID = 0;
        public ProductControl(int ID)
        {
            UID = ID;
            InitializeComponent();
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            LoadProducts();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions"; // Column header text
            btnColumn.Text = "Update"; // Text displayed on the button
            btnColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn.Name = "btnUpdate"; // Name of the column
            dgvProducts.Columns.Add(btnColumn);
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.HeaderText = "Actions"; // Column header text
            btnColumn2.Text = "Delete"; // Text displayed on the button
            btnColumn2.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn2.Name = "btnDelete"; // Name of the column
            dgvProducts.Columns.Add(btnColumn2);
        }

        private void LoadProducts()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable products = dbHelper.GetProducts(UID);
            dgvProducts.ColumnHeadersHeight = 50;
            if (products != null)
            {
                dgvProducts.DataSource = products;

                // Add Barcode column if not present
                if (!dgvProducts.Columns.Contains("Barcode"))
                {
                    dgvProducts.Columns["Barcode"].HeaderText = "Barcode";
                }

                // Add Image column if not present
                if (!dgvProducts.Columns.Contains("ProductImage"))
                {
                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                    imgColumn.HeaderText = "Image";
                    imgColumn.Name = "ProductImage";
                    imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgvProducts.Columns.Add(imgColumn);
                }

                // Load images into the grid
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    byte[] imageBytes = row.Cells["Image"].Value as byte[];
                    row.Cells["ProductImage"].Value = ConvertByteArrayToImage(imageBytes);
                }
            }
        }

        private Image ConvertByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoadUserCategories()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetUserCategories(UID);

            if (categories != null)
            {
                cmbCategory.DataSource = categories; // Bind DataTable to ComboBox
                cmbCategory.DisplayMember = "CategoryName"; // Display category name
                
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
                cmbUpCat.DataSource = categories; // Bind DataTable to ComboBox
                cmbUpCat.DisplayMember = "CategoryName"; // Display category name

            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlAdd.Visible = true;
            LoadUserCategories();

        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible=false;
            pnlMain.Enabled = true;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            string productName = txtProdName.Text.Trim();
            string productCategory = cmbCategory.Text.Trim();
            int quantity = int.TryParse(txtQuan.Text.Trim(), out int result) ? result : 0;
            DateTime a = dtpAddProduct.Value;

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
                if (dbHelper.AddProductWithBarcode(UID, productName, productCategory, quantity, imageBytes,a))
                {
                    MessageBox.Show("Product added successfully.");
                    LoadProducts(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button column
            if (e.ColumnIndex == dgvProducts.Columns["btnUpdate"].Index && e.RowIndex >= 0)
            {

                pnlMain.Enabled = false;
                pnlUpdate.Visible = true;

                DatabaseHelper dbHelper = new DatabaseHelper();
                int productID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
                List<string> abc = dbHelper.GetProduct(UID, productID);

                
                txtProdUpName.Text = abc[0].ToString();
                LoadUserCategories2();
                //cmbUpCat.AccessibleName = abc[1].ToString();
                txtUpQuan.Text = abc[2].ToString();
                //dtpProduct.Value = dbHelper.
                dtpProduct.Value = dbHelper.GetProductExpirationDate(UID, productID);
                
            }
            else if (e.ColumnIndex == dgvProducts.Columns["btnDelete"].Index)
            {

                int productID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.DeleteProduct(productID);
                LoadProducts();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int productID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
                int newQantity = Convert.ToInt32(txtUpQuan.Text);
                string newUpCat = cmbUpCat.Text;
                string newProductName = txtProdUpName.Text.Trim();
                DateTime a = dtpProduct.Value;

                if (!string.IsNullOrEmpty(newProductName))
                {
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    if (dbHelper.UpdateProductWithImage(productID, newProductName, newUpCat, newQantity, a))
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi.");
                        txtProdUpName.Clear();
                        txtUpQuan.Clear();
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Ürün güncellenirken hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Ürün adı boş olamaz.");
                }
            }
            else
            {
                MessageBox.Show("Düzenlemek için bir Product seçin.");
            }
            
        }

        private void btnUpBack_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
            pnlMain.Update();
            pnlMain.Enabled = true;
        }
    }

}
