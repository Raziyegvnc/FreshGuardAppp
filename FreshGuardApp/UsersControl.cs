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
    public partial class UsersControl : UserControl
    {
        private int UID;
        private int oldID;
        public UsersControl(int userID)
        {
            UID = userID;
            InitializeComponent();
            LoadInventoryManagers();
            AddButtonColumns();

            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
        }

        private void LoadInventoryManagers()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable managers = dbHelper.GetInventoryManagers();

            dgvUsers.ColumnHeadersHeight = 50;

            if (managers != null)
            {
                dgvUsers.DataSource = managers;
            }
            else
            {
                MessageBox.Show("Failed to load inventory managers.");
            }
        }

        private void btnAddInvManager_Click(object sender, EventArgs e)
        {
            int managerID = Convert.ToInt32(txtManID.Text);
            string password = txtManPass.Text.Trim();

            if (!string.IsNullOrEmpty(password))
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.AddInventoryManager(UID, password ,managerID))
                {
                    MessageBox.Show("Inventory Manager added successfully.");
                    LoadInventoryManagers(); // Refresh the list
                }
                else
                {
                    MessageBox.Show("Failed to add Inventory Manager.");
                }
            }
            else
            {
                MessageBox.Show("Password cannot be empty.");
            }
        }

        private void btnAddInvMan_Click(object sender, EventArgs e)
        {
            pnlAddInvMan.Visible = true;
            btnAddInvMan.Enabled = false;
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlAddInvMan.Visible = false;
            btnAddInvMan.Enabled = true;
        }


        private void AddButtonColumns()
        {
            // Update butonu ekle
            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
            updateButton.Name = "btnUpdate";
            updateButton.HeaderText = "Update";
            updateButton.Text = "Update";
            updateButton.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Add(updateButton);

            // Delete butonu ekle
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btnDelete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Add(deleteButton);
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseHelper dh = new DatabaseHelper();
            if (e.RowIndex >= 0) // Başlık satırına tıklamayı önle
            {
                // Update butonuna tıklanmışsa
                if (dgvUsers.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    int managerId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["ManagerID"].Value);
                    string ManPass = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["InventoryManPass"].Value);
                    pnlUpdateUsers.Visible = true;
                    btnAddInvMan.Enabled = false;
                    txtUpInvManID.Text = managerId.ToString();
                    txtUpInvManPass.Text = ManPass;
                    oldID = Convert.ToInt32(txtUpInvManID.Text);
                }
                // Delete butonuna tıklanmışsa
                else if (dgvUsers.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    int managerId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["ManagerID"].Value);
                    dh.DeleteInventoryManager(managerId, UID);
                }
            }
        }



        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string pass = txtUpInvManPass.Text;
            
            if (string.IsNullOrWhiteSpace(txtUpInvManID.Text) || string.IsNullOrWhiteSpace(txtUpInvManPass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DatabaseHelper dh = new DatabaseHelper();
            dh.UpdateInventoryManager(oldID, Convert.ToInt32(txtUpInvManID.Text), UID, txtUpInvManPass.Text);
            LoadInventoryManagers();
        }


        private void btnUpdateBack_Click(object sender, EventArgs e)
        {
            pnlUpdateUsers.Visible=false;
            btnAddInvMan.Enabled = true;
            LoadInventoryManagers();
        }
    }
}
