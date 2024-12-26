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
    public partial class CategoryControl : UserControl
    {
        private int UID = 0;
        private string Username = "";
        public CategoryControl(int a, string b)
        {
            UID = a;
            Username = b;
            InitializeComponent();
            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
            LoadCategories();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions"; // Column header text
            btnColumn.Text = "Update"; // Text displayed on the button
            btnColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn.Name = "btnUpdate"; // Name of the column
            dgvCategories.Columns.Add(btnColumn);
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.HeaderText = "Actions"; // Column header text
            btnColumn2.Text = "Delete"; // Text displayed on the button
            btnColumn2.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn2.Name = "btnDelete"; // Name of the column
            dgvCategories.Columns.Add(btnColumn2);

            
            
        }

        private void LoadCategories()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable categories = dbHelper.GetCategories(UID);
            

            if (categories != null)
            {
                dgvCategories.DataSource = categories;

                
                dgvCategories.ColumnHeadersHeight = 50;
                

            }
        }

        private void LoadControl(UserControl control)
        {
            pnlCC.Controls.Clear(); // Panel'in önceki içeriğini temizle
            control.Dock = DockStyle.Fill; // UserControl paneli dolduracak şekilde ayarla
            pnlCC.Controls.Add(control); // UserControl'ü panele ekle
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlCC.Enabled = false;
            pnlAC.Visible = true;

            
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlCC.Enabled = true;
            pnlCC.Update();
            pnlAC.Visible= false;

            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string categoryName = txtCat.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.AddCategory(UID, categoryName))
                {
                    MessageBox.Show("Kategori başarıyla eklendi.");
                    txtCat.Clear();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Kategori eklenirken hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz.");
            }
        }
        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button column
            if (e.ColumnIndex == dgvCategories.Columns["btnUpdate"].Index && e.RowIndex >= 0)
            {
                
                pnlCC.Enabled= false;
                pnlUpdate.Visible = true;
                txtUpdate.Text = "";
            }
            else if (e.ColumnIndex == dgvCategories.Columns["btnDelete"].Index)
            {
                
                int categoryId = Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["CategoryID"].Value);
                DeleteCategory(categoryId); // Call the delete action
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
                string newCategoryName = txtUpdate.Text.Trim();

                if (!string.IsNullOrEmpty(newCategoryName))
                {
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    if (dbHelper.UpdateCategory(UID, categoryId, newCategoryName))
                    {
                        MessageBox.Show("Kategori başarıyla güncellendi.");
                        txtUpdate.Clear();
                        LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Kategori güncellenirken hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Kategori adı boş olamaz.");
                }
            }
            else
            {
                MessageBox.Show("Düzenlemek için bir kategori seçin.");
            }
        }

        private void btnUpBack_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible= false;
            pnlCC.Update();
            pnlCC.Enabled=true;
        }

        private void DeleteCategory(int categoryId)
        {
            // Example action: Confirm and delete category
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Category ID: {categoryId}?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Call database helper to delete category
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.DeleteCategory(UID,categoryId))
                {
                    MessageBox.Show("Category deleted successfully.");
                    LoadCategories(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Failed to delete category.");
                }
            }
        }
    }
}
