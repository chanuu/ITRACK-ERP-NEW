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
    public partial class frmMachineType : DevExpress.XtraEditors.XtraForm
    {
        public frmMachineType()
        {
            InitializeComponent();
        }


        MachineType _Machine = new MachineType();
        ItrackContext _context = new ItrackContext();


        string GetGroupID() {
            try {
                return (from item in _context.Group select item.GroupID).ToList().Last();
            }
            catch (Exception ex) {
                return null;
            }
           
        }
        
        string GetMachineTypeID() {

            try {
               string _code =  (from item in _context.MachineType select item.MachineTypeID).ToList().Last();

                _code = (Convert.ToInt16(_code) + 1).ToString().PadLeft(5,'0');
                return _code;
            }
            catch (Exception ex) {

                return "00001";
            }

        }



        MachineType AssignMachine() {

            _Machine.GroupID = GetGroupID();
            _Machine.MachineTypeName = txtMachineType.Text;
            _Machine.MachineTypeID = GetMachineTypeID();
            _Machine.Remark = txtRemark.Text;


            return _Machine;

        }

        MachineType AssignMachineEdit()
        {

            _Machine.GroupID = GetGroupID();
            _Machine.MachineTypeName = txtMachineType.Text;
            _Machine.MachineTypeID =ID;
            _Machine.Remark = txtRemark.Text;


            return _Machine;

        }


        private void AddType()
        {
            try
            {
                GenaricRepository<MachineType> _MachineTypeRepository = new GenaricRepository<MachineType>(new ItrackContext());
                _MachineTypeRepository.Add(AssignMachine());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateType()
        {
            try
            {
                GenaricRepository<MachineType> _MachineTypeRepository = new GenaricRepository<MachineType>(new ItrackContext());
                
                _MachineTypeRepository.Edit(AssignMachineEdit());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddType();
        }



        void search(string _key) {


            try {
              var items = (from item in _context.MachineType
                             where item.MachineTypeName.Contains(_key)

                             select new { item.MachineTypeID,item.MachineTypeName,item.Remark}).ToList();

                if (items.Count() > 0)
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


        MachineType GetMachineTypeByID(string _ID) {

            return (from item in _context.MachineType

                    where item.MachineTypeID == _ID
                    select item).ToList().Last();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            search(txtSearchBox.Text);
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
        MachineType type = new MachineType();
        string ID = "";
        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
             ID = gridView1.GetFocusedRowCellValue("MachineTypeID").ToString();
            
            type = GetMachineTypeByID(ID);
            txtMachineType.Text = type.MachineTypeName;
            txtRemark.Text = type.Remark;
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void frmMachineType_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMachineType.Text = "";
            txtRemark.Text = "";

            txtMachineType.Focus();
        }
    }
}