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

namespace EFTesting.UI.Asset
{
    public partial class frmRentManagement : DevExpress.XtraEditors.XtraForm
    {
        public frmRentManagement()
        {
            InitializeComponent();
        }

        RentManagement rManagement = new RentManagement();

        RentManagement Assign() {

            try {
                rManagement.RentManagementID = txtRentID.Text;

                rManagement.MachineType = cmbMachineType.Text;

                rManagement.MachineSerialNo = txtSerialNo.Text;

                rManagement.FromDate =Convert.ToDateTime( txtFrom.Text);

                rManagement.ToDate =Convert.ToDateTime( txtToDate.Text);

                rManagement.AssetBarcode = txtBarcode.Text;

                rManagement.Remark = txtRemark.Text;

                return rManagement;
            }
            catch (Exception ex) {
                return null;
            }
        }


        private void AddFiled()
        {
            try
            {
                GenaricRepository<RentManagement> _AssetBarcodeRepo = new GenaricRepository<RentManagement>(new ItrackContext());

              if(IsAvail(txtBarcode.Text) == false)
                {
                    _AssetBarcodeRepo.Add(Assign());
                }
                else
                {
                    DialogResult r = MessageBox.Show("This ID Previuosly Assign to Another Machine.Are you sure you want to continue ?", "", MessageBoxButtons.YesNo);
                    if(r == DialogResult.Yes)
                    {

                        UpdateAsset(txtBarcode.Text);
                        _AssetBarcodeRepo.Add(Assign());
                      

                    }
                }
                
            }
            catch (Exception ex)
            {

            }
        }


        string GetRentIDByBarcode(string ID) {

            ItrackContext _cntx = new ItrackContext();
            var rows = (from item in _cntx.RentManagement
                        where item.AssetBarcode == ID

                        select item).ToList().Last();
            return rows.RentManagementID;


        }



        void Search(string _key) {
            try {

               ItrackContext _cntx = new ItrackContext();
                var items = (from item in _cntx.RentManagement

                             where item.RentManagementID.Contains(_key)

                             select new { item.RentManagementID, item.MachineType, item.MachineSerialNo }).ToList();

                if(items.Count> 0)
                {
                    grdSearch.Show();
                    grdSearch.DataSource = items;
                }
                else
                {
                    grdSearch.DataSource = null;
                }
            }
            catch (Exception ex) {

            }
        }


        private void UpdateAsset(string _RentID)
            
        {
            try
            {

              string _id =    GetRentIDByBarcode(_RentID);
                ItrackContext context = new ItrackContext();
                string _Query = "Update RentManagements set AssetBarcode = 'N/A' where RentManagementID ='"+ _id + "' '";
                context.Database.ExecuteSqlCommand(_Query);
            }
            catch (Exception ex)
            {

            }


        }

        private bool IsAvail(string ID) {
            try {
                ItrackContext context = new ItrackContext();
                var data = (from item in context.RentManagement
                            where item.AssetBarcode == ID
                            select item).ToList();

                bool flag = false;
                if (data.Count > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                return flag;
            }
            catch (Exception ex) {
                return false;
            }
        }


        void GetByID(string ID) {
            try {
                ItrackContext _cntx = new ItrackContext();
                var rows = (from item in _cntx.RentManagement
                            where item.RentManagementID == ID
                            select item).ToList();

                txtRentID.Text =    rows.Last().RentManagementID;
                cmbMachineType.Text = rows.Last().MachineType;
                txtSerialNo.Text = rows.Last().MachineSerialNo;
                txtBarcode.Text = rows.Last().AssetBarcode;
                txtFrom.Text =Convert.ToString( rows.Last().FromDate);
                txtToDate.Text = Convert.ToString(rows.Last().ToDate);
                txtRemark.Text = rows.Last().Remark;
            }
            catch (Exception ex) {

            }

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFiled();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            Search(txtSearchBox.Text);
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

        string ID = "";
        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ID = gridView1.GetFocusedRowCellValue("RentManagementID").ToString();
                GetByID(ID);
                grdSearch.Hide();
                
            }
        }

        private void frmRentManagement_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }
    }
}