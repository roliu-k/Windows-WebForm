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
    // This should allow adding/modifying Suppliers in the Supplier database.

    public partial class frmSuppliers : Form
    {
        //travelexpertsDataContext = new travelexpertsDataContext

        public frmSuppliers()
        {
            InitializeComponent();
            supplierBindingSource.DataSource = new travelexpertsDataContext().Suppliers;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}