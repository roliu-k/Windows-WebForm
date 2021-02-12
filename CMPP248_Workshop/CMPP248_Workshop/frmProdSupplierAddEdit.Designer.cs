﻿
namespace CMPP248_Workshop
{
    partial class frmProdSupplierAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnManageProds = new System.Windows.Forms.Button();
            this.btnManageSupps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.mainLeftBuff = new System.Windows.Forms.Panel();
            this.mainRightBuff = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grdProductSuppliers = new System.Windows.Forms.DataGridView();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSubBody = new System.Windows.Forms.Panel();
            this.grdPackagesforProdSupp = new System.Windows.Forms.DataGridView();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedProdsTitle = new System.Windows.Forms.Label();
            this.leftbuff = new System.Windows.Forms.Panel();
            this.rightbuff = new System.Windows.Forms.Panel();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.productSupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.body = new System.Windows.Forms.Panel();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAssociatesPackages = new System.Windows.Forms.Label();
            this.packageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgBasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgAgencyCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierIdLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductSuppliers)).BeginInit();
            this.pnlSubBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackagesforProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIdLabel.Location = new System.Drawing.Point(211, 209);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(75, 16);
            supplierIdLabel.TabIndex = 5;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productSupplierIdLabel.Location = new System.Drawing.Point(211, 147);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(124, 16);
            productSupplierIdLabel.TabIndex = 3;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIdLabel.Location = new System.Drawing.Point(211, 177);
            productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(71, 16);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "Product Id:";
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(TravelExpertDatabase.Products_Supplier);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertDatabase.Supplier);
            // 
            // btnManageProds
            // 
            this.btnManageProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProds.Location = new System.Drawing.Point(69, 614);
            this.btnManageProds.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageProds.Name = "btnManageProds";
            this.btnManageProds.Size = new System.Drawing.Size(230, 38);
            this.btnManageProds.TabIndex = 7;
            this.btnManageProds.Text = "Manage Products";
            this.btnManageProds.UseVisualStyleBackColor = true;
            this.btnManageProds.Click += new System.EventHandler(this.btnManageProds_Click);
            // 
            // btnManageSupps
            // 
            this.btnManageSupps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupps.Location = new System.Drawing.Point(349, 614);
            this.btnManageSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageSupps.Name = "btnManageSupps";
            this.btnManageSupps.Size = new System.Drawing.Size(230, 38);
            this.btnManageSupps.TabIndex = 8;
            this.btnManageSupps.Text = "Manage Suppliers";
            this.btnManageSupps.UseVisualStyleBackColor = true;
            this.btnManageSupps.Click += new System.EventHandler(this.btnManageSupps_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(660, 614);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // packagesProductsSuppliersBindingSource
            // 
            this.packagesProductsSuppliersBindingSource.DataMember = "Packages_Products_Suppliers";
            this.packagesProductsSuppliersBindingSource.DataSource = this.products_SupplierBindingSource;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(900, 75);
            this.Header.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(900, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Each row represents a product.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.Title.Size = new System.Drawing.Size(900, 51);
            this.Title.TabIndex = 19;
            this.Title.Text = "Product Manager - View Products";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLeftBuff
            // 
            this.mainLeftBuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainLeftBuff.Location = new System.Drawing.Point(0, 75);
            this.mainLeftBuff.Name = "mainLeftBuff";
            this.mainLeftBuff.Size = new System.Drawing.Size(17, 643);
            this.mainLeftBuff.TabIndex = 28;
            // 
            // mainRightBuff
            // 
            this.mainRightBuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainRightBuff.Location = new System.Drawing.Point(883, 75);
            this.mainRightBuff.Name = "mainRightBuff";
            this.mainRightBuff.Size = new System.Drawing.Size(17, 643);
            this.mainRightBuff.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current Products:";
            // 
            // grdProductSuppliers
            // 
            this.grdProductSuppliers.AllowUserToAddRows = false;
            this.grdProductSuppliers.AllowUserToDeleteRows = false;
            this.grdProductSuppliers.AllowUserToResizeColumns = false;
            this.grdProductSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdProductSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grdProductSuppliers.AutoGenerateColumns = false;
            this.grdProductSuppliers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductSuppliers.CausesValidation = false;
            this.grdProductSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdProductSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierId,
            this.productIdDataGridViewTextBoxColumn,
            this.Product,
            this.supplierIdDataGridViewTextBoxColumn,
            this.Supplier});
            this.grdProductSuppliers.DataSource = this.products_SupplierBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductSuppliers.DefaultCellStyle = dataGridViewCellStyle17;
            this.grdProductSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdProductSuppliers.EnableHeadersVisualStyles = false;
            this.grdProductSuppliers.Location = new System.Drawing.Point(0, 23);
            this.grdProductSuppliers.Margin = new System.Windows.Forms.Padding(15);
            this.grdProductSuppliers.MultiSelect = false;
            this.grdProductSuppliers.Name = "grdProductSuppliers";
            this.grdProductSuppliers.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdProductSuppliers.RowHeadersVisible = false;
            this.grdProductSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductSuppliers.Size = new System.Drawing.Size(866, 262);
            this.grdProductSuppliers.TabIndex = 20;
            this.grdProductSuppliers.TabStop = false;
            this.grdProductSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductSuppliers_CellClick);
            this.grdProductSuppliers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProductSuppliers_CellFormatting);
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ID";
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Product.ProdName";
            this.Product.HeaderText = "Product Name";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.DataPropertyName = "Supplier.SupName";
            this.Supplier.HeaderText = "Supplier Name";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // pnlSubBody
            // 
            this.pnlSubBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSubBody.Controls.Add(this.lblSelectedProdsTitle);
            this.pnlSubBody.Controls.Add(this.grdPackagesforProdSupp);
            this.pnlSubBody.Controls.Add(this.lblAssociatesPackages);
            this.pnlSubBody.Controls.Add(this.leftbuff);
            this.pnlSubBody.Controls.Add(this.rightbuff);
            this.pnlSubBody.Controls.Add(productIdLabel);
            this.pnlSubBody.Controls.Add(this.productIdComboBox);
            this.pnlSubBody.Controls.Add(this.productSupplierIdTextBox);
            this.pnlSubBody.Controls.Add(productSupplierIdLabel);
            this.pnlSubBody.Controls.Add(supplierIdLabel);
            this.pnlSubBody.Controls.Add(this.supplierIdComboBox);
            this.pnlSubBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubBody.Location = new System.Drawing.Point(0, 285);
            this.pnlSubBody.Name = "pnlSubBody";
            this.pnlSubBody.Size = new System.Drawing.Size(866, 249);
            this.pnlSubBody.TabIndex = 24;
            // 
            // grdPackagesforProdSupp
            // 
            this.grdPackagesforProdSupp.AllowUserToAddRows = false;
            this.grdPackagesforProdSupp.AllowUserToDeleteRows = false;
            this.grdPackagesforProdSupp.AllowUserToResizeColumns = false;
            this.grdPackagesforProdSupp.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdPackagesforProdSupp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.grdPackagesforProdSupp.AutoGenerateColumns = false;
            this.grdPackagesforProdSupp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdPackagesforProdSupp.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.grdPackagesforProdSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPackagesforProdSupp.CausesValidation = false;
            this.grdPackagesforProdSupp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grdPackagesforProdSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageIdDataGridViewTextBoxColumn,
            this.pkgNameDataGridViewTextBoxColumn,
            this.pkgStartDateDataGridViewTextBoxColumn,
            this.pkgEndDateDataGridViewTextBoxColumn,
            this.pkgBasePriceDataGridViewTextBoxColumn,
            this.pkgAgencyCommissionDataGridViewTextBoxColumn,
            this.pkgDescDataGridViewTextBoxColumn});
            this.grdPackagesforProdSupp.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdPackagesforProdSupp.DataSource = this.packageBindingSource;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPackagesforProdSupp.DefaultCellStyle = dataGridViewCellStyle26;
            this.grdPackagesforProdSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPackagesforProdSupp.EnableHeadersVisualStyles = false;
            this.grdPackagesforProdSupp.Location = new System.Drawing.Point(29, 28);
            this.grdPackagesforProdSupp.Margin = new System.Windows.Forms.Padding(2);
            this.grdPackagesforProdSupp.MultiSelect = false;
            this.grdPackagesforProdSupp.Name = "grdPackagesforProdSupp";
            this.grdPackagesforProdSupp.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.grdPackagesforProdSupp.RowHeadersVisible = false;
            this.grdPackagesforProdSupp.RowHeadersWidth = 51;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPackagesforProdSupp.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.grdPackagesforProdSupp.RowTemplate.Height = 24;
            this.grdPackagesforProdSupp.ShowEditingIcon = false;
            this.grdPackagesforProdSupp.Size = new System.Drawing.Size(804, 90);
            this.grdPackagesforProdSupp.TabIndex = 27;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertDatabase.Package);
            // 
            // lblSelectedProdsTitle
            // 
            this.lblSelectedProdsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectedProdsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProdsTitle.Location = new System.Drawing.Point(29, 118);
            this.lblSelectedProdsTitle.Name = "lblSelectedProdsTitle";
            this.lblSelectedProdsTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblSelectedProdsTitle.Size = new System.Drawing.Size(804, 28);
            this.lblSelectedProdsTitle.TabIndex = 26;
            this.lblSelectedProdsTitle.Text = "Selected Product:";
            this.lblSelectedProdsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leftbuff
            // 
            this.leftbuff.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftbuff.Location = new System.Drawing.Point(833, 0);
            this.leftbuff.Name = "leftbuff";
            this.leftbuff.Size = new System.Drawing.Size(29, 245);
            this.leftbuff.TabIndex = 25;
            // 
            // rightbuff
            // 
            this.rightbuff.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightbuff.Location = new System.Drawing.Point(0, 0);
            this.rightbuff.Name = "rightbuff";
            this.rightbuff.Size = new System.Drawing.Size(29, 245);
            this.rightbuff.TabIndex = 24;
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "ProductId", true));
            this.productIdComboBox.DataSource = this.productBindingSource;
            this.productIdComboBox.DisplayMember = "ProdName";
            this.productIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(431, 176);
            this.productIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(241, 24);
            this.productIdComboBox.TabIndex = 2;
            this.productIdComboBox.ValueMember = "ProductId";
            // 
            // productSupplierIdTextBox
            // 
            this.productSupplierIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.productSupplierIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSupplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductSupplierId", true));
            this.productSupplierIdTextBox.Location = new System.Drawing.Point(431, 147);
            this.productSupplierIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSupplierIdTextBox.Name = "productSupplierIdTextBox";
            this.productSupplierIdTextBox.Size = new System.Drawing.Size(118, 13);
            this.productSupplierIdTextBox.TabIndex = 4;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupName";
            this.supplierIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(431, 208);
            this.supplierIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(241, 24);
            this.supplierIdComboBox.TabIndex = 6;
            this.supplierIdComboBox.ValueMember = "SupplierId";
            // 
            // body
            // 
            this.body.Controls.Add(this.pnlSubBody);
            this.body.Controls.Add(this.grdProductSuppliers);
            this.body.Controls.Add(this.label2);
            this.body.Dock = System.Windows.Forms.DockStyle.Top;
            this.body.Location = new System.Drawing.Point(17, 75);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(866, 534);
            this.body.TabIndex = 21;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(TravelExpertDatabase.Product);
            // 
            // lblAssociatesPackages
            // 
            this.lblAssociatesPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssociatesPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociatesPackages.Location = new System.Drawing.Point(29, 0);
            this.lblAssociatesPackages.Name = "lblAssociatesPackages";
            this.lblAssociatesPackages.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblAssociatesPackages.Size = new System.Drawing.Size(804, 28);
            this.lblAssociatesPackages.TabIndex = 28;
            this.lblAssociatesPackages.Text = "Associated Packages:";
            this.lblAssociatesPackages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            this.packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            this.packageIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            this.packageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // pkgNameDataGridViewTextBoxColumn
            // 
            this.pkgNameDataGridViewTextBoxColumn.DataPropertyName = "PkgName";
            this.pkgNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pkgNameDataGridViewTextBoxColumn.Name = "pkgNameDataGridViewTextBoxColumn";
            this.pkgNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkgNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pkgStartDateDataGridViewTextBoxColumn
            // 
            this.pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle21.Format = "MMM d, yyyy";
            this.pkgStartDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.pkgStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            this.pkgStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            this.pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle22.Format = "MMM d, yyyy";
            this.pkgEndDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.pkgEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            this.pkgEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            this.pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle23.Format = "C2";
            this.pkgBasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "Base Price";
            this.pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            this.pkgBasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle24.Format = "C2";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "Commission";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            this.pkgDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pkgDescDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.pkgDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            this.pkgDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmProdSupplierAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 718);
            this.Controls.Add(this.body);
            this.Controls.Add(this.mainRightBuff);
            this.Controls.Add(this.mainLeftBuff);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnManageSupps);
            this.Controls.Add(this.btnManageProds);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProdSupplierAddEdit";
            this.Text = "frmProdSupplierAddEdit";
            this.Load += new System.EventHandler(this.frmProdSupplierAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductSuppliers)).EndInit();
            this.pnlSubBody.ResumeLayout(false);
            this.pnlSubBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackagesforProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnManageProds;
        private System.Windows.Forms.Button btnManageSupps;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel mainLeftBuff;
        private System.Windows.Forms.Panel mainRightBuff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdProductSuppliers;
        private System.Windows.Forms.Panel pnlSubBody;
        private System.Windows.Forms.Panel leftbuff;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSelectedProdsTitle;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.TextBox productSupplierIdTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.DataGridView grdPackagesforProdSupp;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.Panel rightbuff;
        private System.Windows.Forms.Label lblAssociatesPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
    }
}