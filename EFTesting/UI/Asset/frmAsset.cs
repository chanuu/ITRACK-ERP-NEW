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
using EFTesting.ViewModel;
using System.Diagnostics;
using System.Linq.Expressions;
using ITRACK.Validator;
using EFTesting.Reports.Asset;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI.Asset
{
    public partial class frmAsset : DevExpress.XtraEditors.XtraForm
    {
        public frmAsset()
        {
            InitializeComponent();
        }


        #region Diclaration

        Validator validate = new Validator();


        #endregion

        #region CUID

        GenaricRepository<AssetBarcode> _AssetBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
        AssetBarcode _AssetBarcode = new AssetBarcode();
        Company _Company = new Company();
        Int32 CustomFID = 0;


        private AssetBarcode AssingAssetBarcode()
        {
            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            _AssetBarcode.CompanyID = _Company.CompanyID;
            _AssetBarcode.Location = cmbLocationCode.Text;
            _AssetBarcode.AssetBarcodeID = txtSerialNo.Text;
            _AssetBarcode.AssetName = txtAssetName.Text;
            _AssetBarcode.Description = txtDescription.Text;
            _AssetBarcode.AlternetAsset = txtAssetNo.Text;
            _AssetBarcode.AssetStatus = cmbAssetStatus.Text;
            _AssetBarcode.WarrantyPeriod = txtWarrantyPeriod.Text;
            _AssetBarcode.PurchaseLocation = cmbPurchaseLocation.Text;
            _AssetBarcode.AssetUsedBy = txtAssetUsedBy.Text;
            _AssetBarcode.Category01 = cmbCategory01.Text;
            _AssetBarcode.Category02 = cmbCategory02.Text;
            _AssetBarcode.Category03 = cmbCategory03.Text;
            _AssetBarcode.CustomField1 = txtCustomField1.Text;
            _AssetBarcode.CustomField2 = txtCustomField2.Text;
            _AssetBarcode.CustomField3 = txtCustomField3.Text;
            _AssetBarcode.CustomField4 = txtCustomField4.Text;
            _AssetBarcode.CustomField5 = txtCustomField5.Text;
            _AssetBarcode.CustomField6 = txtCustomField6.Text;
            _AssetBarcode.PurchaseDate = txtPurchaseDate.Text;
            _AssetBarcode.PurchasePrice = txtPurchasePrice.Text;
            _AssetBarcode.SupplierName = txtSupplierName.Text;
            _AssetBarcode.DepreciationMode = txtDepreciationMode.Text;
            _AssetBarcode.CurrentValue = txtCurrentValue.Text;


            return _AssetBarcode;

        }

        private void SearchItem()
        {
            try

            {

                GenaricRepository<AssetBarcode> _AssetBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(AssetBarcode), "s");
                Expression nameProperty = Expression.Property(argParam, "AssetBarcodeID");
                Expression namespaceProperty = Expression.Property(argParam, "AlternetAsset");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<AssetBarcode, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _AssetBarcodeRepo.SearchFor(lambda1).ToList() select new { item.AssetBarcodeID, item.AlternetAsset, item.AssetName, item.AssetUsedBy, item.CustomField1, item.CustomField2, item.CustomField3, item.CustomField4 };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearch.Show();
                    btnClose.Show();

                    grdSearch.DataSource = selected;
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


        private void SearchAssetName()

        {
            try

            {

                GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(CustomeFieldSetup), "s");
                Expression nameProperty = Expression.Property(argParam, "ItemType");
                Expression namespaceProperty = Expression.Property(argParam, "CustomField1");

                var val1 = Expression.Constant(txtAssetName.Text);
                var val2 = Expression.Constant(txtAssetName.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<CustomeFieldSetup, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _CustomFieldRepo.SearchFor(lambda1).ToList() select new { item.ItemType, item.CustomeFieldSetupID };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchItemType.Show();
                    btnClose.Show();

                    grdSearchItemType.DataSource = selected;
                }
                else
                {
                    grdSearchItemType.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }

        void PrintReport()
        {
            try
            {

                rtAssetBarcode report = new rtAssetBarcode();


                GenaricRepository<AssetBarcode> _BarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
                var dataSource = from item in _BarcodeRepo.GetAll().ToList()
                                     //                 where item.Company.CompanyID == 1
                                 //where item.AlternetAsset == "VTWF-MM-0010"
                                 //where item.AssetBarcodeID.CompareTo("000003564")>=0 && item.AssetBarcodeID.CompareTo("000003583") <=0
                                 select item;

                report.DataSource = dataSource;

                ReportPrintTool preview = new ReportPrintTool(report);

                preview.ShowPreview();
            }
            catch (Exception ex)
            {

            }

        }




        private void AddFiled()
        {
            try
            {
                GenaricRepository<AssetBarcode> _AssetBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
                _AssetBarcodeRepo.Add(AssingAssetBarcode());
            }
            catch (Exception ex)
            {

            }
        }



        void getCutomField(int ID)
        {
            try
            {

                foreach (var item in getCustomeFieldSetupID(ID))
                {
                    txtAssetName.Text = item.ItemType;

                    if (item.CustomField1 != "")
                    {
                        lblCustomf1.Text = item.CustomField1;
                    }
                    else
                    {
                        lblCustomf1.Text = "Custom Field 1";
                    }


                    if (item.CustomField2 != "")
                    {
                        lblCustomf2.Text = item.CustomField2;
                    }
                    else
                    {
                        lblCustomf2.Text = "Custom Field 2";
                    }

                    if (item.CustomField3 != "")
                    {
                        lblCustomf3.Text = item.CustomField3;
                    }
                    else
                    {
                        lblCustomf3.Text = "Custom Field 3";
                    }


                    if (item.CustomField4 != "")
                    {
                        lblCustomf4.Text = item.CustomField4;
                    }
                    else
                    {
                        lblCustomf4.Text = "Custom Field 4";
                    }


                    if (item.CustomField5 != "")
                    {
                        lblCustomf5.Text = item.CustomField5;
                    }
                    else
                    {
                        lblCustomf5.Text = "Custom Field 5";
                    }


                    if (item.CustomField6 != "")
                    {
                        lblCustomf6.Text = item.CustomField6;
                    }
                    else
                    {
                        lblCustomf6.Text = "Custom Field 6";
                    }

                    grdSearchItemType.Hide();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<CustomeFieldSetup> getCustomeFieldSetupID(int ID)
        {
            try
            {
                return _CustomFieldRepo.GetAll().Where(u => u.CustomeFieldSetupID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private List<AssetBarcode> GetAssetByID(string ID)
        {
            try
            {
                return _AssetBarcodeRepo.GetAll().Where(u => u.AssetBarcodeID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        void getAssetBarcode(string ID)
        {
            try
            {
                foreach (var item in GetAssetByID(ID))
                {
                    txtSerialNo.Text = item.AssetBarcodeID;
                    txtAssetNo.Text = item.AlternetAsset;
                    txtAssetName.Text = item.AssetName;
                    getCutomField(item.CustomFieldSetup.CustomeFieldSetupID);
                    cmbAssetStatus.Text = item.AssetStatus;
                    txtDescription.Text = item.Description;
                    txtWarrantyPeriod.Text = item.WarrantyPeriod;
                    cmbPurchaseLocation.Text = item.PurchaseLocation;
                    cmbLocationCode.Text = item.Location;
                    txtAssetUsedBy.Text = item.AssetUsedBy;
                    cmbCategory01.Text = item.Category01;
                    cmbCategory02.Text = item.Category02;
                    cmbCategory03.Text = item.Category03;
                    if (item.CustomFieldSetup.CustomField1 != "None")
                    {
                        lblCustomf1.Text = item.CustomFieldSetup.CustomField1;
                        txtCustomField1.Text = item.CustomField1;
                    }

                    if (item.CustomFieldSetup.CustomField2 != "None")
                    {
                        lblCustomf2.Text = item.CustomFieldSetup.CustomField2;
                        txtCustomField2.Text = item.CustomField2;
                    }

                    if (item.CustomFieldSetup.CustomField3 != "None")
                    {
                        lblCustomf3.Text = item.CustomFieldSetup.CustomField3;
                        txtCustomField3.Text = item.CustomField3;
                    }

                    if (item.CustomFieldSetup.CustomField4 != "None")
                    {
                        lblCustomf4.Text = item.CustomFieldSetup.CustomField4;
                        txtCustomField4.Text = item.CustomField4;
                    }

                    if (item.CustomFieldSetup.CustomField5 != "None")
                    {
                        lblCustomf5.Text = item.CustomFieldSetup.CustomField5;
                        txtCustomField5.Text = item.CustomField5;
                    }

                    if (item.CustomFieldSetup.CustomField6 != "None")
                    {
                        lblCustomf6.Text = item.CustomFieldSetup.CustomField6;
                        txtCustomField6.Text = item.CustomField6;
                    }

                    txtPurchaseDate.Text = item.PurchaseDate;
                    txtPurchasePrice.Text = item.PurchasePrice;
                    txtSupplierName.Text = item.SupplierName;
                    txtDepreciationMode.Text = item.DepreciationMode;
                    txtCurrentValue.Text = item.CurrentValue;



                    grdSearch.Hide();
                    grdSearchItemType.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int getAssetCount()
        {
            try
            {
                GenaricRepository<AssetBarcode> _AssetBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
                return Convert.ToInt16(_AssetBarcodeRepo.GetAll().ToList().Last().AssetBarcodeID);
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "ASS"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtSerialNo.Text = _Engine.GenarateNo(_No, getAssetCount()+1);


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        #endregion





        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAssetNo.Text = "";
            txtAssetName.Text = "";
            cmbAssetStatus.Text = "";
            txtDescription.Text = "";
            txtWarrantyPeriod.Text = "";
            cmbPurchaseLocation.Text = "";
            cmbLocationCode.Text = "";
            txtAssetUsedBy.Text = "";
            cmbCategory01.Text = "";
            cmbCategory02.Text = "";
            cmbCategory03.Text = "";
            txtCustomField1.Text = "";
            txtCustomField2.Text = "";
            txtCustomField3.Text = "";
            txtCustomField4.Text = "";
            txtCustomField5.Text = "";
            txtCustomField6.Text = "";
            txtPurchaseDate.Text = "";
            txtPurchasePrice.Text = "";
            txtSupplierName.Text = "";
            txtDepreciationMode.Text = "";
            txtCurrentValue.Text = "";
            GetNewCode();
            grdSearchItemType.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFiled();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _AssetBarcode.AssetBarcodeID = gridView1.GetFocusedRowCellValue("AssetBarcodeID").ToString();
                getAssetBarcode(_AssetBarcode.AssetBarcodeID);
            }
        }

        private void txtAssetName_EditValueChanged(object sender, EventArgs e)
        {
            SearchAssetName();
        }

        private void txtAssetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchItemType.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchItemType.Hide();
            }
        }

        private void grdSearchItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                _AssetBarcode.CustomeFieldSetupID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("CustomeFieldSetupID").ToString());
                CustomFID = _AssetBarcode.CustomeFieldSetupID;
                getCutomField(Convert.ToInt16(_AssetBarcode.CustomeFieldSetupID));
            }
        }

        private void frmAsset_Load(object sender, EventArgs e)
        {
            grdSearchItemType.Hide();
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PrintReport();
        }
    }
}