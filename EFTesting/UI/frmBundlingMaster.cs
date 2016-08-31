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
using System.Linq.Expressions;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.ViewModel;
using ITRACK.Validator;
using EFTesting.DTOs;

namespace EFTesting.UI
{
    public partial class frmBundlingMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmBundlingMaster()
        {
            InitializeComponent();
        }

        CuttingHeader _cuttingHeader = new CuttingHeader();
        CuttingItem _cuttingItem = new CuttingItem();
        #region CRUD


       

    /// <summary>
    /// 
    /// </summary>
        private void SearchCuttingHeader()
        {

            try
            {

                splashScreenManager1.ShowWaitForm();
                //create expression 
               // ParameterExpression argParam = Expression.Parameter(typeof(CuttingHeader), "s");
               // Expression nameProperty = Expression.Property(argParam, "CuttingHeaderID");
               // Expression namespaceProperty = Expression.Property(argParam, "StyleID");

               // var val1 = Expression.Constant(txtSearchBox.Text);
               // var val2 = Expression.Constant(txtSearchBox.Text);
               // //expresttion 1 
               // Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
               // // expresstion 2
               // Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
               // var andExp = Expression.Or(e1, e2);


               // // get expresttion to labda objet 
               // var lambda1 = Expression.Lambda<Func<CuttingHeader, bool>>(andExp, argParam);
               // // pass object to query 
               //GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());

                ItrackContext Context = new ItrackContext();
             //   Context.Database.Connection.ConnectionString = 

                var select = (from element in Context.CuttingHeader
                              where element.CuttingHeaderID.Contains(txtSearchBox.Text) 
                              select new { element.CuttingHeaderID, element.StyleID, element.OrderQuantity, element.Date, element.Remark }).ToList();

               // var selected = from item in _SearchHeaderRepository.SearchFor(lambda1).ToList() select new { item.CuttingHeaderID, item.StyleID, item.OrderQuantity, item.Date, item.Remark };

                //check is record exist in selected item
                if (select.Count() > 0)
                {
                    grdSearch.Show();
                    btnClose.Show();

                    grdSearch.DataSource = select;
                }
                else
                {
                    grdSearch.DataSource = null;
                }

               splashScreenManager1.CloseWaitForm();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private List<CuttingHeader> GetCuttingByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
               
                return _SearchHeaderRepository.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        void getCuttingFeild(string ID)
        {
            try
            {

                foreach (var header in GetCuttingByID(ID))
                {


                    _cuttingHeader.CuttingHeaderID = header.CuttingHeaderID;
                    txtCuttingTicketNo.Text = header.CuttingHeaderID;
                    txtStyleNo.Text = header.StyleID;
                    txtPlanQty.Text = Convert.ToString(header.PlanQuantity);
                    txtStyleID.Text = header.Style.StyleNo;
                





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private List<CuttingItem> GetCuttingItemByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingItem> _CuttingItem = new GenaricRepository<CuttingItem>(new ItrackContext());
                return _CuttingItem.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        private void GetBundleHeaderDetails()
        {
            try
            {
              //  GenaricRepository<BundleHeader> _BundleHeader = new GenaricRepository<BundleHeader>(new ItrackContext());
                

              //  var selected = from items in _BundleHeader.GetAll().ToList()
              //                 where items.isBundleTagsGerated == true && items.CuttingItem.CuttingHeaderID ==txtCuttingTicketNo.Text

              //                 select items;

              ////  grdBundleTicket.DataSource = _BundleHeader.GetAll().Where(x => x.isBundleTagsGerated == true).ToList();
              //  grdBundleTicket.DataSource = selected;
              //  gridView1.Columns["isOprationTagGenated"].Visible = false;
              //  gridView1.Columns["OprationTagGenaratedTime"].Visible = false;
              //  gridView1.Columns["CuttingItem"].Visible = false;
                GetItemGenareted();
              //  return _BundleHeader.GetAll().Where(x => x.isBundleTagsGerated == true).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return null;

            }

        }






        void GetItemToGenarete() {
            try {
                ItrackContext context = new ItrackContext();

               var items = (from item in context.CuttingItem
                        where item.isGenaratedTags == false && item.CuttingHeader.StyleID == txtStyleNo.Text
                            select new { item.LineNo,item.CuttingItemID,item.CutNo,  item.PoNo, item.MarkerNo, item.Color, item.Size, item.Length, item.NoOfItem,item.NoOfLayer }).ToList();
               grdItemList.DataSource = items;
            }
            catch(Exception ex){
            
            }
        }


        void GetItemGenareted()
        {
            try
            {
                ItrackContext context = new ItrackContext();

                var items = (from item in context.BundleHeader
                             where item.isBundleTagsGerated == true && item.CuttingItem.CuttingHeader.StyleID == txtStyleNo.Text
                             select new {item.GenaratedDate,item.BundleTagGenaratedTime, item.BundleHeaderID,  item.CuttingItem.PoNo,item.CuttingItemID,item.CuttingItem.CutNo, item.CuttingItem.MarkerNo, item.CuttingItem.Color, item.CuttingItem.Size,item.CuttingItem.Length, item.CuttingItem.NoOfItem }).ToList();
                grdBundleTicket.DataSource = items;
            }
            catch (Exception ex)
            {

            }
        }



       
        // check if exist bundle header related to cutting item and remove it from to genarate grid
        List<CuttingItem> RemovedItem(List<CuttingItem> lst)
        {
            try {
                List<CuttingItem> lstItems = new List<CuttingItem>();
              
                int i = 0;
           
                 GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                 foreach (var items in lst)
                 {


                     if (_bhRepo.GetAll().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                     {
                      
                     }
                     else {
                         lstItems.Add(items);
                     }

                    i = i + 1;
                    
                    }


                 return lstItems;

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
             
            }
        }




        List<CuttingItem> PrintBundleItem(List<CuttingItem> lst)
        {
            try
            {
                List<CuttingItem> lstItemsPrint = new List<CuttingItem>();

                int i = 0;

                GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                foreach (var items in lst)
                {


                    if (_bhRepo.GetAll().ToList().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                    {
                        lstItemsPrint.Add(items);
                    }
                    else
                    {
                      
                    }

                    i = i + 1;

                }


                return lstItemsPrint;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_headerId"></param>
        private void FeedCuttingItem(string _headerId)
        {
            try
            {
             //  Debug.WriteLine(RemovedItem(GetCuttingItemByID(_headerId)).Count);
                
          // grdItemList.DataSource =RemovedItem(GetCuttingItemByID(_headerId));

                GetItemToGenarete();
             //   grdBundleTicket.DataSource = PrintBundleItem(GetCuttingItemByID(_headerId));
             //   FeedPrintItemList(Convert.ToInt16(_headerId));

              //  grdBundleTicket.DataSource = PrintBundleItem(GetCuttingItemByID(_headerId));

                //gridView2.Columns["CuttingHeader"].Visible = false;
                //gridView2.Columns["CuttingHeaderID"].Visible = false;
                //gridView2.Columns["BundleHeader"].Visible = false;
                //gridView2.Columns["NoOfPlysLayed "].Visible = false;

                //gridView1.Columns["CuttingHeader"].Visible = false;
                //gridView1.Columns["CuttingHeaderID"].Visible = false;
                //gridView1.Columns["BundleHeader"].Visible = false;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void GenareteTags(int cutID) {
            try {
                AddBundleHeader(cutID);
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        }

        private void AddBundleHeader(int cutID)
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                _BundleHeaderRepository.Insert(AssignBundleHeader(cutID));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }




        private Int64 GetBundleHeaderID() {
            try {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                return  _BundleHeaderRepository.GetAll().ToList().Last().BundleHeaderID;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return 0;
            }
        }


        void UpdateBundleStatus(int cutID)
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                BundleHeader _header = new BundleHeader();
                _header = AssignBundleHeader(cutID);
                _header.isCompleteGenarateTags = true;
                _header.BundleTagGenaratedBy = "Admin";
                _header.BundleTagGenaratedTime =Convert.ToString( DateTime.Now);
                _header.GenaratedDate = DateTime.Now;
                _header.CuttingItemID = BundleHID;
                _BundleHeaderRepository.Update(_header);
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }







        BundleHeader _BundleHeader = new BundleHeader();
        int BundleHID = 0;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BundleHeader AssignBundleHeader(int cutID)
        {
            try
            {


            
                _BundleHeader.BundleTagGenaratedTime = Convert.ToString(DateTime.Now);
                _BundleHeader.isBundleTagsGerated = true;
                _BundleHeader.isOprationTagGenated = false;
                _BundleHeader.OprationTagGenaratedTime = "None";
                _BundleHeader.OprationTagGeratedBy = "None";
                _BundleHeader.CuttingItemID = cutID;

                _BundleHeader.isCompleteGenarateTags = true;
                _BundleHeader.BundleTagGenaratedBy = "Admin";
                _BundleHeader.BundleTagGenaratedTime = Convert.ToString(DateTime.Now);
                _BundleHeader.GenaratedDate = DateTime.Now;


                BundleHID = _BundleHeader.CuttingItemID;


                return _BundleHeader;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        List<PrintWorkOrder> lstOrder = new List<PrintWorkOrder>();

        void FeedWorkOrder() {

            PrintWorkOrder wo = new PrintWorkOrder();

            

            GenarateTags gen = new GenarateTags();
            wo.Noos = GetLastItemOfQue() + 1;
            wo.LineNo = gridView2.GetFocusedRowCellValue("LineNo").ToString();
            wo.StyleNo = txtStyleNo.Text;
            wo.NoofItem = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfItem").ToString());
            wo.NoOfLayers = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfLayer").ToString());
            wo.CuttingItemID = Convert.ToInt16(gridView2.GetFocusedRowCellValue("CuttingItemID").ToString());
            wo.PoNo = gridView2.GetFocusedRowCellValue("PoNo").ToString();
            wo.CutNo = gridView2.GetFocusedRowCellValue("CutNo").ToString();
            wo.BundleSize = Convert.ToInt16(txtBundleSize.Text);
            wo.BundleHeaderId = GetBundleHeaderID();
          if(isExistingItem(wo.CuttingItemID) == false)
            {
                lstOrder.Add(wo);
            }
            else
            {
                MessageBox.Show("Item Already Exist", "Error Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            

        }


      int  GetLastItemOfQue()
        {
            try {
                return (from item in lstOrder select item.Noos).ToList().Last();
            }
            catch (Exception ex) {
                return 0;
            }
           
        }

        List<OprationBarcodes> lst = new List<OprationBarcodes>();

        private void GenarateTags() {
            try {

                if (gridView2.RowCount > 0) {
                    Cursor.Current = Cursors.WaitCursor;
                    _cuttingHeader.CuttingHeaderID = txtCuttingTicketNo.Text;
                    
                    // add bundle Header 
                  //  GenareteTags();


                    GenarateTags gen = new GenarateTags();
                    Int64 bundlehader = GetBundleHeaderID();
                    string _lineNo = gridView2.GetFocusedRowCellValue("LineNo").ToString();
                    string _StyleNo = txtStyleNo.Text;
                    int _noofItem = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfItem").ToString());
                    int _noofLayer = Convert.ToInt16(gridView2.GetFocusedRowCellValue("NoOfLayer").ToString());
                    int _cutID = Convert.ToInt16(gridView2.GetFocusedRowCellValue("CuttingItemID").ToString());
                    string _CutNo = gridView2.GetFocusedRowCellValue("CutNo").ToString();
                    int _bundleSize = Convert.ToInt16(txtBundleSize.Text);
                    string StyleID = txtStyleID.Text;

                    List<OprationBarcodes> lst = new List<OprationBarcodes>();
                    //genarate opration tags 
                    gen.GenrateBundleTags(_noofLayer, _noofItem/_noofLayer, _bundleSize, bundlehader, _StyleNo, lst,txtStyleNo.Text,_CutNo, StyleID);

                   //update cutting item genarated tgs status
                  //  UpdateBundleStatus();


                    UpdateGeratedStatus(_cutID);
                    //Feed Cutting Items 
                    FeedCuttingItem(_cuttingHeader.CuttingHeaderID);

                    GetBundleHeaderDetails();


                    //using sql bulk copy
                    SqlBulkCopyHelper _helper = new SqlBulkCopyHelper();

                    // Copy data set using Sql Bulk Copy helper 
                    _helper.PerformBulkCopy(_helper.ConvertTagsToDatatable(lst));

                    Debug.WriteLine(lst.Count + "Count Of Record");
                   
                    //update Bundle Header Deta
                   // UpdateBundleStatus();
                    Cursor.Current = Cursors.Default;


                }
               

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }

        private void UpdateGeratedStatus(int _cutID)
        {
            try
            {
                ItrackContext context = new ItrackContext();
                string _Query = "update CuttingItems set isGenaratedTags = 'True' where CuttingItemID ='" + _cutID + "'";
                context.Database.ExecuteSqlCommand(_Query);
            }
            catch (Exception ex)
            {

            }


        }


        private void FeedPrintItemList(int cutID) {
            
            GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
            
            try {
                var print = from item in _bhRepo.GetAll().ToList() where item.CuttingItemID == cutID select new { item.CuttingItemID,item.CuttingItem.CuttingHeader.StyleID, item.CuttingItem.MarkerNo, item.BundleHeaderID, item.CuttingItem.Size, item.CuttingItem.NoOfLayer, item.CuttingItem.Date };
                grdBundleTicket.DataSource = print;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        private bool GenarateOprationBarcode() {
            try {


                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }
        }







        #endregion

        #region Diclaration

        Validator validator = new Validator();

        #endregion

        #region Valiadtion

        public bool isValidBundlingMaster()
        {

            if (!validator.isPresent(txtCuttingTicketNo, "Cutting Ticket Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtStyleID, "Order Qty"))
            {
                return false;
            }

            if (!validator.isPresent(txtPlanQty, "Plan Qty"))
            {
                return false;
            }

            if (!validator.isPresent(txtBundleSize, "Bundle Size"))
            {
                return false;
            }

            return true;


        }


        #endregion


     

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
          
          SearchCuttingHeader();
          
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
           splashScreenManager1.ShowWaitForm();
          _cuttingHeader.CuttingHeaderID = gridView3.GetFocusedRowCellValue("CuttingHeaderID").ToString();
          getCuttingFeild(_cuttingHeader.CuttingHeaderID);

          GetItemToGenarete();

          GetItemGenareted();
        
          //  FeedCuttingItem(_cuttingHeader.CuttingHeaderID);
         
         // GetBundleHeaderDetails();
          grdSearch.Hide();
          txtSearchBox.Hide();
          btnClose.Hide();
          splashScreenManager1.CloseWaitForm();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            

           // GenarateTags gn = new GenarateTags();
           // Cursor.Current = Cursors.WaitCursor;
            //gn.genarateTestData();
           // Cursor.Current = Cursors.Default;
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            
       //   gen.genarateBundle(150, 20, 20);
          
            
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmBundlingMaster_Load(object sender, EventArgs e)
        {
            
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            grdQue.Hide();
            ItrackContext _context = new ItrackContext();
            _context.Database.Initialize(false);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            txtSearchBox.Focus();
            btnClose.Show();
            btnClose.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            GenaricRepository<OprationBarcodes> _OprationBarcodesRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
         var t  =  from item in _OprationBarcodesRepository.GetAll().ToList()  where item.BundleDetails.BundleHeader.CuttingItemID == 1 orderby item.OprationBarcodesID select item;
        Debug.WriteLine( t.Count());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try {
                frmBundlePrintoption _option = new frmBundlePrintoption();
                _option.ShowDialog();
                splashScreenManager1.ShowWaitForm();
                int CutNo = Convert.ToInt16(gridView1.GetFocusedRowCellValue("CuttingItemID").ToString());
                //  frmPrintBarcode print = new frmPrintBarcode(_barcode);
                frmBundlePrintoption p = new frmBundlePrintoption();
                Cursor.Current = Cursors.Default;
                p.ShowDialog();
                splashScreenManager1.CloseWaitForm();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

           
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void grdSearch_Click(object sender, EventArgs e)
        {

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



        void FeedBundleDetails(string _styleID) {

            try {
                GenaricRepository<BundleDetails> _bhRepo = new GenaricRepository<BundleDetails>(new ItrackContext());



                var print = from item in _bhRepo.GetAll().ToList() where item.BundleHeader.CuttingItem.CuttingHeader.StyleID == _styleID select new { item.BundleHeader.CuttingItem.PoNo,item.BundleHeaderID,item.BundleHeader.CuttingItem.LineNo,  item.BundleNo,item.NoOfItem,item.BundleHeader.CuttingItem.Size,item.BundleHeader.CuttingItem.NoOfLayer,item.BundleHeader.BundleTagGenaratedTime};
                grdBundleListPrinted.DataSource = print;
            }
            catch(Exception ex){

            
            }
        
        }


        bool isExistingItem(int cutId) {
            try {
                var items = (from item in lstOrder
                             where item.CuttingItemID == cutId
                             select item.CuttingItemID).ToList();

                if (items.Count > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception ex) {
                return false;
            }
        }


        bool ProcessAll() {
            try {

                
                foreach (var wo in lstOrder)
                {

                    List<OprationBarcodes> lst = new List<OprationBarcodes>();
                    GenarateTags gen = new GenarateTags();


                    GenareteTags(wo.CuttingItemID);

                    wo.BundleHeaderId= GetBundleHeaderID();
                    //genarate opration tags 
                    gen.GenrateBundleTags(wo.NoOfLayers, wo.NoofItem / wo.NoOfLayers, wo.BundleSize, wo.BundleHeaderId, wo.StyleNo, lst, txtStyleNo.Text,wo.CutNo, txtStyleID.Text);

                    //update cutting item genarated tgs status
                    UpdateBundleStatus(wo.CuttingItemID);


                    UpdateGeratedStatus(wo.CuttingItemID);
                    //Feed Cutting Items 
                    FeedCuttingItem(_cuttingHeader.CuttingHeaderID);

                    GetBundleHeaderDetails();

                    lst = lst;
                    //using sql bulk copy
                    SqlBulkCopyHelper _helper = new SqlBulkCopyHelper();

                    // Copy data set using Sql Bulk Copy helper 
                    _helper.PerformBulkCopy(_helper.ConvertTagsToDatatable(lst));

                    Debug.WriteLine(lst.Count + "Count Of Record");

                    //update Bundle Header Deta
                    // UpdateBundleStatus();
                    Cursor.Current = Cursors.Default;

                    
                }


                return true;
            }
            catch (Exception ex) {
                return false;
            }

        }



        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FeedBundleDetails(txtSNo.Text);
        }

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnQue_Click(object sender, EventArgs e)
        {
      

            if (txtBundleSize.Text != "")
            {
                FeedWorkOrder();

            }
            else
            {
                MessageBox.Show("Please Fill Bundle Size", "Error Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBundleSize.Focus();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            grdQue.DataSource = lstOrder;
            grdQue.Show();
            btnQue.Enabled = false;
        }

        private void simpleButton2_Click_3(object sender, EventArgs e)
        {
            btnQue.Enabled = true;
            grdQue.Hide();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (lstOrder.Count > 0)
            {
                splashScreenManager1.ShowWaitForm();
                UI.frmPurchaseOrder objfrmMChild = new UI.frmPurchaseOrder();
                if (ProcessAll() == true)
                {
                    grdQue.Hide();
                    MessageBox.Show("Job Complete Sucessfuly !", "Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                splashScreenManager1.CloseWaitForm();
               
               
            }
            else
            {
                MessageBox.Show("Please Fill Work Order For Complete this job", "Error Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}