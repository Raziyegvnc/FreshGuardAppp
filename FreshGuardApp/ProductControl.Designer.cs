namespace FreshGuardApp
{
    partial class ProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProd = new Guna.UI2.WinForms.Guna2Button();
            this.pbProd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlUpdate = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbUpCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProdUpName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpProduct = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpAddProduct = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProd)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAddProduct);
            this.pnlMain.Controls.Add(this.dgvProducts);
            this.pnlMain.Location = new System.Drawing.Point(27, 22);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1116, 649);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoRoundedCorners = true;
            this.btnAddProduct.BorderRadius = 21;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(917, 43);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 45);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.ColumnHeadersHeight = 4;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(17, 111);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1080, 519);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProducts.ThemeStyle.ReadOnly = false;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.dtpAddProduct);
            this.pnlAdd.Controls.Add(this.btnAddBack);
            this.pnlAdd.Controls.Add(this.btnAddProd);
            this.pnlAdd.Controls.Add(this.pbProd);
            this.pnlAdd.Controls.Add(this.cmbCategory);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.txtQuan);
            this.pnlAdd.Controls.Add(this.txtProdName);
            this.pnlAdd.Location = new System.Drawing.Point(13, 81);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(858, 439);
            this.pnlAdd.TabIndex = 1;
            this.pnlAdd.Visible = false;
            // 
            // btnAddBack
            // 
            this.btnAddBack.AutoRoundedCorners = true;
            this.btnAddBack.BorderRadius = 22;
            this.btnAddBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBack.ForeColor = System.Drawing.Color.White;
            this.btnAddBack.Location = new System.Drawing.Point(3, 3);
            this.btnAddBack.Name = "btnAddBack";
            this.btnAddBack.Size = new System.Drawing.Size(87, 46);
            this.btnAddBack.TabIndex = 9;
            this.btnAddBack.Text = "Back";
            this.btnAddBack.Click += new System.EventHandler(this.btnAddBack_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.AutoRoundedCorners = true;
            this.btnAddProd.BorderRadius = 21;
            this.btnAddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProd.ForeColor = System.Drawing.Color.White;
            this.btnAddProd.Location = new System.Drawing.Point(661, 377);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(180, 45);
            this.btnAddProd.TabIndex = 8;
            this.btnAddProd.Text = "ADD";
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // pbProd
            // 
            this.pbProd.ImageRotate = 0F;
            this.pbProd.Location = new System.Drawing.Point(570, 72);
            this.pbProd.Name = "pbProd";
            this.pbProd.Size = new System.Drawing.Size(168, 133);
            this.pbProd.TabIndex = 7;
            this.pbProd.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Location = new System.Drawing.Point(159, 169);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 36);
            this.cmbCategory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // txtQuan
            // 
            this.txtQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuan.DefaultText = "";
            this.txtQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.Location = new System.Drawing.Point(159, 261);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.PlaceholderText = "";
            this.txtQuan.SelectedText = "";
            this.txtQuan.Size = new System.Drawing.Size(229, 48);
            this.txtQuan.TabIndex = 2;
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
            this.txtProdName.Location = new System.Drawing.Point(159, 72);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PasswordChar = '\0';
            this.txtProdName.PlaceholderText = "";
            this.txtProdName.SelectedText = "";
            this.txtProdName.Size = new System.Drawing.Size(229, 48);
            this.txtProdName.TabIndex = 0;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.dtpProduct);
            this.pnlUpdate.Controls.Add(this.btnUpBack);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.guna2PictureBox1);
            this.pnlUpdate.Controls.Add(this.cmbUpCat);
            this.pnlUpdate.Controls.Add(this.label4);
            this.pnlUpdate.Controls.Add(this.label5);
            this.pnlUpdate.Controls.Add(this.label6);
            this.pnlUpdate.Controls.Add(this.txtUpQuan);
            this.pnlUpdate.Controls.Add(this.txtProdUpName);
            this.pnlUpdate.Location = new System.Drawing.Point(3, 149);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(850, 470);
            this.pnlUpdate.TabIndex = 2;
            this.pnlUpdate.Visible = false;
            // 
            // btnUpBack
            // 
            this.btnUpBack.AutoRoundedCorners = true;
            this.btnUpBack.BorderRadius = 22;
            this.btnUpBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpBack.ForeColor = System.Drawing.Color.White;
            this.btnUpBack.Location = new System.Drawing.Point(-3, 35);
            this.btnUpBack.Name = "btnUpBack";
            this.btnUpBack.Size = new System.Drawing.Size(87, 46);
            this.btnUpBack.TabIndex = 18;
            this.btnUpBack.Text = "Back";
            this.btnUpBack.Click += new System.EventHandler(this.btnUpBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 21;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(655, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(564, 104);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(168, 133);
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cmbUpCat
            // 
            this.cmbUpCat.BackColor = System.Drawing.Color.Transparent;
            this.cmbUpCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUpCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUpCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUpCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUpCat.ItemHeight = 30;
            this.cmbUpCat.Location = new System.Drawing.Point(153, 201);
            this.cmbUpCat.Name = "cmbUpCat";
            this.cmbUpCat.Size = new System.Drawing.Size(229, 36);
            this.cmbUpCat.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product Name";
            // 
            // txtUpQuan
            // 
            this.txtUpQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpQuan.DefaultText = "";
            this.txtUpQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpQuan.Location = new System.Drawing.Point(153, 293);
            this.txtUpQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpQuan.Name = "txtUpQuan";
            this.txtUpQuan.PasswordChar = '\0';
            this.txtUpQuan.PlaceholderText = "";
            this.txtUpQuan.SelectedText = "";
            this.txtUpQuan.Size = new System.Drawing.Size(229, 48);
            this.txtUpQuan.TabIndex = 11;
            // 
            // txtProdUpName
            // 
            this.txtProdUpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdUpName.DefaultText = "";
            this.txtProdUpName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProdUpName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProdUpName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdUpName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdUpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdUpName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProdUpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdUpName.Location = new System.Drawing.Point(153, 104);
            this.txtProdUpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdUpName.Name = "txtProdUpName";
            this.txtProdUpName.PasswordChar = '\0';
            this.txtProdUpName.PlaceholderText = "";
            this.txtProdUpName.SelectedText = "";
            this.txtProdUpName.Size = new System.Drawing.Size(229, 48);
            this.txtProdUpName.TabIndex = 10;
            // 
            // dtpProduct
            // 
            this.dtpProduct.Checked = true;
            this.dtpProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpProduct.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpProduct.Location = new System.Drawing.Point(156, 363);
            this.dtpProduct.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProduct.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProduct.Name = "dtpProduct";
            this.dtpProduct.Size = new System.Drawing.Size(226, 36);
            this.dtpProduct.TabIndex = 19;
            this.dtpProduct.Value = new System.DateTime(2024, 12, 5, 14, 28, 52, 106);
            // 
            // dtpAddProduct
            // 
            this.dtpAddProduct.Checked = true;
            this.dtpAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAddProduct.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAddProduct.Location = new System.Drawing.Point(162, 335);
            this.dtpAddProduct.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAddProduct.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAddProduct.Name = "dtpAddProduct";
            this.dtpAddProduct.Size = new System.Drawing.Size(226, 36);
            this.dtpAddProduct.TabIndex = 10;
            this.dtpAddProduct.Value = new System.DateTime(2024, 12, 5, 14, 31, 12, 633);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlMain);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1170, 687);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProd)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private Guna.UI2.WinForms.Guna2Panel pnlAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuan;
        private Guna.UI2.WinForms.Guna2TextBox txtProdName;
        private Guna.UI2.WinForms.Guna2Button btnAddBack;
        private Guna.UI2.WinForms.Guna2Button btnAddProd;
        private Guna.UI2.WinForms.Guna2PictureBox pbProd;
        private Guna.UI2.WinForms.Guna2Panel pnlUpdate;
        private Guna.UI2.WinForms.Guna2Button btnUpBack;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUpCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtUpQuan;
        private Guna.UI2.WinForms.Guna2TextBox txtProdUpName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAddProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProduct;
    }
}
