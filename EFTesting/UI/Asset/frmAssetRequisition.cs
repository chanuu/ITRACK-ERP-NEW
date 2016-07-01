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
using EFTesting.ViewModel;
using System.Diagnostics;
using System.Linq.Expressions;

namespace EFTesting.UI.Asset
{
    public partial class frmAssetRequisition : DevExpress.XtraEditors.XtraForm
    {
        public frmAssetRequisition()
        {
            InitializeComponent();
        }


        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region CUID
        GenaricRepository<AssetRequisition> _AssetRequisitionRepo = new GenaricRepository<AssetRequisition>(new ItrackContext());
        GenaricRepository<AssetBarcode> _AssetBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
        AssetRequisition _AssetRequision = new AssetRequisition();
        AssetBarcode AssetBarcode = new AssetBarcode();
        List<AssetRequisitionDetails> lstAssetRequisitionDetails = new List<AssetRequisitionDetails>();

        private AssetRequisition AssingAssetRequisition()
        {
            _AssetRequision.AssetRequisitionID = txtRequisitionNo.Text;
            _AssetRequision.CompanyCode = cmbCompanyCode.Text;
            _AssetRequision.LocationCode = cmbLocationCode.Text;
            _AssetRequision.DocumentDate = txtDocumentDate.DateTime;
            _AssetRequision.DocumentType = cmbDocumentType.Text;
            _AssetRequision.TargetLocationCode = cmbTargetLocationCode.Text;

            return _AssetRequision;


        }


        private void AddField()
        {
            try
            {
                GenaricRepository<AssetRequisition> _AssetRequisitionRepo = new GenaricRepository<AssetRequisition>(new ItrackContext());
                _AssetRequisitionRepo.Add(AssingAssetRequisition());
            }

            catch (Exception ex)
            {

            }

        }

        private void AddAssetRequisitionDetails()
        {
            try
            {
                GenaricRepository<AssetRequisitionDetails> _AssetRequisitionDetailsRepo = new GenaricRepository<AssetRequisitionDetails>(new ItrackContext());
                AssetRequisitionDetails _AssetRequisitionDetails = new AssetRequisitionDetails();

                foreach (var item in lstAssetRequisitionDetails)
                {
                    _AssetRequisitionDetails.AssetNo = txtAssetNo.Text;
                    _AssetRequisitionDetails.FromDate = txtFromDate.DateTime;
                    _AssetRequisitionDetails.ToDate = txtToDate.DateTime;
                    _AssetRequisitionDetailsRepo.Add(_AssetRequisitionDetails);
                }

            }
            catch (Exception ex)
            {

            }


        }

        int getAssetReqCount()
        {
            try
            {
                GenaricRepository<AssetRequisition> _AssetRequisitionRepo = new GenaricRepository<AssetRequisition>(new ItrackContext());
                return _AssetRequisitionRepo.GetAll().ToList().Count;
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "ASSREQ"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtRequisitionNo.Text = _Engine.GenarateNo(_No, getAssetReqCount());


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
                GenaricRepository<AssetRequisition> _AssetRequisitionRepo = new GenaricRepository<AssetRequisition>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(AssetRequisition), "s");
                Expression nameProperty = Expression.Property(argParam, "AssetRequisitionID");
                Expression namespaceProperty = Expression.Property(argParam, "DocumentDate");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<AssetRequisition, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _AssetRequisitionRepo.SearchFor(lambda1).ToList() select new { item.AssetRequisitionID, item.DocumentDate, item.CompanyCode, item.LocationCode, item.DocumentType, item.TargetLocationCode};

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


        void getAssetRequisition(string ID)
        {
            try
            {
                foreach (var item in getAssetRequisitionID(ID))
                {
                    txtAssetNo.Text = item.AssetRequisitionID;
                    cmbCompanyCode.Text = item.CompanyCode;
                    cmbLocationCode.Text = item.LocationCode;
                    txtDocumentDate.DateTime = item.DocumentDate;
                    cmbDocumentType.Text = item.DocumentType;
                    cmbTargetLocationCode.Text = item.TargetLocationCode;

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

        private List<AssetRequisition> getAssetRequisitionID (string ID)
        {
            try
            {
                return _AssetRequisitionRepo.GetAll().Where(u => u.AssetRequisitionID == ID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        #endregion


        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddField();
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void grdSearchReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _AssetRequision.AssetRequisitionID = gridView2.GetFocusedRowCellValue("AssetRequisitionID").ToString();
                getAssetRequisition(_AssetRequision.AssetRequisitionID);
               
            }
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

        private void frmAssetRequisition_Load(object sender, EventArgs e)
        {
            grdSearchReq.Hide();
        }

        private void grdSearchReq_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}