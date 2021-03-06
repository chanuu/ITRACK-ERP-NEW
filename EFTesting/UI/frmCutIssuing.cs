﻿using System;
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
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using EFTesting.ViewModel;
using System.Diagnostics;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmCutIssuing : DevExpress.XtraEditors.XtraForm
    {
        public frmCutIssuing()
        {
            InitializeComponent();
        }


        List<CutIssuItem> lstItems = new List<CutIssuItem>();
        ItrackContext _context = new ItrackContext();

        bool AddIssueHeader() {
            try {

                CutIssueHeader _header = new CutIssueHeader();
                _header.StyleNo = txtStyleNo.Text;
                _header.Date = DateTime.Now;
                _header.LineNo = cmbLineNo.Text;
                _header.Type = cmbType.Text;
                _header.CutIssueHeaderID = txtIssuNoteNo.Text;
                _header.InputRequestedBy = txtInputRequestedBy.Text;
                _header.Remark = txtremark.Text;
                GenaricRepository<CutIssueHeader> _Repo = new GenaricRepository<CutIssueHeader>(new ItrackContext());
                if (_Repo.Insert(_header) == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }
                   



            }
            catch (Exception ex) {
                return false;
            }
        }



        void FeedLedger()
        {
            try {
                var stock = (from item in lstItems

                            group item by new { item.PONo, item.Size, item.Color } into G
                            select new {   G.Key.PONo, G.Key.Color,G.Key.Size, Pcs = G.Sum(a => a.NoOfItem) }).ToList();


                CutIssuItem _issue = new CutIssuItem();

                foreach(var item in stock)
                {
                   
                    _issue.PONo = item.PONo;
                  
                    _issue.Color = item.Color;
                    _issue.Size = item.Size;
                    _issue.NoOfItem = item.Pcs;

                    Populate(_issue);
                }

            }
            catch (Exception ex) {

            }

        }

        bool AddIssueItem() {
            try {
                bool flag = false;
                foreach(var item in lstItems)
                {
                    GenaricRepository<CutIssuItem> _Repo = new GenaricRepository<CutIssuItem>(new ItrackContext());
                    if (_Repo.Insert(item) == true)

                        flag = true;

                    else
                        flag= false;

                    UpdateLineNo(item.CutID, cmbLineNo.Text);
                    UpdateCutStatus(item.CutID);

                }
                return flag;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        Validator Validator = new Validator();

        public bool isValidIssueNote()
        {


            if (!Validator.isPresent(txtIssuNoteNo, "IssueNote No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtStyleNo, "Style No"))
            {
                return false;
            }

           

            if (!Validator.isPresent(cmbType, "Type"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbLineNo, "Line No"))
            {
                return false;
            }
          

            return true;
        }


        void SearchStyle(string _key)
        {

           
            var styles = (from item in _context.Style
                         where item.StyleID.Contains( _key) || item.Buyer.BuyerName.Contains( _key)
                         select new { item.StyleID, item.Buyer.BuyerName, item.GarmantType }).ToList();
            grdSearchStyle.Show();
            grdSearchStyle.DataSource = styles;


        }


        void GetCutByID()
        {
            try {
                ItrackContext _context = new ItrackContext();
               

                string _cutNo = Convert.ToString(txtCutNo.Text);

                var cut = (from item in _context.CuttingItem
                           where item.CuttingHeader.StyleID == txtStyleNo.Text && item.CutNo == _cutNo
                           select item).ToList();

                foreach(var row in cut)
                {

                    CutIssuItem _cutItem = new CutIssuItem();
                    _cutItem.CutNo = Convert.ToString(row.CutNo);
                    _cutItem.CutID = row.CuttingItemID;
                    _cutItem.PONo = row.PoNo;
                    _cutItem.LotNo = Convert.ToInt16(row.LotNo);
                    _cutItem.Color = row.Color;
                    _cutItem.Size = row.Size;
                    _cutItem.NoOfItem = row.NoOfItem;
                    _cutItem.From = 1;
                    _cutItem.To = 1;
                    _cutItem.CutIssueHeaderID = txtIssuNoteNo.Text;

                    lstItems.Add(_cutItem);
                   

                }


                var i = from item in lstItems
                        select new { item.CutNo,item.PONo,item.Color,item.Size,item.From,item.To,item.NoOfItem};

                grdItemList.DataSource = i;
               

               


            }
            catch (Exception ex) {

            }
        }




        void SearchIssu(string _key) {
            try {

                ItrackContext context = new ItrackContext();

                var search = (from item in context.CutIssueHeader
                              where item.CutIssueHeaderID.Contains(_key) 
                              select new { item.StyleNo, item.CutIssueHeaderID, item.LineNo, item.Remark }).ToList();

                grdCutIssue.DataSource = search;
                grdCutIssue.Show();
                

            }
            catch (Exception ex) {

            }
        }


        void GetIssueByItem(string _key)
        {
            try {
                ItrackContext _context = new ItrackContext();
                var selected = (from item in _context.CutIssuItem
                                where item.CutIssueHeaderID == _key
                                select item).ToList();

                txtIssuNoteNo.Text = selected.Last().CutIssueHeaderID;
                txtremark.Text = selected.Last().CutIssueHeader.Remark;
                txtStyleNo.Text = selected.Last().CutIssueHeader.StyleNo;
                cmbLineNo.Text = selected.Last().CutIssueHeader.LineNo;
                txtInputRequestedBy.Text = selected.Last().CutIssueHeader.InputRequestedBy;
                cmbType.Text = selected.Last().CutIssueHeader.Type;

                var flist = (from i in selected
                             select new { i.CutNo, i.PONo, i.LotNo, i.Color, i.Size, i.From, i.To, i.NoOfItem }).ToList();


                grdItemList.DataSource = flist;


              



            }
            catch (Exception ex) {
            }

        }

        void addHeader()
        {
            try
            {
                GenaricRepository<CuttingLedgerHeader> _CuttingRepository = new GenaricRepository<CuttingLedgerHeader>(new ItrackContext());
                CuttingLedgerHeader _header = new CuttingLedgerHeader();

                GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _header.CompanyID = item.CompanyID;

                }
                _header.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

                _header.CreatedDate = DateTime.Now;
                _header.CreatedBy = "Admin";
                _header.Remark = "Cutting status of " + DateTime.Now.Date;

                _CuttingRepository.Insert(_header);
            }
            catch (Exception ex)
            {

            }
        }

        bool ifStatusExist(string Id)
        {


            try
            {

                ItrackContext context = new ItrackContext();
                var item = from items in context.CuttingLedgerHeader
                           where items.CuttingLedgerHeaderID == Id

                           select items;

                if (item.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { 
                return false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (isValidIssueNote() == true)
            {
                if (AddIssueHeader() == true && AddIssueItem() == true)
                {

                    FeedLedger();

                    MessageBox.Show("Save Sucessfuly !", "Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }




        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            SearchStyle(txtStyleNo.Text);
        }

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            txtStyleNo.Text = gridView2.GetFocusedRowCellValue("StyleID").ToString();
            grdSearchStyle.Hide();
        }

        private void frmCutIssuing_Load(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            grdCutIssue.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            _context.Database.Initialize(false);
            GetNewCode();
            
        }

        private void txtStyleNo_KeyDown(object sender, KeyEventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GetCutByID();
        }

        private void txtCutNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCutByID();
            }
           
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchIssu(txtSearchBox.Text);
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdCutIssue.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdCutIssue.Hide();

            }
        }

        string _issuNoteNo = "";
        private void grdCutIssue_KeyDown(object sender, KeyEventArgs e)
        {
            _issuNoteNo = gridView3.GetFocusedRowCellValue("CutIssueHeaderID").ToString();
            GetIssueByItem(_issuNoteNo);
            grdCutIssue.Hide();
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdCutIssue.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }















        void Populate(CutIssuItem _Item)
        {
            //try
            //{


            //    CuttingLedger ledger = new CuttingLedger();
            //    CuttingStock _stock = new CuttingStock();
                


            //    ledger.Date = Convert.ToDateTime(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            //    _stock.Date = ledger.Date;

            //    ledger.TransactionID = GetTransactionID();
            //    ledger.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            //    ledger.StyleNo = txtStyleNo.Text;
            //    ledger.Po = _Item.PONo;
            //    ledger.LineNo = cmbLineNo.Text;
            //    ledger.Size = _Item.Size;
            //    ledger.Color = _Item.Color;
            //    ledger.TrasctionType = "H/T";
            //    ledger.HTechIn = _Item.NoOfItem;
            //    ledger.LineIn = _Item.NoOfItem;
            //    ledger.CompletedPcs = _Item.NoOfItem;
            //    ledger.TotalHTech = GetTotalHT(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.HTechIn;

            //    ledger.TotalLineIn = GetTotalLIN(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.LineIn;

            //    ledger.TotalCutOut = GetTotalCutOut(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.CompletedPcs;

            //    ledger.LineInCumm = GetLinCumm(ledger.StyleNo, ledger.Po) + ledger.LineIn;

            //    ledger.HTCumm = GetHTCumm(ledger.StyleNo, ledger.Po) + ledger.HTechIn;

            //    ledger.Cumulative = GetCumm(ledger.StyleNo, ledger.Po) + ledger.CompletedPcs;


            //    ledger.TableCut = _Item.NoOfItem; ;
            //    ledger.DocNo = txtIssuNoteNo.Text;


            //    ledger.Stock = ledger.TotalCutOut - ledger.TotalHTech;
            //    ledger.StockCumm = ledger.Cumulative - ledger.HTCumm;
            //    ledger.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            //    AddLedger(ledger);


            //    _stock.StyleNo = ledger.StyleNo;

               
            //    _stock.PoNo = _Item.PONo;

               
            //    _stock.LineIn = ledger.LineIn;

                
            //    _stock.Size = ledger.Size;

                
            //    _stock.Color = ledger.Color;

            //    if (cmbType.Text == "H/T")
            //    {
                   
            //        _stock.HtechIn = ledger.HTechIn;
            //    }
            //    else
            //    {
            //        ledger.TrasctionType = "PRO";
                   
            //        _stock.LineIn = ledger.LineIn;
            //    }
                   

              
            //    _stock.TNoteNo = txtIssuNoteNo.Text;
            //    _stock.ProductionLineNo = cmbLineNo.Text;

                


            //    GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
            //    foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            //    {
            //        _stock.CompanyID = item.CompanyID;

            //    }


            //    //  CuttingLedger ledger = new CuttingLedger();
               

            //    if (ifStatusExist(ledger.CuttingLedgerHeaderID) == true)
            //    {


            //    }
            //    else
            //    {
            //        addHeader();
            //    }

                
            //    AddStock(_stock);



            //}
            //catch (Exception ex)
            //{

            //}
        }


        void AddLedger(CuttingLedger _ledger)
        {
            try
            {
                GenaricRepository<CuttingLedger> _Repository = new GenaricRepository<CuttingLedger>(new ItrackContext());
                _Repository.Insert(_ledger);

            }
            catch (Exception ex)
            { }
        }


        void AddStock(CuttingStock _ledger)
        {
            try
            {
                GenaricRepository<CuttingStock> _Repository = new GenaricRepository<CuttingStock>(new ItrackContext());
                _Repository.Insert(_ledger);

            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public int GetTransactionID()
        {

            try
            {

                ItrackContext _context = new ItrackContext();
                return (from item in _context.CuttingLedger

                        select item.TransactionID).ToList().Max();

            }
            catch (Exception ex)
            {
                return 0;
            }

        }



        public int GetTableCut(string _style, string _poNo, string _Color, string _Size)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingItem
                        where item.CuttingHeader.StyleID == _style && item.PoNo == _poNo && item.Color == _Color && item.Size == _Size &&  item.Date.Day == DateTime.Now.Day && item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year
                        select item.NoOfItem).Sum();



            }
            catch (Exception ex)
            {

                return 0;

            }
        }



        public int GetCumm(string _style, string _poNo)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo
                        select item).ToList().Last().Cumulative;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }


        public int GetTotalCutOut(string _style, string _poNo, string _Color, string _Size)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo && item.Color == _Color && item.Size == _Size 
                        select item).ToList().Last().TotalCutOut;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }

        public int GetTotalHT(string _style, string _poNo, string _Color, string _Size)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo && item.Color == _Color && item.Size == _Size 
                        select item).ToList().Last().TotalHTech;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }



        public int GetTotalLIN(string _style, string _poNo, string _Color, string _Size)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo && item.Color == _Color && item.Size == _Size 
                        select item).ToList().Last().TotalLineIn;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }


        public int GetLinCumm(string _style, string _poNo)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo
                        select item).ToList().Last().LineInCumm;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }


        public int GetHTCumm(string _style, string _poNo)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo
                        select item).ToList().Last().HTCumm;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }


        public int GetCutOutCumm(string _style, string _poNo)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo
                        select item).ToList().Last().Cumulative;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }

        public int GetStockCumm(string _style, string _poNo)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo
                        select item).ToList().Last().StockCumm;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }

        public int GetStock(string _style, string _poNo, string _Color, string _Size)
        {
            try
            {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingLedger
                        where item.StyleNo == _style && item.Po == _poNo && item.Color == _Color && item.Size == _Size 
                        select item).ToList().Last().Stock;


            }
            catch (Exception ex)
            {

                return 0;

            }
        }



        private void UpdateLineNo(int _cutID,string _LineNo)
        {
            try
            {
                ItrackContext con = new ItrackContext();
                string _Query = "Update OprationBarcodes set [LineNo] = '"+ _LineNo + "' where CuttingItemID ='" + _cutID +"'";
                con.Database.ExecuteSqlCommand(_Query);
                con.Database.Connection.Close();
            }
            catch (Exception ex)
            {

            }


        }



        private int UpdateCutStatus(int _cutID)
        {
            try
            {
                ItrackContext _con = new ItrackContext();
                string _Query = "Update CuttingItems set isPrinted = 'True' where CuttingItemID = '"+ _cutID +"'";
               int row =  _con.Database.ExecuteSqlCommand(_Query);
                _con.Database.Connection.Close();


                return row;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }








        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ItrackContext _context = new ItrackContext();
            var Itrack =( from item in _context.CutIssuItem
                         where item.CutIssueHeaderID == txtIssuNoteNo.Text
                         select item).ToList();

            rptIssueNote report = new rptIssueNote();
            report.DataSource = Itrack;
           
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCutNo.Text = "";
            txtInputRequestedBy.Text = "";
            txtIssuNoteNo.Text = "";
            txtremark.Text = "";
            cmbLineNo.Text = "";
            txtStyleNo.Text = "";
            txtIssuNoteNo.Focus();
             GetNewCode();
        }


        string GetLast() {

            try {
                ItrackContext _cntx = new ItrackContext();
                var lat = (from item in _cntx.CutIssueHeader
                          select item.CutIssueHeaderID).ToList().Last();

                return lat;
            }
            catch (Exception ex) {
                return "";
            }
        }

        void GetNewCode()
        {
            try
            {

                RunningNo _No = new RunningNo();
                clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "ISE"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    string Code = GetLast();
                    int last = 0;
                    last = Convert.ToInt16(Code.Remove(0, _No.Prefix.Length));

                    txtIssuNoteNo.Text = _Engine.GenarateNo(_No, last);
                    txtIssuNoteNo.ReadOnly = true;

                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }



        int getCount()
        {
            try
            {
                GenaricRepository<CutIssueHeader> _GRNRepo = new GenaricRepository<CutIssueHeader>(new ItrackContext());
                return Convert.ToInt16( _GRNRepo.GetAll().ToList().Last().CutIssueHeaderID)+1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }

    }
}