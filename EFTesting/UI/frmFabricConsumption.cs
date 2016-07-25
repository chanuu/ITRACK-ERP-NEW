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
using ITRACK.Validator;
using ITRACK.models;
using EFTesting.UI.User_Accounts;
using System.Diagnostics;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmFabricConsumption : DevExpress.XtraEditors.XtraForm
    {
        public frmFabricConsumption()
        {
            InitializeComponent();
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



        Validator validate = new Validator();
        FabricLedger _ledger = new FabricLedger();

        public string StyleRef { get; set; }

        private FabricLedger AssignFabricDetails()
        {

            try
            {

                _ledger.CompanyID = _Company.CompanyID;
                _ledger.StyleNo = _style.StyleID;
                _ledger.MarkerNo = txtMNo.Text;
                _ledger.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _ledger.RollNo = txtRoleNo.Text;
                _ledger.MarkerLength = Convert.ToDouble(txtRollWidth.Text);
                _ledger.Type = "";
                _ledger.NoOfFlys = Convert.ToInt16(txtNoOfPlys.Text);
                _ledger.FabricUsed = _ledger.NoOfFlys * _ledger.MarkerLength;
                _ledger.NotedLength = Convert.ToDouble(txtRollHegiht.Text);
                _ledger.StyleRef = _style.StyleNo;
                 

                if (txtActualBalance.Text != "")
                {
                    _ledger.ActualBalance = Convert.ToDouble(txtActualBalance.Text);
                    _ledger.NotedBalance = Convert.ToDouble(txtNotedBalance.Text);

                }
                else
                {
                    _ledger.NotedBalance = Convert.ToDouble(txtNotedBalance.Text);
                }




                return _ledger;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return null;

            }


        }
        private void AddLayerDetails()
        {
            try
            {
                GenaricRepository<FabricLedger> _LayinDetailsRepo = new GenaricRepository<FabricLedger>(new ItrackContext());
                _LayinDetailsRepo.Add(AssignFabricDetails());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        private bool isExistingItem(string _markerNo)
        {
            try
            {
                GenaricRepository<CuttingItem> _CutItemrepo = new GenaricRepository<CuttingItem>(new ItrackContext());
                if (_CutItemrepo.GetAll().Where(x => x.MarkerNo == _markerNo).ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }

        }
        public bool isValidLayer()
        {
            if (!validate.isPresent(txtRoleNo, "Fabric Roll ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtRollWidth, "Fabric Roll Width"))
            {
                return false;
            }

            if (!validate.isPresent(txtRollHegiht, "Fabric Roll Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtNoOfPlys, "No Of Plys"))
            {
                return false;
            }

           

            if (!validate.isPresent(txtFabused, "Fabric Used"))
            {
                return false;
            }


            return true;
        }


        void clear() {


            

          
            txtMNo.Text = "";
            txtRollWidth.Text = "";
            txtNoOfPlys.Text = "";
            txtRoleNo.Text = "";
            txtRollHegiht.Text = "";
            txtNotedBalance.Text = "";
            txtNotedBalance.ReadOnly = false;
            txtFabused.ReadOnly = false;
            grdSearchStyle.Hide();




        }
        private void btnAddFabric_Click(object sender, EventArgs e)
        {

            if (isValidLayer() == true)
            {
                if (isExistingItem(txtMNo.Text) == true)
                {
                    AddLayerDetails();
                    feed();
                    clear();
                    // FeedLayinDetails(txtStyleNo.Text);
                }
                else
                {
                    MessageBox.Show("Please Check Marker No", "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }





        private void frmFabricConsumption_Load(object sender, EventArgs e)
        {
            GetDefualtCompany();
            grdSearchStyle.Hide();
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }





        void searchStyle(string _key)
        {
            try {
                ItrackContext _context = new ItrackContext();
               var styles = (from item in _context.Style
                             where item.CompanyID == _Company.CompanyID && (item.StyleNo.Contains(_key) || item.Buyer.BuyerName.Contains(_key))
                             select new { item.StyleID, item.StyleNo, item.BuyerID, item.Remark }).ToList();

                if (styles.Count > 0)
                {
                    grdSearchStyle.Show();
                    grdSearchStyle.DataSource = styles;
                }
                else
                {
                    grdSearchStyle.DataSource = null;
                }
                
            }
            catch (Exception ex) {
            }
        }

        void searchStyle2(string _key)
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                var styles = (from item in _context.Style
                              where item.CompanyID == _Company.CompanyID && (item.StyleNo.Contains(_key) || item.Buyer.BuyerName.Contains(_key))
                              select new { item.StyleID, item.StyleNo, item.BuyerID, item.Remark }).ToList();

                if (styles.Count > 0)
                {
                    grdSearch.Show();
                    grdSearch.DataSource = styles;
                }
                else
                {
                    grdSearch.DataSource = null;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            searchStyle(txtStyleNo.Text);
        }

        private void txtStyleNo_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchStyle.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchStyle.Hide();
          
            }

        }

        Style _style = new Style();
        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
               _style.StyleNo = gridView2.GetFocusedRowCellValue("StyleNo").ToString();
                txtStyleNo.Text = _style.StyleNo;
                grdSearchStyle.Hide();

            }
        }


        double GetBalance(string _id)
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                return (from r in _context.SerialEntry
                        where r.SerialEntryID == _id
                        select new { r.TotalMeters }).ToList().Last().TotalMeters;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        double GetAvailBal(string _rollNo)
        {
            try
            {
                ItrackContext _context = new ItrackContext();

                return (from item in _context.FabricLedger
                        where item.RollNo == _rollNo
                        select item.FabricUsed).ToList().Sum();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void txtRoleNo_Leave(object sender, EventArgs e)
        {
            txtRollHegiht.Text = Convert.ToString(GetBalance(txtRoleNo.Text));
            txtAvailBal.Text = Convert.ToString(GetBalance(txtRoleNo.Text) - GetAvailBal(txtRoleNo.Text));
           
        }



        void feed() {

            try {
                ItrackContext _context = new ItrackContext();
                grdFabricDetails.DataSource = (from item in _context.FabricLedger
                                              where item.StyleNo == _style.StyleID
                                              select new { item.StyleNo, item.RollNo ,item.NotedLength,  item.MarkerNo,item.NoOfFlys,item.FabricUsed,item.NotedBalance,item.ActualBalance}).ToList();


                grdSearchStyle.Hide();

            }
            catch (Exception ex) {

            }

        }
        private void txtNoOfPlys_Leave(object sender, EventArgs e)
        {
            txtFabused.Text = Convert.ToString(Convert.ToDouble(txtNoOfPlys.Text) * Convert.ToDouble(txtRollWidth.Text));
            txtNotedBalance.Text = Convert.ToString(Convert.ToDouble(txtAvailBal.Text) - Convert.ToDouble(txtFabused.Text));

            txtNotedBalance.ReadOnly = true;
            txtFabused.ReadOnly = true;
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


        void feedSt(string _key)
        {

            try
            {
                ItrackContext _context = new ItrackContext();
                grdFabricDetails.DataSource = (from item in _context.FabricLedger
                                               where item.StyleNo == _key
                                               select new { item.StyleNo,item.Date,   item.RollNo, item.NotedLength, item.MarkerNo, item.NoOfFlys, item.FabricUsed, item.NotedBalance, item.ActualBalance }).ToList();


                grdSearchStyle.Hide();

            }
            catch (Exception ex)
            {

            }

        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _style.StyleID = gridView3.GetFocusedRowCellValue("StyleID").ToString();
                _style.StyleNo = gridView3.GetFocusedRowCellValue("StyleNo").ToString();


                feedSt(_style.StyleID);

                txtStyleNo.Text = _style.StyleNo;
                grdSearch.Hide();
                grdSearchStyle.Hide();
                

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Hide();
            txtSearchBox.Hide();
            grdSearch.Hide();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            searchStyle2(txtSearchBox.Text);
        }



        private void GetCuttingDetailsReport()
        {
            try
            {
                //   rptCuttingDetails report = new rptCuttingDetails();
                //  report.DataSource = GetCuttingDetailsReport(txtStyleNo.Text);

                rptFabric report = new rptFabric();

                ItrackContext _context = new ItrackContext();
                if(chkByStyle.Checked == true)
                {
                    var list = (from item in _context.FabricLedger
                                where item.StyleNo == _style.StyleID
                                select item).ToList();

                    report.DataSource = list;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }
                else
                {
                    DateTime _from = Convert.ToDateTime(txtFrom.Text);
                    DateTime _to = Convert.ToDateTime(txtTo.Text);
                    var list = (from item in _context.FabricConsumption
                                where item.Date > _from && item.Date < _to
                                select item).ToList();

                    report.DataSource = list;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }

               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            GetCuttingDetailsReport();
        }
    }
}