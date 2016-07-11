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
using DevExpress.XtraScheduler;
using EFTesting.DTOs;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using EFTesting.UI.User_Accounts;

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

        List<StyleLoadingDto> list = new List<StyleLoadingDto>();

        void LoadAppoiment() {
            try {



                ItrackContext _context = new ItrackContext();

                var styles =( from style in _context.StyleLoading
                             where style.Style.Status == "Pending"
                             select style).ToList();

                foreach(var style in styles)
                {

                    StyleLoadingDto loading = new StyleLoadingDto();
                    loading.StartDate =  style.StartDate;
                    loading.EndDate = style.EndDate;
                    loading.StyleNo = style.StyleID;
                    loading.LineNo = style.LineNo;
                    loading.Description =style.StyleID +" Loading";
                    loading.Complete = 0;

                    //   loading.Label = 
                    int i = 0;
                    foreach (var l in schedulerStorage2.Appointments.Labels)
                    {
                        if (l.DisplayName == loading.LineNo)
                        {

                            loading.ColorLabel = i;

                        }
                        i++;

                    }

                    
                    list.Add(loading);

                }

               

                bindingSource1.DataSource = list;
                schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;
                schedulerControl1.GroupType = SchedulerGroupType.Resource;
                schedulerControl1.GanttView.ShowResourceHeaders = true;
                schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = true;
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


        void FeedConmbo()
        {
            try
            {

                ComboBoxItemCollection coll = cmbLine.Properties.Items;

                ItrackContext _context = new ItrackContext();
                GenaricRepository<Department> _PoRepo = new GenaricRepository<Department>(new ItrackContext());

                var items = (from item in _context.Department
                             where item.CompanyID == _Company.CompanyID
                             select item).ToList();
                foreach (var item in items.Distinct())
                {
                    coll.Add(item.Name);

                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void frmStyleLoading_Load(object sender, EventArgs e)
        {
            GetStyleLoading();
            LoadAppoiment();

            grdStyleSearch.Hide();
            GetDefualtCompany();
            FeedConmbo();
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

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            EFTesting.UI.Asset.CustomAppointmentForm form = new EFTesting.UI.Asset.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }





        void serachStyle(string _key) {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.Style
                             where item.StyleID.Contains(_key)
                             select new { item.StyleID, item.Buyer.BuyerName, item.Remark }).ToList();

                grdStyleSearch.Show();

                if (items.Count > 0)
                {
                    grdStyleSearch.DataSource = items;
                }
                else
                {
                    grdStyleSearch.DataSource = null;
                }
            }
            catch (Exception ex) {

            }

        }

        private void txtStyles_EditValueChanged(object sender, EventArgs e)
        {
            serachStyle(txtStyles.Text);
        }

        private void txtStyles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdStyleSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdStyleSearch.Hide();

            }
        }

        private void grdStyleSearch_KeyDown(object sender, KeyEventArgs e)
        {
          txtStyles.Text = gridView1.GetFocusedRowCellValue("StyleID").ToString();
          grdStyleSearch.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}