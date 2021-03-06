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
using ITRACK.models;
using EFTesting.Reports.Report;
using DevExpress.XtraReports.UI;
using EFTesting.Reports.Asset;
using EFTesting.ViewModel;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using EFTesting.UI.User_Accounts;

namespace EFTesting.UI.Asset
{
    public partial class frmMachineReqirement : DevExpress.XtraEditors.XtraForm
    {
        public frmMachineReqirement()
        {
            InitializeComponent();
        }


        List<MachineRequirementItem> lstItems = new List<MachineRequirementItem>();

        List<MachineRequirementItem> lstRItems = new List<MachineRequirementItem>();





        void Update(int _ID,int _nos)
        {
            try
            {
                foreach (var item in lstItems.Where(x => x.MachineRequirementItemID == _ID))

                {
                    item.Nos = _nos;
                }

                grdMachines.DataSource = lstItems;



            }
            catch (Exception ex)
            {

            }

        }



        bool isAvailble(string _type) {

            try {
                var item = (from items in lstRItems
                            where items.MachineType == _type
                            select items).ToList();

                if (item.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }

        void FeedList()
        {
            try {

                ItrackContext _context = new ItrackContext();
                lstItems.Clear();
                foreach(var item in _context.MachineType)
                {
                    MachineRequirementItem ritem = new MachineRequirementItem();
                    ritem.MachineRequirementID = item.MachineTypeID;
                    ritem.MachineType = item.MachineTypeName;
                    ritem.MachineRequirementItemID = lstItems.Count + 1;
                    ritem.Remark = "";
                    ritem.Nos = 0;

                 if(isAvailble(ritem.MachineType) == false)
                    {
                        lstItems.Add(ritem);
                    }

                    grdMachines.Show();
                    grdItems.Hide();


                }
                grdMachines.DataSource = null;
                grdMachines.DataSource = lstItems;
                gridView1.Columns["MachineRequirement"].Visible = false;
                gridView1.Columns["MachineRequirementID"].Visible = false;
            }
            catch (Exception ex) {

            }

        }



        void AddToRequirement() {
            try {

                foreach(var item in lstItems)
                {
                    if(item.Nos > 0)
                    {
                        item.MachineRequirementItemID = lstRItems.Count + 1;
                        lstRItems.Add(item);
                    }
                }

                grdItems.DataSource = null;
                grdItems.DataSource = lstRItems;
                lstItems.Clear();
                grdItems.Show();
                grdMachines.Hide();
                grdMachines.DataSource = null;
             
            }
            catch (Exception ex) {

            }
        }






        MachineRequirement AssignMachine() {

            MachineRequirement _machine = new MachineRequirement();
            _machine.LineNo = cmbLineNo.Text;
            _machine.StyleNo = txtStyleNo.Text;
            _machine.StyleID = StyleRef;
            _machine.Remark = txtRemark.Text;
            _machine.MachineRequirementID = txtRequirementID.Text;
            return _machine;

        }

        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());


        void FeedCombo(ComboBoxEdit combo)
        {
            try
            {

                ComboBoxItemCollection coll = combo.Properties.Items;
                ItrackContext _context = new ItrackContext();
                GenaricRepository<PurchaseOrderItems> _PoRepo = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());

                var items = (from item in _context.Department
                            select item).ToList();
                foreach (var item in items )
                {
                    coll.Add(item.Name);

                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }



        private void UpdateLabel()
        {
            try
            {
                ItrackContext context = new ItrackContext();
                


                string _Query = "UPDATE EFAppointments set Label = '2' where StyleID = '"+ StyleRef +"' and Description = '"+ cmbLineNo.Text +"'";
                context.Database.ExecuteSqlCommand(_Query);
            }
            catch (Exception ex)
            {

            }


        }

        private void AddType()
        {
            try
            {
                GenaricRepository<MachineRequirement> _MachineReq = new GenaricRepository<MachineRequirement>(new ItrackContext());
              if(_MachineReq.Insert(AssignMachine()) == true)
                {
                    UpdateLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMachineItems() {
            try
            {
                int i = 0;
               foreach(var items in lstRItems)
                {
                    GenaricRepository<MachineRequirementItem> _MachineReq = new GenaricRepository<MachineRequirementItem>(new ItrackContext());
                    items.MachineRequirementID = txtRequirementID.Text;
                  if(_MachineReq.Insert(items) == true)
                    {
                        i = i + 1;
                    }
                   

                }
                if (i > 0)
                {
                    MessageBox.Show("Save Sucessfully", "Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }








        void Search(string _styleNo) {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.MachineRequirement

                             where item.StyleID.Contains(_styleNo)

                             select new {item.MachineRequirementID, item.StyleNo,item.LineNo,item.Remark}).ToList();
                if (items.Count > 0)
                {
                    grdSearch.DataSource = items;
                    grdSearch.Show();
                }
                else
                {
                    grdSearch.DataSource = null;
                }
           
            }
            catch (Exception ex) {

            }
        }


        CompanyVM CVM = new CompanyVM();
        Company _Company = new Company();

        private void GetDefualtCompany()
        {


            _Company.CompanyID = CVM.GetCompany();
            _Company.CompanyID = frmLoging._user.Employee.CompanyID;
            if (_Company.CompanyID == 0)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                MessageBox.Show("Please Add Defualt Company Before Get Started", "Defualt Company not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void frmMachineReqirement_Load(object sender, EventArgs e)
        {
            //   FeedList();
           
            
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            ItrackContext _context = new ItrackContext();
            _context.Database.Initialize(false);
           
            grdStyleSearch.Hide();
            GetNewCode();
            GetDefualtCompany();
            FeedConmbo();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FeedList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddType();
            AddMachineItems();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            int noos =Convert.ToInt16( gridView1.GetFocusedRowCellValue("Nos").ToString());
            int ID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("MachineRequirementItemID").ToString());
            Update(ID, noos);
        }


        string StyleRef = "";
        void GetByID(string _ID) {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.MachineRequirement
                             where item.MachineRequirementID == _ID
                             select item).ToList().Last();


                txtStyleNo.Text = items.StyleNo;
                StyleRef = items.StyleID;
                txtRequirementID.Text = items.MachineRequirementID;
                txtRemark.Text = items.Remark;
                cmbLineNo.Text = items.LineNo;
            }
            catch (Exception ex) {

            }

        }

        void GetItems(string _ID)
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.MachineRequirementItem
                             where item.MachineRequirementID == _ID
                             select item).ToList();
                

                lstRItems = items;
                grdItems.DataSource = null;
                grdItems.DataSource = lstRItems;
                gridView2.Columns["MachineRequirement"].Visible = false;
                gridView2.Columns["MachineRequirementID"].Visible = false;
                gridView2.Columns["MachineRequirementItemID"].Width = 30;
                gridView2.Columns["Nos"].Width = 30;
                grdItems.Show();
                grdMachines.Hide();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            AddToRequirement();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
          
           
            Search(txtSearchBox.Text);
            
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
           string ID = gridView3.GetFocusedRowCellValue("MachineRequirementID").ToString();
            GetByID(ID);
            GetItems(ID);
            grdSearch.Hide();
            grdStyleSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();



        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        int getPoCount()
        {
            try
            {
                GenaricRepository<MachineRequirement> _GRNRepo = new GenaricRepository<MachineRequirement>(new ItrackContext());
                return _GRNRepo.GetAll().ToList().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }

        void GetNewCode()
        {
            try
            {

                RunningNo _No = new RunningNo();
                clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "MR"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtRequirementID.Text = _Engine.GenarateNo(_No, getPoCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            txtStyleNo.Text = "";
            txtRemark.Text = "";
            cmbLineNo.Text = "";
            txtRequirementID.Text = "";
            txtRequirementID.Focus();
            grdItems.DataSource = null;
            lstRItems.Clear();
            GetNewCode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();

        }
        void serachStyle(string _key)
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.Style
                             where item.StyleID.Contains(_key) || item.StyleNo.Contains(_key)
                             select new { item.StyleID,item.StyleNo, item.Buyer.BuyerName, item.Remark }).ToList();

                grdStyleSearch.Show();

                if (items.Count > 0)
                {
                    grdStyleSearch.DataSource = items;
                }
                else
                {
                    grdStyleSearch.DataSource = null;
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
           // print(txtRequirementID.Text);
        }

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            serachStyle(txtStyleNo.Text);
        }

        private void txtStyleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdStyleSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdStyleSearch.Hide();

            }
        }





        void FeedConmbo()
        {
            try
            {

                ComboBoxItemCollection coll = cmbLineNo.Properties.Items;

                ItrackContext _context = new ItrackContext();
                GenaricRepository<Department> _PoRepo = new GenaricRepository<Department>(new ItrackContext());

                var items = (from item in _context.Department
                            where item.CompanyID == _Company.CompanyID
                            select item).ToList();
                foreach (var item in items.Distinct())
                {
                    coll.Add(item.Name);

                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void grdStyleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStyleNo.Text = gridView4.GetFocusedRowCellValue("StyleNo").ToString();
                StyleRef = gridView4.GetFocusedRowCellValue("StyleID").ToString();
                grdStyleSearch.Hide();
            }
          
        }
    }
}