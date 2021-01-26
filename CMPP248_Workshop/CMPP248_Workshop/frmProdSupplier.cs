﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertDatabase;

namespace CMPP248_Workshop
{
    // This should allow adding a Product Supplier ID from a combination of Product ID and Supplier to the Package.
    // All IDs should already exist - if not, they are added on their respective forms.

    public partial class frmProdSupplier : Form
    {

        // Class-level variables
        public Package currentPackage;

        public frmProdSupplier()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get ProductSupplierID from combobox
            int prodSupID = Convert.ToInt32(productSupplierIdTextBox.Text);

            // Create a PackagesProductSupplier with that ID, and the Package ID from the current package
            Packages_Products_Supplier newPackProdSup = new Packages_Products_Supplier
            {
                ProductSupplierId = prodSupID,
                PackageId = currentPackage.PackageId
            };

            // Add that PackagesProductsSupplier to the db
            using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            {
                // insert through data context object from the main form
                dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPackProdSup);
                dbContext.SubmitChanges(); // submit to the database
            }

            // Re-load the datagrid view
            refreshDataGrid();
        }

        //Delete from GridView so it won't add to database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //using (travelexpertsDataContext dbContext = new travelexpertsDataContext())
            //{
            //    //select from gridview
            
            //    dbContext.Packages_Products_Suppliers.DeleteOnSubmit();
            //    dbContext.SubmitChanges(); // submit to the database
            //}
            //refreshDataGrid();
        }

        //Save changes, add to database, close window
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdSupplier_Load(object sender, EventArgs e)
        {
            // Populate data grid showing products
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                refreshDataGrid();

                //products_SupplierBindingSource.DataSource = db.Products_Suppliers;
                //productBindingSource.DataSource = db.Products;
                //supplierBindingSource.DataSource = db.Suppliers;

                // display the list of selection for products and suppliers 
                prodNameComboBox.DataSource = from product in db.Products
                                              select product.ProdName;

                supNameComboBox.DataSource = from supplier in db.Suppliers
                                             select supplier.SupName;


            }
            
            
        }



        private void refreshDataGrid()
        {
            // Populate data grid showing products
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                dataGridView1.DataSource =
                    from Packages in db.Packages
                    join Packages_Products_Suppliers in db.Packages_Products_Suppliers
                    on Packages.PackageId equals Packages_Products_Suppliers.PackageId
                    join Products_Suppliers in db.Products_Suppliers
                    on Packages_Products_Suppliers.ProductSupplierId equals Products_Suppliers.ProductSupplierId
                    join Products in db.Products
                    on Products_Suppliers.ProductId equals Products.ProductId
                    join Suppliers in db.Suppliers
                    on Products_Suppliers.SupplierId equals Suppliers.SupplierId
                    where Packages.PackageId == currentPackage.PackageId
                    orderby Packages.PackageId
                    select new
                    {
                        Packages.PackageId,
                        Packages.PkgName,
                        Products.ProductId,
                        Products.ProdName,
                        Suppliers.SupplierId,
                        Supplier = Suppliers.SupName
                    };
            }
        }

        private void DisplayProdSupId()
        {

        }

        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the product name
            string prodName = prodNameComboBox.SelectedItem.ToString();

            // get the list of suppliers applicable with the selected product ID
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                //int prodId = Convert.ToInt32(db.Products.Single(p => p.ProdName == prodName));
                supNameComboBox.DataSource = from prodsupp in db.Products_Suppliers
                                             join Products in db.Products
                                             on prodsupp.ProductId equals Products.ProductId
                                             join suppliers in db.Suppliers
                                             on prodsupp.SupplierId equals suppliers.SupplierId
                                             where Products.ProdName == prodNameComboBox.Text
                                             select suppliers.SupName;
                                             
            //supNameComboBox.sdelecteindex = 0;

            }
        }

        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (travelexpertsDataContext db = new travelexpertsDataContext())
            {
                productSupplierIdTextBox.Text = (from prodsupp in db.Products_Suppliers
                                                join Products in db.Products
                                                on prodsupp.ProductId equals Products.ProductId
                                                join suppliers in db.Suppliers
                                                on prodsupp.SupplierId equals suppliers.SupplierId
                                                where (Products.ProdName == prodNameComboBox.Text 
                                                && suppliers.SupName == supNameComboBox.Text)
                                                select prodsupp.ProductSupplierId).Single().ToString();
            }
        }
    }
}
