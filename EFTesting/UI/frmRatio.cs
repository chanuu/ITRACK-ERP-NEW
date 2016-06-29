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
using DevExpress.XtraEditors.Controls;
using EFTesting.ViewModel;
using System.Diagnostics;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmRatio : DevExpress.XtraEditors.XtraForm
    {
        public frmRatio()
        {
            InitializeComponent();
        }


        List<RatioItem> lstRatio = new List<RatioItem>();
        RatioItem _item = new RatioItem();


        GenaricRepository<CuttingRatio> _CuttingRatioRepo = new GenaricRepository<CuttingRatio>(new ItrackContext());
        CuttingRatio _ratio = new CuttingRatio();

        RatioItem _Ratioitem = new RatioItem();

        GenaricRepository<RatioItem> _CuttingRatioItemRepo = new GenaricRepository<RatioItem>(new ItrackContext());


        int getPoCount()
        {
            try
            {
                GenaricRepository<CuttingRatio> _CuttingRatioRepo = new GenaricRepository<CuttingRatio>(new ItrackContext());
                return _CuttingRatioRepo.GetAll().ToList().Count+1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }


        int getItemCount()
        {
            try
            {
                GenaricRepository<RatioItem> _CuttingRatioRepo = new GenaricRepository<RatioItem>(new ItrackContext());
                return _CuttingRatioRepo.GetAll().ToList().Count + 1;
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
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "RTO"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtRatioNo.Text = _Engine.GenarateNo(_No, getPoCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }



        bool isAvailble(string _id)
        {
            try {
                bool stat = false;
                ItrackContext _context = new ItrackContext();
                var items = from item in _context.CuttingRatio
                            where item.CuttingRatioID == _id
                            select item;

                if (items.Count() > 0)
                {
                    stat = true;
                }
                else
                {
                    stat = false;
                }

                return stat;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        bool isAvailbleItems(string _size,string _id)
        {
            try
            {
                bool stat = false;
                ItrackContext _context = new ItrackContext();
                var items = from item in _context.RatioItem
                            where item.Size == _size && item.CuttingRatioID== _id
                            select item;

                if (items.Count() > 0)
                {
                    stat = true;
                }
                else
                {
                    stat = false;
                }

                return stat;
            }
            catch (Exception ex)
            {
                return false;
            }
        }





        bool AddRatioHeader()
        {
            try {
                _ratio.CuttingRatioID = txtRatioNo.Text;
                _ratio.Color = txtColor.Text;
                _ratio.Length = txtLength.Text;
                _ratio.MarkerWidth = Convert.ToDouble(txtMWidth.Text);
                _ratio.MarkerLength = Convert.ToDouble(txtMLength.Text);
                _ratio.Remark = txtRemark.Text;
                _ratio.StyleID = txtStyleNo.Text;
                _CuttingRatioRepo.Insert(_ratio);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        void RatioItem()
        {
            try {
                foreach(var _ratio in lstRatio)
                {
                    _ratio.CuttingRatioID = txtRatioNo.Text;
                    _ratio.RatioItemID = getItemCount();

                 if(   isAvailbleItems(_ratio.Size,_ratio.CuttingRatioID)==true){

                    }
                    else
                    {
                        _CuttingRatioItemRepo.Insert(_ratio);
                      
                    }
                   
                }
            }
            catch (Exception ex)
            {

            }
        }


        void RefreshList()
        {
            var items = from item in lstRatio
                        select new { item.RatioItemID, item.Size, item.Lot };
            grdRatio.DataSource = null;
            if (items.Count() > 0)
            {
                grdRatio.DataSource = items;
            }
            else
            {
                grdRatio.DataSource = lstRatio;
            }
           
        }
        private void frmRatio_Load(object sender, EventArgs e)
        {

            ItrackContext _context = new ItrackContext();
            _context.Database.Initialize(false);
            RefreshList();
            gridView1.Columns["CuttingRatio"].Visible = false;
            gridView1.Columns["CuttingRatioID"].Visible = false;
            GetNewCode();
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();


        }



        void LoadSizes(string _styleNo)
        {

            try {
                ItrackContext _context = new ItrackContext();

                var sizes = (from size in _context.PurchaseOrderItems
                             where size.PurchaseOrderHeader.StyleID == _styleNo

                             select size).ToList();
                ComboBoxItemCollection coll = cmbSize.Properties.Items;


                foreach(var item in sizes.Distinct())
                {
                    coll.Add(item.Size);
                }
            }
            catch (Exception ex)
            {

            }
        }


        void AddItems()
        {

            try
            {
                RatioItem _item = new RatioItem();
                _item.Size = cmbSize.Text;
                _item.Lot =Convert.ToInt16( txtLot.Text);
                _item.RatioItemID = lstRatio.Count + 1;
                lstRatio.Add(_item);
                RefreshList();
            }
            catch (Exception ex)
            {

            }
        }


        void Search(string _key)
        {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.CuttingRatio
                            where item.StyleID.Contains(_key)
                            select new { item.CuttingRatioID, item.StyleID,item.Remark}).ToList();

                if (items.Count > 0)
                {
                    grdSearch.Show();
                    grdSearch.DataSource = items;
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


        void GetHeader(string _ID)
        {
            try {
                ItrackContext _context = new ItrackContext();
                var result = (from item in _context.CuttingRatio
                             where item.CuttingRatioID == _ID
                             select item).ToList().Last();

                txtRatioNo.Text = result.CuttingRatioID;

                txtRemark.Text = result.Remark;

                txtStyleNo.Text = result.StyleID;

                LoadSizes(result.StyleID);

                txtColor.Text = result.Color;

                txtMLength.Text =Convert.ToString( result.MarkerLength);

                txtMWidth.Text = Convert.ToString(result.MarkerWidth);

                txtLength.Text = result.Length;




            }
            catch (Exception ex)
            {

            }
        }


       void SetItem(string _id)
        {
            try {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.RatioItem

                             where item.CuttingRatioID == _id

                             select item).ToList();
                lstRatio.Clear();
                foreach(var ratio in items)
                {
                    lstRatio.Add(ratio);
                }

                var selected = (from r in lstRatio
                                select new { r.RatioItemID, r.Size, r.Lot }).ToList();

                grdRatio.DataSource = selected;


            }
            catch (Exception ex)
            {

            }
        }

        void Save()
        {

        if(isValidratio() == true)
            {

                if (isAvailble(txtRatioNo.Text) == true)
                {
                    RatioItem();
                    MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddRatioHeader();
                    RatioItem();
                    MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

         
           
        }
        private void txtTableCut_Leave(object sender, EventArgs e)
        {
            LoadSizes(txtStyleNo.Text);
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }


        Validator validate = new Validator();
        public bool isValidratio()
        {
            if (!validate.isPresent(txtRatioNo, "Ratio No"))
            {
                return false;
            }

            if (!validate.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtColor, "Color"))
            {
                return false;
            }

            if (!validate.isPresent(txtLength, "Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtMWidth, "Marker Width"))
            {
                return false;
            }

            if (!validate.isPresent(txtMLength, "Marker Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtRemark, "Remark"))
            {
                return false;
            }

            return true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            txtColor.Text = "";
            txtRatioNo.Text = "";
            txtStyleNo.Text = "";
            txtMLength.Text = "";
            txtMWidth.Text = "";
            txtRemark.Text = "";
            lstRatio.Clear();
            grdRatio.DataSource = "";
            txtRatioNo.Focus();
            GetNewCode();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            Search(txtSearchBox.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
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
                txtSearchBox.Hide();
                btnClose.Hide();

            }
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string No = gridView2.GetFocusedRowCellValue("CuttingRatioID").ToString();
                GetHeader(No);
                SetItem(No);
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();
               
            }
        }
    }
}