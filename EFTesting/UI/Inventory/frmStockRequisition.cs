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
using ITRACK.Validator;
using System.Diagnostics;
using EFTesting.ViewModel;
using System.Linq.Expressions;

namespace EFTesting.UI.Inventory
{
    public partial class frmStockRequisition : DevExpress.XtraEditors.XtraForm
    {
        public frmStockRequisition()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion


        #region CUID


        GenaricRepository<StockRequisition> _StockRequisitionRepo = new GenaricRepository<StockRequisition>(new ItrackContext());
        GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        StockRequisition _StockRequisition = new StockRequisition();
        Company _Company = new Company();
        Items _item = new Items();
        List<StockRequisitionDetails> lstStockRequisitionItem = new List<StockRequisitionDetails>();


        private StockRequisition AssingStockRequisition()
        {
            _StockRequisition.StockRequisitionID = txtRequisitionNo.Text;
            _StockRequisition.LocationCode = cmbLocationCode.Text;
            _StockRequisition.LocationName = txtLocationName.Text;
            _StockRequisition.Date = txtDate.Text;
            _StockRequisition.FromDepartment = txtFromDepartment.Text;
            _StockRequisition.ToDepartment = txtToDepartment.Text;


            return _StockRequisition;

        }

        private void AddFiled()
        {
            try
            {
                GenaricRepository<StockRequisition> _StockRequisitionRepo = new GenaricRepository<StockRequisition>(new ItrackContext());
                _StockRequisitionRepo.Add(AssingStockRequisition());
            }
            catch (Exception ex)
            {

            }
        }


        private void addStockRequisitionDetails()
        {
            try
            {
                GenaricRepository<StockRequisitionDetails> _StockRequisitionDetailsRepo = new GenaricRepository<StockRequisitionDetails>(new ItrackContext());
                StockRequisitionDetails _StockRequisitionDetails = new StockRequisitionDetails();

                foreach (var item in lstStockRequisitionItem)
                {
                    _StockRequisitionDetails.ItemCode = item.ItemCode;
                    _StockRequisitionDetails.Description = item.Description;
                    _StockRequisitionDetails.RequestedQty = item.RequestedQty;
                    _StockRequisitionDetails.AvailableBalance = item.AvailableBalance;
                    _StockRequisitionDetails.StockRequisitionID = txtRequisitionNo.Text;
                    _StockRequisitionDetailsRepo.Add(_StockRequisitionDetails);

                }

            }
            catch (Exception ex)
            {

            }


        }

        int getReqCount()
        {
            try
            {
                GenaricRepository<StockRequisition> _StockRequisitionRepo = new GenaricRepository<StockRequisition>(new ItrackContext());
                return _StockRequisitionRepo.GetAll().ToList().Count;
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "REQ"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtRequisitionNo.Text = _Engine.GenarateNo(_No, getReqCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }
        private void SearchItem()
        {
            try
            {
                GenaricRepository<StockRequisition> _StockRequisitionRepo = new GenaricRepository<StockRequisition>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(StockRequisition), "s");
                Expression nameProperty = Expression.Property(argParam, "StockRequisitionID");
                Expression namespaceProperty = Expression.Property(argParam, "Date");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<StockRequisition, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _StockRequisitionRepo.SearchFor(lambda1).ToList() select new { item.StockRequisitionID, item.Date, item.FromDepartment, item.ToDepartment };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchReq.Show();
                    btnClose.Show();

                    grdSearchReq.DataSource = selected;
                }
                else
                {
                    grdSearchReq.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }

        private void SearchItemCode()
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
                    grdSearchRequisition.Show();
                    btnClose.Show();

                    grdSearchRequisition.DataSource = selected;
                }
                else
                {
                    grdSearchRequisition.DataSource = null;
                }

            }
            catch (Exception ex)
            {


            }

        }




        void getStockRequisition(string ID)
        {
            try
            {
                foreach (var item in getRequisitioID(ID))
                {
                    txtRequisitionNo.Text = item.StockRequisitionID;
                    cmbLocationCode.Text = item.LocationCode;
                    txtLocationName.Text = item.LocationName;
                    txtDate.Text = item.Date;
                    txtToDepartment.Text = item.ToDepartment;
                    txtFromDepartment.Text = item.FromDepartment;

                    grdSearchReq.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();


                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<StockRequisition> getRequisitioID(string ID)
        {
            try
            {
                return _StockRequisitionRepo.GetAll().Where(u => u.StockRequisitionID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        void getCompanyDetail(string ID)
        {
            try
            {
                foreach (var item in getCompanyByLocationCode(ID))
                {
                    _Company.CompanyID = item.CompanyID;
                    cmbLocationCode.Text = item.LocationCode;
                    txtLocationName.Text = item.CompanyName;

                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Company> getCompanyID(int ID)
        {
            try
            {
                return _CompanyRepository.GetAll().Where(u => u.CompanyID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private List<Company> getCompanyByLocationCode(string ID)
        {
            try
            {
                return _CompanyRepository.GetAll().Where(u => u.LocationCode == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        #endregion


        #region Conditional Update

        void Update(string _itemcode, int _RequisitedQty)
        {
            try
            {
                foreach (var item in lstStockRequisitionItem.Where(x => x.ItemCode == _itemcode))
                {
                    item.RequestedQty = _RequisitedQty;
                }
                grdRequisition.DataSource = lstStockRequisitionItem;

            }
            catch (Exception ex)
            {

            }

        }
        #endregion


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

        StockLedger ledger = new StockLedger();

        void getItemMasterFeild(string ID)
        {
            try
            {

                foreach (var item in GetItemByID(ID))
                {

                    txtItem.Text = item.ItemsID;
                    txtItemDescription.Text = item.ItemType + " (" + item.CustomFieldSetup.CustomField1 + " - " + item.CustomFiled1 + " " + item.CustomFieldSetup.CustomField2 + " - " + item.CustomField2 + " " + item.CustomFieldSetup.CustomField3 + " - " + item.CustomField3 + ")";

                    txtAvailableBalance.Text = Convert.ToString(ledger.getAvailableBalance(ID));
                    grdSearchRequisition.Hide();
                    grdSearchRequisition.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void feedStockRequisitonItem(StockRequisitionDetails _StockRequisitionDetails)
        {
            try
            {
                lstStockRequisitionItem.Add(_StockRequisitionDetails);
                var itemList = from items in lstStockRequisitionItem select new { items.ItemCode, items.Description, items.AvailableBalance, items.RequestedQty };
                grdRequisition.DataSource = itemList;

                gridView1.Columns["ItemCode"].Width = 100;
                gridView1.Columns["Description"].Width = 440;
                gridView1.Columns["AvailableBalance"].Width = 80;
                gridView1.Columns["RequestedQty"].Width = 80;



            }
            catch (Exception ex)
            { }
        }

        void setStockReqisitioItem(string StockRequisitionNo)
        {
            try
            {
                GenaricRepository<StockRequisitionDetails> _StockRequisitionDetailsRepo = new GenaricRepository<StockRequisitionDetails>(new ItrackContext());
                var dataSource = from item in _StockRequisitionDetailsRepo.GetAll().ToList() where item.StockRequisitionID == StockRequisitionNo select item;
                grdRequisition.DataSource = dataSource;

                gridView1.Columns["Items"].Visible = false;
                gridView1.Columns["StockRequisitionID"].Visible = false;
                gridView1.Columns["StockRequisition"].Visible = false;
                gridView1.Columns["StockRequisitionDetailsID"].Visible = false;

                gridView1.Columns["ItemCode"].Width = 100;
                gridView1.Columns["Description"].Width = 440;
                gridView1.Columns["AvailableBalance"].Width = 80;
                gridView1.Columns["RequestedQty"].Width = 80;


            }
            catch (Exception ex)
            {

            }
        }



        void initlizedRequisitonItem()
        {

            StockRequisitionDetails stock = new StockRequisitionDetails();
            stock.ItemCode = txtItem.Text;
            stock.Description = txtItemDescription.Text;
            stock.AvailableBalance = Convert.ToDouble(txtAvailableBalance.Text);
            stock.RequestedQty = Convert.ToInt16(txtRequestedQty.Text);
            feedStockRequisitonItem(stock);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFiled();
            addStockRequisitionDetails();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchReq.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchReq.Hide();
            }

        }

        private void grdSearchReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _StockRequisition.StockRequisitionID = gridView2.GetFocusedRowCellValue("StockRequisitionID").ToString();
                setStockReqisitioItem(_StockRequisition.StockRequisitionID);
                getStockRequisition(_StockRequisition.StockRequisitionID);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GetNewCode();
        }

        private void frmStockRequisition_Load(object sender, EventArgs e)
        {
            grdSearchReq.Hide();
            grdSearchRequisition.Hide();
        }

        private void txtItem_EditValueChanged(object sender, EventArgs e)
        {
            SearchItemCode();
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchRequisition.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdSearchRequisition.Hide();
            }
        }

        private void grdSearchRequisition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                _item.ItemsID = gridView3.GetFocusedRowCellValue("ItemsID").ToString();
                getItemMasterFeild(_item.ItemsID);



            }
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            initlizedRequisitonItem();
        }

        private void grdSearchReq_Click(object sender, EventArgs e)
        {

        }

        private void grdSearchRequisition_Click(object sender, EventArgs e)
        {

        }
    }
}