﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace EFTesting.UI.User_Accounts
{
    public partial class frmUserAccounts : DevExpress.XtraEditors.XtraForm
    {
        public frmUserAccounts()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ITRACK.models.ItrackContext dbContext = new ITRACK.models.ItrackContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.User.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.User.Local.ToBindingList();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            ITRACK.models.ItrackContext dbContext = new ITRACK.models.ItrackContext();
            dbContext.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ITRACK.models.ItrackContext dbContext = new ITRACK.models.ItrackContext();
            dbContext.SaveChanges();
        }

        private void frmUserAccounts_Load(object sender, EventArgs e)
        {

        }
    }
}