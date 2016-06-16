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
    public partial class frmStyleLoading : DevExpress.XtraEditors.XtraForm
    {
        public frmStyleLoading()
        {
            InitializeComponent();
        }
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        StyleLoading _style = new StyleLoading();
        StyleLoading Assign() {
            try
            {
               

                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _style.LocationCode = item.LocationCode;

                }

                _style.LineNo = cmbLine.Text;
                _style.StyleLoadingID = 99;
               
               
                _style.StyleID = txtStyles.Text;
                _style.StartDate =Convert.ToDateTime( txtFrom.Text);
                _style.EndDate =Convert.ToDateTime( txtTo.Text);
           
                _style.StyleLoadingID = 55;

                GenaricRepository<StyleLoading> _repo = new GenaricRepository<StyleLoading>(new ItrackContext());
                _repo.Add(_style);
                return _style;
            }
            catch (Exception ex) {
                return null;
            }
        }

        void UpdateLaoding() {
            try {
                GenaricRepository<StyleLoading> _repo = new GenaricRepository<StyleLoading>(new ItrackContext());
                StyleLoading _load = new StyleLoading();
                _load.StyleLoadingID = _loadingID;
                _load.EndDate = Convert.ToDateTime(txtTo.Text);
                _load.StartDate = Convert.ToDateTime(txtFrom.Text);
                _load.LineNo = cmbLine.Text;
                _load.StyleID = txtStyles.Text;
              if(_repo.Update(_load) == true)
                {
                    MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {

            }
        }
        int _loadingID = 0;
        void GetLoadingByID(int ID) {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.StyleLoading
                             where item.StyleLoadingID == ID
                             select item).ToList().Last();
                _loadingID = items.StyleLoadingID;

                cmbLine.Text = items.LineNo;

                txtStyles.Text = items.StyleID;

                txtFrom.Text =Convert.ToString( items.StartDate);

                txtTo.Text = Convert.ToString(items.EndDate);

                




            }
            catch (Exception ex) {
            }

        }

        void GetStyleLoading() {
            try {
                ItrackContext _context = new ItrackContext();
                var items =( from item in _context.StyleLoading
                            where item.Style.Status == "Pending"

                            select new {item.StyleLoadingID, item.LineNo, item.StyleID, item.StartDate, item.EndDate }).ToList();
                grdStyleLoading.DataSource = items;

            }
            catch (Exception ex) {

            }

        }



        void addLoading() {
            try {

                Assign();
              

            }
            catch (Exception ex) {

            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            addLoading();
            GetStyleLoading();
        }

        private void frmStyleLoading_Load(object sender, EventArgs e)
        {
            GetStyleLoading();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (btnUpdate.Text == "Edit")
            {
                btnUpdate.Text = "Update";
                int ID = Convert.ToInt16(gridView3.GetFocusedRowCellValue("StyleLoadingID").ToString());
                GetLoadingByID(ID);
            }
            else
            {
                btnUpdate.Text = "Edit";
                UpdateLaoding();
            }
            
            
        }
    }
}