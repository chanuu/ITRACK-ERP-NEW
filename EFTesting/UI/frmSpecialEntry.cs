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
using System.Diagnostics;
using ITRACK.models;
using EFTesting.ViewModel;
using ITRACK.Validator;
using MyTeamApp;
using System.Linq.Expressions;

namespace EFTesting.UI
{
    public partial class frmSpecialEntry : DevExpress.XtraEditors.XtraForm
    {
        public frmSpecialEntry()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }



        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region CUID

        GenaricRepository<SpecialEntry> _SpecialEntryRepo = new GenaricRepository<SpecialEntry>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
        SpecialEntry _SpecialEntry = new SpecialEntry();
        Company _Company = new Company();
        Items _item = new Items();

        ExcelHelpers E = new ExcelHelpers();
        OpenFileDialog ExcelDialog = new OpenFileDialog();

        private SpecialEntry AssingSpecialEntry()
        {
            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            _SpecialEntry.CompanyID = _Company.CompanyID;
            _SpecialEntry.SpecialEntryID = txtSpecialEntryNo.Text;
            _SpecialEntry.PoNo = txtPo.Text;
            _SpecialEntry.GrnNo = txtGrnNo.Text;
            _SpecialEntry.DispatchNo = txtDispatchNo.Text;
            _SpecialEntry.Date = txtDate.Text;
            _SpecialEntry.TotalRollQty = txtTotalRoll.Text;
            _SpecialEntry.TotalLength = txtTotalLength.Text;
            _SpecialEntry.Remarks = txtRemarks.Text;

            return _SpecialEntry;
        }


        private void AddField()
        {
            try
            {

                GenaricRepository<SpecialEntry> _SpecialEntryRepo = new GenaricRepository<SpecialEntry>(new ItrackContext());
                _SpecialEntryRepo.Add(AssingSpecialEntry());
            }
            catch (Exception ex)
            {

            }
        }

        #endregion


        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void SearchSpecialEntry()
        {
            try

            {


                GenaricRepository<SpecialEntry> _SpecialEntryRepo = new GenaricRepository<SpecialEntry>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(SpecialEntry), "s");
                Expression nameProperty = Expression.Property(argParam, "SpecialEntryID");
                Expression namespaceProperty = Expression.Property(argParam, "PoNo");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<SpecialEntry, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _SpecialEntryRepo.SearchFor(lambda1).ToList() select new { item.SpecialEntryID, item.GrnNo, item.PoNo, item.Date, item.TotalRollQty, item.TotalLength };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchSpecialEntry.Show();
                    btnClose.Show();

                    grdSearchSpecialEntry.DataSource = selected;
                }
                else
                {
                    grdSearchSpecialEntry.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }


        void getSpecialEntry(string ID)
        {
            try
            {
                foreach (var item in getSpecialEntryID(ID))
                {
                    txtSpecialEntryNo.Text = item.SpecialEntryID;
                    txtGrnNo.Text = item.GrnNo;
                    txtPo.Text = item.PoNo;
                    txtDate.Text = item.Date;
                    txtDispatchNo.Text = item.DispatchNo;
                    txtRemarks.Text = item.Remarks;
                    txtTotalRoll.Text = item.TotalRollQty;
                    txtTotalLength.Text = item.TotalLength;

                    grdSearchSpecialEntry.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<SpecialEntry> getSpecialEntryID(string ID)
        {
            try
            {
                return _SpecialEntryRepo.GetAll().Where(u => u.SpecialEntryID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }


        private void SearchItem()
        {
            try

            {


                GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Items), "s");
                Expression nameProperty = Expression.Property(argParam, "ItemsID");
                Expression namespaceProperty = Expression.Property(argParam, "CustomFiled1");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Items, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _ItemMasterRepo.SearchFor(lambda1).ToList() select new { item.ItemsID, item.ItemType, item.CustomFiled1, item.CustomField2 };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdItemSearch.Show();
                    btnClose.Show();

                    grdItemSearch.DataSource = selected;
                }
                else
                {
                    grdItemSearch.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }


        void process()
        {

            ExcelHelpers excel = new ExcelHelpers();
            string path = txtFileName.Text;
            excel.InitializeExcel(path);
            lstFabricItem = excel.ReadFabricDetails(progressBarControl1);

            grdInvoice.DataSource = from item in lstFabricItem
                                    select new { item.SRNo, item.RollNo, item.TotalMeters, item.Color };

            ItrackContext context = new ItrackContext();

            txtTotalLength.Text = Convert.ToString((from item in lstFabricItem select item.TotalMeters).ToList().Sum());
            txtTotalRoll.Text = Convert.ToString(lstFabricItem.Count());




        }
















        private List<Items> GetItemByID(string ID)
        {
            try
            {
                return _ItemMasterRepo.GetAll().Where(u => u.ItemsID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        List<SerialEntry> lstFabricItem = new List<SerialEntry>();

        private void feedFabricDetails(SerialEntry _SerialEntry)
        {
            try
            {
                lstFabricItem.Add(_SerialEntry);
                var itemList = from items in lstFabricItem select new { items.SRNo, items.RollNo, items.TotalMeters, items.Color };
                grdInvoice.DataSource = itemList;
            }
            catch (Exception ex)
            {

            }

        }


        private void AddFabricDetails()
        {
            try
            {

                SerialEntry _SerialEntry = new SerialEntry();

                foreach (var item in lstFabricItem)
                {
                    GenaricRepository<SerialEntry> _SerialEntryRepo = new GenaricRepository<SerialEntry>(new ItrackContext());
                    _SerialEntry.SRNo = item.SRNo;
                    _SerialEntry.SerialEntryID = item.RollNo;
                    _SerialEntry.TotalMeters = item.TotalMeters;
                    _SerialEntry.Color = item.Color;
                    _SerialEntry.ItemsID = txtItemCode.Text;
                    _SerialEntry.RollNo = _SerialEntry.SerialEntryID;
                    _SpecialEntry.SerialEntryID = _SerialEntry.RollNo;


                    _SerialEntry.SpecialEntryID = txtSpecialEntryNo.Text;


                    _SerialEntryRepo.Insert(_SerialEntry);




                }
                feedLedger(_SerialEntry);
            }

            catch (Exception ex)
            {

            }

        }


        void getItemMasterFeild(string ID)
        {
            try
            {

                foreach (var item in GetItemByID(ID))
                {
                    txtItemCode.Text = item.ItemsID;
                }

                grdItemSearch.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Feed Ledger
        private void feedLedger(SerialEntry _item)
        {
            try
            {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                StockLedger _Ledger = new StockLedger();


                _Ledger.CompanyID = _Company.CompanyID;
                _Ledger.TransactionID = txtSpecialEntryNo.Text;
                _Ledger.ItemCode = _item.ItemsID;
                _Ledger.ItemType = "";
                _Ledger.TransactionBy = "Admin";
                _Ledger.TransactionTime = DateTime.Now;
                _Ledger.TransactionType = "Special Entry";
                _Ledger.DocNo = txtSpecialEntryNo.Text;
                _Ledger.Qty = Convert.ToDouble(txtTotalLength.Text);
                _Ledger.Balance = _Ledger.getAvailableBalance(_Ledger.ItemCode) + _Ledger.Qty;


                _Ledger.FeedLedger(_Ledger);
            }
            catch (Exception ex)
            {

            }



        }


        void getSerialItems()
        {

            try
            {
                ItrackContext _context = new ItrackContext();

                var items = (from item in _context.SerialEntry
                             where item.SpecialEntryID == txtSpecialEntryNo.Text
                             select new { item.SRNo, item.RollNo, item.TotalMeters, item.Color }).ToList();

                grdInvoice.DataSource = items;
            }
            catch (Exception ex) { }

        }




        int getSPECount()
        {
            try
            {
                GenaricRepository<SpecialEntry> _SpecialEntryRepo = new GenaricRepository<SpecialEntry>(new ItrackContext());
                return _SpecialEntryRepo.GetAll().ToList().Count;
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "SPE"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtSpecialEntryNo.Text = _Engine.GenarateNo(_No, getSPECount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }


        private void frmSpecialEntry_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddField();
            AddFabricDetails();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchSpecialEntry();
        }

        private void grdSearchSpecialEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _SpecialEntry.SpecialEntryID = gridView2.GetFocusedRowCellValue("SpecialEntryID").ToString();
                getSpecialEntry(_SpecialEntry.SpecialEntryID);
                getSerialItems();

            }
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchSpecialEntry.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {

                grdSearchSpecialEntry.Hide();

            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            GetNewCode();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"C:\";
            ExcelDialog.Title = "Select your Dividing Plan Excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                E.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;


            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            process();
        }

        private void txtItemCode_EditValueChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdItemSearch.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdItemSearch.Hide();
            }
        }
    }
}