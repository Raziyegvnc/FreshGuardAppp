namespace FreshGuardApp
{
    partial class PurchasesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPurchases = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddPur = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPurAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.txtProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbProdCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpExp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPurAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUpPur = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdatePurc = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpUpPurExp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbUpPurProdCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbUpPurSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUpPurPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUpPurQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUpPurProdName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.pnlPurAdd.SuspendLayout();
            this.pnlUpPur.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchases
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchases.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPurchases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchases.Location = new System.Drawing.Point(72, 117);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.RowHeadersVisible = false;
            this.dgvPurchases.RowHeadersWidth = 51;
            this.dgvPurchases.RowTemplate.Height = 24;
            this.dgvPurchases.Size = new System.Drawing.Size(1044, 553);
            this.dgvPurchases.TabIndex = 0;
            this.dgvPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchases.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPurchases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchases.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvPurchases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPurchases.ThemeStyle.ReadOnly = false;
            this.dgvPurchases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchases.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvPurchases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchases.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPurchases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddPur
            // 
            this.btnAddPur.AutoRoundedCorners = true;
            this.btnAddPur.BorderRadius = 21;
            this.btnAddPur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPur.ForeColor = System.Drawing.Color.White;
            this.btnAddPur.Location = new System.Drawing.Point(936, 66);
            this.btnAddPur.Name = "btnAddPur";
            this.btnAddPur.Size = new System.Drawing.Size(180, 45);
            this.btnAddPur.TabIndex = 1;
            this.btnAddPur.Text = "Add Purchase";
            this.btnAddPur.Click += new System.EventHandler(this.btnAddPur_Click);
            // 
            // pnlPurAdd
            // 
            this.pnlPurAdd.Controls.Add(this.btnAddBack);
            this.pnlPurAdd.Controls.Add(this.btnPurAdd);
            this.pnlPurAdd.Controls.Add(this.label3);
            this.pnlPurAdd.Controls.Add(this.label2);
            this.pnlPurAdd.Controls.Add(this.label6);
            this.pnlPurAdd.Controls.Add(this.label5);
            this.pnlPurAdd.Controls.Add(this.label4);
            this.pnlPurAdd.Controls.Add(this.label1);
            this.pnlPurAdd.Controls.Add(this.dtpExp);
            this.pnlPurAdd.Controls.Add(this.cmbProdCat);
            this.pnlPurAdd.Controls.Add(this.cmbSupplier);
            this.pnlPurAdd.Controls.Add(this.txtPrice);
            this.pnlPurAdd.Controls.Add(this.txtQuantity);
            this.pnlPurAdd.Controls.Add(this.txtProdName);
            this.pnlPurAdd.Location = new System.Drawing.Point(3, 91);
            this.pnlPurAdd.Name = "pnlPurAdd";
            this.pnlPurAdd.Size = new System.Drawing.Size(907, 519);
            this.pnlPurAdd.TabIndex = 2;
            this.pnlPurAdd.Visible = false;
            // 
            // txtProdName
            // 
            this.txtProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdName.DefaultText = "";
            this.txtProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdName.Location = new System.Drawing.Point(135, 124);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PasswordChar = '\0';
            this.txtProdName.PlaceholderText = "";
            this.txtProdName.SelectedText = "";
            this.txtProdName.Size = new System.Drawing.Size(229, 48);
            this.txtProdName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(135, 320);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(229, 48);
            this.txtQuantity.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(496, 124);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(229, 48);
            this.txtPrice.TabIndex = 0;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSupplier.ItemHeight = 30;
            this.cmbSupplier.Location = new System.Drawing.Point(496, 232);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(229, 36);
            this.cmbSupplier.TabIndex = 1;
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.BackColor = System.Drawing.Color.Transparent;
            this.cmbProdCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProdCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProdCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProdCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProdCat.ItemHeight = 30;
            this.cmbProdCat.Location = new System.Drawing.Point(135, 232);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(229, 36);
            this.cmbProdCat.TabIndex = 1;
            // 
            // dtpExp
            // 
            this.dtpExp.Checked = true;
            this.dtpExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExp.Location = new System.Drawing.Point(496, 320);
            this.dtpExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(229, 48);
            this.dtpExp.TabIndex = 2;
            this.dtpExp.Value = new System.DateTime(2024, 12, 7, 18, 6, 15, 738);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Expiration Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Product Name";
            // 
            // btnPurAdd
            // 
            this.btnPurAdd.AutoRoundedCorners = true;
            this.btnPurAdd.BorderRadius = 21;
            this.btnPurAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurAdd.ForeColor = System.Drawing.Color.White;
            this.btnPurAdd.Location = new System.Drawing.Point(702, 449);
            this.btnPurAdd.Name = "btnPurAdd";
            this.btnPurAdd.Size = new System.Drawing.Size(180, 45);
            this.btnPurAdd.TabIndex = 4;
            this.btnPurAdd.Text = "Add";
            this.btnPurAdd.Click += new System.EventHandler(this.btnPurAdd_Click);
            // 
            // btnAddBack
            // 
            this.btnAddBack.AutoRoundedCorners = true;
            this.btnAddBack.BorderRadius = 18;
            this.btnAddBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBack.ForeColor = System.Drawing.Color.White;
            this.btnAddBack.Location = new System.Drawing.Point(16, 26);
            this.btnAddBack.Name = "btnAddBack";
            this.btnAddBack.Size = new System.Drawing.Size(109, 38);
            this.btnAddBack.TabIndex = 4;
            this.btnAddBack.Text = "Back";
            this.btnAddBack.Click += new System.EventHandler(this.btnAddBack_Click);
            // 
            // pnlUpPur
            // 
            this.pnlUpPur.Controls.Add(this.btnUpBack);
            this.pnlUpPur.Controls.Add(this.btnUpdatePurc);
            this.pnlUpPur.Controls.Add(this.label7);
            this.pnlUpPur.Controls.Add(this.label8);
            this.pnlUpPur.Controls.Add(this.label9);
            this.pnlUpPur.Controls.Add(this.label10);
            this.pnlUpPur.Controls.Add(this.label11);
            this.pnlUpPur.Controls.Add(this.label12);
            this.pnlUpPur.Controls.Add(this.dtpUpPurExp);
            this.pnlUpPur.Controls.Add(this.cmbUpPurProdCat);
            this.pnlUpPur.Controls.Add(this.cmbUpPurSupplier);
            this.pnlUpPur.Controls.Add(this.txtUpPurPrice);
            this.pnlUpPur.Controls.Add(this.txtUpPurQuantity);
            this.pnlUpPur.Controls.Add(this.txtUpPurProdName);
            this.pnlUpPur.Location = new System.Drawing.Point(4, 23);
            this.pnlUpPur.Name = "pnlUpPur";
            this.pnlUpPur.Size = new System.Drawing.Size(881, 511);
            this.pnlUpPur.TabIndex = 3;
            this.pnlUpPur.Visible = false;
            // 
            // btnUpBack
            // 
            this.btnUpBack.AutoRoundedCorners = true;
            this.btnUpBack.BorderRadius = 18;
            this.btnUpBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpBack.ForeColor = System.Drawing.Color.White;
            this.btnUpBack.Location = new System.Drawing.Point(7, 21);
            this.btnUpBack.Name = "btnUpBack";
            this.btnUpBack.Size = new System.Drawing.Size(109, 38);
            this.btnUpBack.TabIndex = 17;
            this.btnUpBack.Text = "Back";
            this.btnUpBack.Click += new System.EventHandler(this.btnUpBack_Click);
            // 
            // btnUpdatePurc
            // 
            this.btnUpdatePurc.AutoRoundedCorners = true;
            this.btnUpdatePurc.BorderRadius = 21;
            this.btnUpdatePurc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePurc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePurc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePurc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePurc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdatePurc.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePurc.Location = new System.Drawing.Point(693, 444);
            this.btnUpdatePurc.Name = "btnUpdatePurc";
            this.btnUpdatePurc.Size = new System.Drawing.Size(180, 45);
            this.btnUpdatePurc.TabIndex = 18;
            this.btnUpdatePurc.Text = "Update";
            this.btnUpdatePurc.Click += new System.EventHandler(this.btnUpdatePurc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Product Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Expiration Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Supplier";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Price";
            // 
            // dtpUpPurExp
            // 
            this.dtpUpPurExp.Checked = true;
            this.dtpUpPurExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpUpPurExp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpUpPurExp.Location = new System.Drawing.Point(487, 315);
            this.dtpUpPurExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpUpPurExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpUpPurExp.Name = "dtpUpPurExp";
            this.dtpUpPurExp.Size = new System.Drawing.Size(229, 48);
            this.dtpUpPurExp.TabIndex = 10;
            this.dtpUpPurExp.Value = new System.DateTime(2024, 12, 7, 18, 6, 15, 738);
            // 
            // cmbUpPurProdCat
            // 
            this.cmbUpPurProdCat.BackColor = System.Drawing.Color.Transparent;
            this.cmbUpPurProdCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUpPurProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpPurProdCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpPurProdCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpPurProdCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUpPurProdCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUpPurProdCat.ItemHeight = 30;
            this.cmbUpPurProdCat.Location = new System.Drawing.Point(126, 227);
            this.cmbUpPurProdCat.Name = "cmbUpPurProdCat";
            this.cmbUpPurProdCat.Size = new System.Drawing.Size(229, 36);
            this.cmbUpPurProdCat.TabIndex = 8;
            // 
            // cmbUpPurSupplier
            // 
            this.cmbUpPurSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbUpPurSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUpPurSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpPurSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpPurSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpPurSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUpPurSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUpPurSupplier.ItemHeight = 30;
            this.cmbUpPurSupplier.Location = new System.Drawing.Point(487, 227);
            this.cmbUpPurSupplier.Name = "cmbUpPurSupplier";
            this.cmbUpPurSupplier.Size = new System.Drawing.Size(229, 36);
            this.cmbUpPurSupplier.TabIndex = 9;
            // 
            // txtUpPurPrice
            // 
            this.txtUpPurPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpPurPrice.DefaultText = "";
            this.txtUpPurPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpPurPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpPurPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpPurPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurPrice.Location = new System.Drawing.Point(487, 119);
            this.txtUpPurPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpPurPrice.Name = "txtUpPurPrice";
            this.txtUpPurPrice.PasswordChar = '\0';
            this.txtUpPurPrice.PlaceholderText = "";
            this.txtUpPurPrice.SelectedText = "";
            this.txtUpPurPrice.Size = new System.Drawing.Size(229, 48);
            this.txtUpPurPrice.TabIndex = 5;
            // 
            // txtUpPurQuantity
            // 
            this.txtUpPurQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpPurQuantity.DefaultText = "";
            this.txtUpPurQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpPurQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpPurQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpPurQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurQuantity.Location = new System.Drawing.Point(126, 315);
            this.txtUpPurQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpPurQuantity.Name = "txtUpPurQuantity";
            this.txtUpPurQuantity.PasswordChar = '\0';
            this.txtUpPurQuantity.PlaceholderText = "";
            this.txtUpPurQuantity.SelectedText = "";
            this.txtUpPurQuantity.Size = new System.Drawing.Size(229, 48);
            this.txtUpPurQuantity.TabIndex = 6;
            // 
            // txtUpPurProdName
            // 
            this.txtUpPurProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpPurProdName.DefaultText = "";
            this.txtUpPurProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpPurProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpPurProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpPurProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurProdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpPurProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpPurProdName.Location = new System.Drawing.Point(126, 119);
            this.txtUpPurProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpPurProdName.Name = "txtUpPurProdName";
            this.txtUpPurProdName.PasswordChar = '\0';
            this.txtUpPurProdName.PlaceholderText = "";
            this.txtUpPurProdName.SelectedText = "";
            this.txtUpPurProdName.Size = new System.Drawing.Size(229, 48);
            this.txtUpPurProdName.TabIndex = 7;
            // 
            // PurchasesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPurAdd);
            this.Controls.Add(this.pnlUpPur);
            this.Controls.Add(this.btnAddPur);
            this.Controls.Add(this.dgvPurchases);
            this.Name = "PurchasesControl";
            this.Size = new System.Drawing.Size(1199, 728);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.pnlPurAdd.ResumeLayout(false);
            this.pnlPurAdd.PerformLayout();
            this.pnlUpPur.ResumeLayout(false);
            this.pnlUpPur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchases;
        private Guna.UI2.WinForms.Guna2Button btnAddPur;
        private Guna.UI2.WinForms.Guna2Panel pnlPurAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtProdName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExp;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProdCat;
        private Guna.UI2.WinForms.Guna2Button btnPurAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddBack;
        private Guna.UI2.WinForms.Guna2Panel pnlUpPur;
        private Guna.UI2.WinForms.Guna2Button btnUpBack;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePurc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpUpPurExp;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUpPurProdCat;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUpPurSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtUpPurPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtUpPurQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtUpPurProdName;
    }
}
