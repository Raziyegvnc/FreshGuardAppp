namespace FreshGuardApp
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.rbtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnReport = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnSales = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnPurchases = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1140, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1089, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 29);
            this.btnMax.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1038, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 29);
            this.btnMin.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnMax);
            this.guna2Panel1.Controls.Add(this.btnMin);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1197, 54);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.Controls.Add(this.guna2Separator1);
            this.guna2Panel3.Controls.Add(this.rbtnHome);
            this.guna2Panel3.Controls.Add(this.rbtnReport);
            this.guna2Panel3.Controls.Add(this.rbtnUsers);
            this.guna2Panel3.Controls.Add(this.rbtnSales);
            this.guna2Panel3.Controls.Add(this.rbtnSupplier);
            this.guna2Panel3.Controls.Add(this.rbtnPurchases);
            this.guna2Panel3.Controls.Add(this.rbtnProducts);
            this.guna2Panel3.Controls.Add(this.rbtnCategory);
            this.guna2Panel3.Controls.Add(this.lblUser);
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel3.CustomizableEdges.BottomLeft = false;
            this.guna2Panel3.CustomizableEdges.BottomRight = false;
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(263, 656);
            this.guna2Panel3.TabIndex = 5;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.guna2Separator1.Location = new System.Drawing.Point(12, 144);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(241, 19);
            this.guna2Separator1.TabIndex = 12;
            // 
            // rbtnHome
            // 
            this.rbtnHome.AutoRoundedCorners = true;
            this.rbtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnHome.BorderRadius = 21;
            this.rbtnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnHome.Checked = true;
            this.rbtnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnHome.ForeColor = System.Drawing.Color.White;
            this.rbtnHome.Location = new System.Drawing.Point(32, 169);
            this.rbtnHome.Name = "rbtnHome";
            this.rbtnHome.Size = new System.Drawing.Size(180, 45);
            this.rbtnHome.TabIndex = 11;
            this.rbtnHome.Text = "Home";
            // 
            // rbtnReport
            // 
            this.rbtnReport.AutoRoundedCorners = true;
            this.rbtnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnReport.BorderRadius = 21;
            this.rbtnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnReport.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnReport.ForeColor = System.Drawing.Color.White;
            this.rbtnReport.Location = new System.Drawing.Point(32, 526);
            this.rbtnReport.Name = "rbtnReport";
            this.rbtnReport.Size = new System.Drawing.Size(180, 45);
            this.rbtnReport.TabIndex = 10;
            this.rbtnReport.Text = "Report";
            // 
            // rbtnUsers
            // 
            this.rbtnUsers.AutoRoundedCorners = true;
            this.rbtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnUsers.BorderRadius = 21;
            this.rbtnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnUsers.ForeColor = System.Drawing.Color.White;
            this.rbtnUsers.Location = new System.Drawing.Point(32, 475);
            this.rbtnUsers.Name = "rbtnUsers";
            this.rbtnUsers.Size = new System.Drawing.Size(180, 45);
            this.rbtnUsers.TabIndex = 9;
            this.rbtnUsers.Text = "Users";
            // 
            // rbtnSales
            // 
            this.rbtnSales.AutoRoundedCorners = true;
            this.rbtnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSales.BorderRadius = 21;
            this.rbtnSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnSales.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnSales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnSales.ForeColor = System.Drawing.Color.White;
            this.rbtnSales.Location = new System.Drawing.Point(32, 424);
            this.rbtnSales.Name = "rbtnSales";
            this.rbtnSales.Size = new System.Drawing.Size(180, 45);
            this.rbtnSales.TabIndex = 8;
            this.rbtnSales.Text = "Sales";
            // 
            // rbtnSupplier
            // 
            this.rbtnSupplier.AutoRoundedCorners = true;
            this.rbtnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSupplier.BorderRadius = 21;
            this.rbtnSupplier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnSupplier.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnSupplier.ForeColor = System.Drawing.Color.White;
            this.rbtnSupplier.Location = new System.Drawing.Point(32, 373);
            this.rbtnSupplier.Name = "rbtnSupplier";
            this.rbtnSupplier.Size = new System.Drawing.Size(180, 45);
            this.rbtnSupplier.TabIndex = 7;
            this.rbtnSupplier.Text = "Supplier";
            // 
            // rbtnPurchases
            // 
            this.rbtnPurchases.AutoRoundedCorners = true;
            this.rbtnPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnPurchases.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnPurchases.BorderRadius = 21;
            this.rbtnPurchases.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnPurchases.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnPurchases.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnPurchases.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnPurchases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnPurchases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnPurchases.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnPurchases.ForeColor = System.Drawing.Color.White;
            this.rbtnPurchases.Location = new System.Drawing.Point(32, 322);
            this.rbtnPurchases.Name = "rbtnPurchases";
            this.rbtnPurchases.Size = new System.Drawing.Size(180, 45);
            this.rbtnPurchases.TabIndex = 5;
            this.rbtnPurchases.Text = "Purchases";
            // 
            // rbtnProducts
            // 
            this.rbtnProducts.AutoRoundedCorners = true;
            this.rbtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnProducts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnProducts.BorderRadius = 21;
            this.rbtnProducts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnProducts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnProducts.ForeColor = System.Drawing.Color.White;
            this.rbtnProducts.Location = new System.Drawing.Point(32, 271);
            this.rbtnProducts.Name = "rbtnProducts";
            this.rbtnProducts.Size = new System.Drawing.Size(180, 45);
            this.rbtnProducts.TabIndex = 4;
            this.rbtnProducts.Text = "Products";
            // 
            // rbtnCategory
            // 
            this.rbtnCategory.AutoRoundedCorners = true;
            this.rbtnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnCategory.BorderRadius = 21;
            this.rbtnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rbtnCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(200)))));
            this.rbtnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rbtnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rbtnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rbtnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rbtnCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnCategory.ForeColor = System.Drawing.Color.White;
            this.rbtnCategory.Location = new System.Drawing.Point(32, 220);
            this.rbtnCategory.Name = "rbtnCategory";
            this.rbtnCategory.Size = new System.Drawing.Size(180, 45);
            this.rbtnCategory.TabIndex = 3;
            this.rbtnCategory.Text = "Category";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(97, 112);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::FreshGuardApp.Properties.Resources.WhatsApp_Görsel_2024_12_07_saat_16_27_46_af675eff;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(88, 24);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(85, 85);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(292, 78);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(893, 620);
            this.pnlMain.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 710);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button rbtnPurchases;
        private Guna.UI2.WinForms.Guna2Button rbtnProducts;
        private Guna.UI2.WinForms.Guna2Button rbtnCategory;
        private Guna.UI2.WinForms.Guna2Button rbtnSupplier;
        private Guna.UI2.WinForms.Guna2Button rbtnSales;
        private Guna.UI2.WinForms.Guna2Button rbtnHome;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Button rbtnUsers;
        public Guna.UI2.WinForms.Guna2Button rbtnReport;
    }
}