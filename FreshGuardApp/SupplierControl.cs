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
    public partial class SupplierControl : UserControl
    {
        private int UID;
        public SupplierControl(int a)
        {
            UID = a;
            InitializeComponent();
            dgvSupplier.CellContentClick += dgvSupplier_CellContentClick;
            LoadSuppliers();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions"; // Column header text
            btnColumn.Text = "Update"; // Text displayed on the button
            btnColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn.Name = "btnUpdate"; // Name of the column
            dgvSupplier.Columns.Add(btnColumn);
            DataGridViewButtonColumn btnColumn2 = new DataGridViewButtonColumn();
            btnColumn2.HeaderText = "Actions"; // Column header text
            btnColumn2.Text = "Delete"; // Text displayed on the button
            btnColumn2.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            btnColumn2.Name = "btnDelete"; // Name of the column
            dgvSupplier.Columns.Add(btnColumn2);

        }

        private void LoadSuppliers()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable suppliers = dbHelper.GetSuppliersByUser(UID);

            dgvSupplier.ColumnHeadersHeight = 50;

            if (suppliers != null)
            {
                dgvSupplier.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show("Failed to load suppliers.");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupName.Text.Trim();
            string contactInfo = txtSupCon.Text.Trim();
            string address = txtSupAddress.Text.Trim();

            if (!string.IsNullOrEmpty(supplierName))
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.AddSupplier(UID, supplierName, contactInfo, address))
                {
                    MessageBox.Show("Supplier added successfully.");
                    LoadSuppliers(); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.");
                }
            }
            else
            {
                MessageBox.Show("Supplier name cannot be empty.");
            }

        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlAddSup.Visible = false;
            btnAddSupp.Enabled = true;
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            pnlAddSup.Visible = true;
            btnAddSupp.Enabled = false;
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button column
            if (e.ColumnIndex == dgvSupplier.Columns["btnUpdate"].Index && e.RowIndex >= 0)
            {
                pnlUpSup.Visible = true;
                btnAddSupp.Enabled = false;
                int supID = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells["SupplierID"].Value);
                txtUpSupName.Text = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells["SupplierName"].Value);
                txtUpSupCon.Text = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells["ContactInfo"].Value);
                txtUpSupAddress.Text = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells["Address"].Value);

            }
            else if (e.ColumnIndex == dgvSupplier.Columns["btnDelete"].Index)
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                int SupplierID = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells["SupplierID"].Value);
                databaseHelper.DeleteSupplier(SupplierID, UID); // Call the delete action
                LoadSuppliers();
            }
        }

        private void btnSupUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                int supplierId = Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells["SupplierID"].Value);
                string supplierName = txtUpSupName.Text.Trim();
                string contactInfo = txtUpSupCon.Text.Trim();
                string address = txtUpSupAddress.Text.Trim();

                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.UpdateSupplier(supplierId, UID, supplierName, contactInfo, address))
                {
                    MessageBox.Show("Supplier updated successfully.");
                    LoadSuppliers(); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Failed to update supplier.");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to update.");
            }
        }

        private void btnSupBack_Click(object sender, EventArgs e)
        {
            pnlUpSup.Visible = false;
            btnAddSupp.Enabled = true;
        }
    }
}
