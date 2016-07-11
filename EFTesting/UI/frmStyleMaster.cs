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
using System.Linq.Expressions;
using ITRACK.Validator;
using System.Diagnostics;
using EFTesting.ViewModel;
using EFTesting.UI.User_Accounts;

namespace EFTesting.UI
{
    public partial class frmStyleMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmStyleMaster()
        {
            InitializeComponent();
        }

        #region  Delcaration
            GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
            GenaricRepository<Buyer> _BuyerRepository = new GenaricRepository<Buyer>(new ItrackContext());
            GenaricRepository<Style> _Stylerepository = new GenaricRepository<Style>(new ItrackContext());
            Buyer _Buyer = new Buyer();
            Company _Company = new Company();
            Style _Style = new Style();
            StyleVM _StyleVM = new StyleVM();
            Validator Validator = new Validator();
        #endregion



        #region CRUD


            void Clear() {
                try {
                    txtStyleNo.Text = "";
                    txtArticle.Text = "";
                    txtSeason.Text = "";
                    txtRemark.Text = "";
                    txtBuyerName.Text = "";
                    cmbGarmentType.Text = "";
                   
                    txtStyleNo.Focus();
                    grdSearchBuyer.Hide();
                    btnClose.Hide();

                }
                catch(Exception ex){
                    Debug.WriteLine(ex.Message);
                }
            
            }
        Style AssignStyle() {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                _Style.StyleID = txtID.Text;
                _Style.StyleNo = txtStyleNo.Text;
                _Style.Article = txtArticle.Text;
                _Style.Season = txtSeason.Text;
                _Style.CompanyID = _Company.CompanyID;
                _Style.Remark = txtRemark.Text;
                _Style.Status = "Pending"; 
                _Style.BuyerID = _Buyer.BuyerID;
                _Style.GarmantType = cmbGarmentType.Text;
                _Style.FeedingRule = cmbFeedingRule.Text;
                _Style.ForecastingRule = cmbForecastingRule.Text;
                _Style.WorkflowID= 1 ;
               

                return _Style;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void SearchBuyer()
        {

            try
            {


                ////create expression 
                //ParameterExpression argParam = Expression.Parameter(typeof(Buyer), "s");
                //Expression nameProperty = Expression.Property(argParam, "BuyerName");
                //Expression namespaceProperty = Expression.Property(argParam, "BuyerName");

                //var val1 = Expression.Constant(txtBuyerName.Text);
                //var val2 = Expression.Constant(txtBuyerName.Text);
                ////expresttion 1 
                //Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                //// expresstion 2
                //Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                //var andExp = Expression.Or(e1, e2);


                //// get expresttion to labda objet 
                //var lambda1 = Expression.Lambda<Func<Buyer, bool>>(andExp, argParam);

               

                ItrackContext _context = new ItrackContext();
                var selected = (from item in _context.Buyer
                               where item.BuyerName.Contains(txtBuyerName.Text)
                               select new { item.BuyerID, item.BuyerName, item.BuyerTeleNo, item.FaxNo, item.BuyerShippingAddress }).ToList();
              
                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchBuyer.Show();
                    btnClose.Show();

                    grdSearchBuyer.DataSource = selected;
                }
                else
                {
                    grdSearchBuyer.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SearchStyle() {
            try {
                splashScreenManager1.ShowWaitForm();
                _StyleVM.SearchStyle(grdSearchStyle, txtSearchBox, btnClose);
                splashScreenManager1.CloseWaitForm();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }



        void StyleSearch(string _key) {
            try {
                ItrackContext _context = new ItrackContext();
                var styles = (from item in _context.Style
                              where item.CompanyID == _Company.CompanyID && (item.StyleNo.Contains( _key) || item.Buyer.BuyerName.Contains( _key))
                              select new { item.StyleID, item.StyleNo, item.BuyerID, item.Remark }).ToList();

                if(styles.Count > 0)
                {
                    grdSearchStyle.DataSource = styles;
                    grdSearchStyle.Show();
                }
                else
                {
                    grdSearchStyle.DataSource = null;
                }


            }
            catch (Exception ex) {

            }

        }

        private void AddStyle()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                _Style.CreatedDate = DateTime.Now;
                _Style.CreatedBy = "Admin";
                _Stylerepository.Add(AssignStyle());

               
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddCutheader()
        {
            try
            {
                GenaricRepository<CuttingHeader> _CuttingHeaderRepo = new GenaricRepository<CuttingHeader>(new ItrackContext());
                CuttingHeader _cuttingHeader = new CuttingHeader();
                _cuttingHeader.CuttingHeaderID = "C-" + txtStyleNo.Text;
                _cuttingHeader.StyleID = txtID.Text;
                _cuttingHeader.OrderQuantity = 0;
                _cuttingHeader.PlanQuantity = 0;
                _cuttingHeader.ItemType = cmbGarmentType.Text;
                _cuttingHeader.status = "Pending";
                _cuttingHeader.Remark = txtRemark.Text;
                _cuttingHeader.Date = DateTime.Now;
                _cuttingHeader.CreatedDate = DateTime.Now;
                _cuttingHeader.CreatedBy = "Admin";
                _CuttingHeaderRepo.Insert(_cuttingHeader);
            
            }
            catch(Exception ex)
            {

            }
        }

        async void editStyle()
        {


            try
            {
                splashScreenManager1.ShowWaitForm();
                GenaricRepository<Style> _genaricrepositoryStylenew = new GenaricRepository<Style>(new ItrackContext());
                await _genaricrepositoryStylenew.EditAsync(AssignStyle());
                BaseEntity _base = new BaseEntity();
                _base.UpdateLastModified("Update Styles set LastModifiedBy='admin',LastModifiedAt='" + DateTime.Now.ToString() + "' where StyleID='" + _Style.StyleID + "'");
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getStyleFeild(string ID)
        {
            try
            {

                foreach (var style in GetStyleByID(ID))
                {
                    txtStyleNo.Text = style.StyleNo;
                    txtID.Text = style.StyleID;
                    txtBuyerName.Text = style.Buyer.BuyerName;
                    txtArticle.Text = style.Article;
                    
                    cmbGarmentType.Text = style.GarmantType;
                    txtRemark.Text = style.Remark;
                    _Company.CompanyID = style.CompanyID;
                    txtSeason.Text = style.Season;
                    cmbFeedingRule.Text = style.FeedingRule;
                    cmbForecastingRule.Text = style.ForecastingRule;
                    _Buyer = style.Buyer;
                    txtCreatedBy.Text = style.CreatedBy;
                    txtCreatedDate.Text =Convert.ToString( style.CreatedDate);
                    txtLastModified.Text = style.LastModifiedAt;
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Style> GetStyleByID(string ID)
        {
            try
            {
                return _Stylerepository.GetAll().Where(u => u.StyleID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
        #endregion



        #region FabricDetails 
        FabricDetails fDetails = new FabricDetails();
        FabricDetails AssignfDetails() {
            try {

                fDetails.FabricType = cmbFabricType.Text;
                fDetails.FabricName = txtFabricName.Text;
                fDetails.Color = txtFabricColor.Text;
                fDetails.PlanedConsumtion =Convert.ToDouble( txtPlanedConsumtion.Text);
                fDetails.Remark = txtfRemark.Text;
                fDetails.StyleID = txtID.Text;
                fDetails.FabricDetailsID = this.fDetailsID;
                return fDetails;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }


        bool AddFabricDetails() {
            try {
                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                _FabricDetailsRepository.Add(AssignfDetails());
                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }

        }


        bool EditFabricDetails()
        {
            try
            {
                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                _FabricDetailsRepository.Edit(AssignfDetails());
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        List<FabricDetails> lstFabric = new List<FabricDetails>();
        List<FabricDetails> GetFabricList(string _styleNo) {
            try {

                GenaricRepository<FabricDetails> _FabricDetailsRepository = new GenaricRepository<FabricDetails>(new ItrackContext());
                var list = from items in _FabricDetailsRepository.GetAll().Where(u => u.StyleID == _styleNo).ToList() select new { items.FabricDetailsID,items.FabricType,items.FabricName,items.Color,items.PlanedConsumtion,items.Remark};
                grdFabricList.DataSource = list;

                return lstFabric;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;

            }
        
        }

        public int fDetailsID { get; set; }

        void GetFabricDetailsField() {
            try
            {
                cmbFabricType.Text = gridView3.GetFocusedRowCellValue("FabricType").ToString();
                txtFabricName.Text = gridView3.GetFocusedRowCellValue("FabricName").ToString();
                txtFabricColor.Text = gridView3.GetFocusedRowCellValue("Color").ToString();
                txtPlanedConsumtion.Text = gridView3.GetFocusedRowCellValue("PlanedConsumtion").ToString();
                txtfRemark.Text = gridView3.GetFocusedRowCellValue("Remark").ToString();
                this.fDetailsID = Convert.ToInt16(gridView3.GetFocusedRowCellValue("FabricDetailsID").ToString());
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        
        }

        #endregion 

        #region events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidStyleMaster() == true)

                
            AddStyle();
            AddCutheader();
        }

        private void txtBuyerName_EditValueChanged(object sender, EventArgs e)
        {
            SearchBuyer();
        }

        private void txtBuyerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchBuyer.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchBuyer.Hide();

            }
        }

        private void grdSearchBuyer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Buyer.BuyerID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("BuyerID").ToString());
                _Buyer.BuyerName = gridView1.GetFocusedRowCellValue("BuyerName").ToString();
                txtBuyerName.Text = _Buyer.BuyerName;
                grdSearchBuyer.Hide();
            }



        }

        CompanyVM CVM = new CompanyVM();

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


        private void frmStyleMaster_Load(object sender, EventArgs e)
        {
            grdSearchBuyer.Hide();
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            GetDefualtCompany();
            btnClose.Hide();
            try {
                ItrackContext _context = new ItrackContext();
                _context.Database.Initialize(false);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
          
            
        }


     

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            // SearchStyle();
            StyleSearch(txtSearchBox.Text);
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
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

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                splashScreenManager1.ShowWaitForm();
                _Style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
                getStyleFeild(_Style.StyleID);
                GetFabricList(_Style.StyleID);
                grdSearchStyle.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
                grdSearchBuyer.Hide();
                splashScreenManager1.CloseWaitForm();
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            GetNewCode();

        }

        int getPoCount()
        {
            try
            {
                GenaricRepository<Style> _GRNRepo = new GenaricRepository<Style>(new ItrackContext());
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "Style"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtID.Text = _Engine.GenarateNo(_No, getPoCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            editStyle();
        }
        #endregion

        #region validation
        public bool isValidStyleMaster()
        {


            if (!Validator.isPresent(txtStyleNo, "Style No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtBuyerName, "Buyer Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtArticle, "Article"))
            {
                return false;
            }

            if (!Validator.isPresent(txtSeason, "Season"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbGarmentType, "Garment Type"))
            {
                return false;
            }

           
            if (!Validator.isPresent(cmbFeedingRule, "Feeding Rule"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbForecastingRule, "Forecasting Rule"))
            {
                return false;
            }

            return true;
        }


        public bool isValidFabricDetails()
        {
            if (!Validator.isPresent(cmbFabricType, "Fabric Type"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFabricName, "Fabric Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFabricColor, "Fabric Color"))
            {
                return false;
            }

            if (!Validator.isPresent(txtPlanedConsumtion, "Planed Consumption"))
            {
                return false;
            }



            return true;
        }
        #endregion

        private void btnfAdd_Click(object sender, EventArgs e)
        {
            if (isValidFabricDetails() == true)
            {
                AddFabricDetails();
                GetFabricList(txtID.Text);
            }
            
            
        }

        private void btnfUpdate_Click(object sender, EventArgs e)
        {
            if (btnfUpdate.Text == "Edit")
            {
                GetFabricDetailsField();
                btnfUpdate.Text = "Update";
            }
            else
            {
                btnfUpdate.Text = "Edit";
                EditFabricDetails();
                GetFabricList(txtStyleNo.Text);
            }
        }


    }
}