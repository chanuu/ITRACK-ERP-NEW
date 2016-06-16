using System;
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
            _machine.StyleID = txtStyleNo.Text;
            _machine.Remark = txtRemark.Text;
            _machine.MachineRequirementID = txtRequirementID.Text;
            return _machine;

        }

        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());

        private void AddType()
        {
            try
            {
                GenaricRepository<MachineRequirement> _MachineReq = new GenaricRepository<MachineRequirement>(new ItrackContext());
                _MachineReq.Add(AssignMachine());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMachineItems() {
            try
            {
               foreach(var items in lstRItems)
                {
                    GenaricRepository<MachineRequirementItem> _MachineReq = new GenaricRepository<MachineRequirementItem>(new ItrackContext());
                    items.MachineRequirementID = txtRequirementID.Text;
                    _MachineReq.Insert(items);

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


        void print(string _ID) {
            try {

                ItrackContext _cntx = new ItrackContext();
                var report =( from item in _cntx.MachineRequirementItem
                             where item.MachineRequirementID == _ID
                             select item).ToList();
                rptMachineRequirement s = new rptMachineRequirement();
                s.DataSource = report;

                DevExpress.XtraReports.UI.ReportPrintTool tool = new ReportPrintTool(s);
                tool.ShowPreview();
            }
            catch (Exception ex) {

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



        void GetByID(string _ID) {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.MachineRequirement
                             where item.MachineRequirementID == _ID
                             select item).ToList().Last();

                txtStyleNo.Text = items.StyleID;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtStyleNo.Text = "";
            txtRemark.Text = "";
            cmbLineNo.Text = "";
            txtRequirementID.Text = "";
            txtRequirementID.Focus();
            grdItems.DataSource = null;
            lstRItems.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            print(txtRequirementID.Text);
        }
    }
}