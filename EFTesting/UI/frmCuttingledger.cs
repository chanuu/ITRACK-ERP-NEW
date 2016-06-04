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
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using EFTesting.DTOs;
using EFTesting.Reports.Report;
using System.Diagnostics;

namespace EFTesting.UI
{
    public partial class frmCuttingledger : DevExpress.XtraEditors.XtraForm
    {
        public frmCuttingledger()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedColorCombo(cmbPoNo.Text);
            feedSizeCombo(cmbPoNo.Text);
        }





        void feedStyleCombo() {

            try {
                ItrackContext context = new ItrackContext();
                ComboBoxItemCollection coll = cmbStyleNo.Properties.Items;
                coll.Clear();

                var style = (from items in context.Style
                             select new { items.StyleID, items.Remark }).ToList();

                foreach (var s in style)
                {
                    coll.Add(s.StyleID);
                }
            }
            catch (Exception ex) {
            }
        }




        void feedPOCombo(string _styleId)
        {

            try
            {
                ItrackContext context = new ItrackContext();
                ComboBoxItemCollection coll = cmbPoNo.Properties.Items;
                coll.Clear();

                var style = (from items in context.PurchaseOrderHeader
                             where items.StyleID == _styleId
                             select new { items.StyleID, items.PurchaseOrderHeaderID }).ToList();


                foreach (var s in style)
                {
                    coll.Add(s.PurchaseOrderHeaderID);
                }
            }
            catch (Exception ex)
            {
            }
        }



        void feedColorCombo(string _poId)
        {

            try
            {
                ItrackContext context = new ItrackContext();
                ComboBoxItemCollection coll = cmbColor.Properties.Items;
                coll.Clear();

                var style = (from items in context.PurchaseOrderItems
                             where items.PurchaseOrderHeaderID == _poId
                             select new { items.Color }).ToList();



                foreach (var s in style.Distinct())
                {
                    coll.Add(s.Color);
                }
            }
            catch (Exception ex)
            {
            }
        }




        void feedSizeCombo(string _poId)
        {

            try
            {
                ItrackContext context = new ItrackContext();
                ComboBoxItemCollection coll = cmbSize.Properties.Items;
                coll.Clear();

                var style = (from items in context.PurchaseOrderItems
                             where items.PurchaseOrderHeaderID == _poId
                             select new { items.Size }).ToList();



                foreach (var s in style.Distinct())
                {
                    coll.Add(s.Size);
                }
            }
            catch (Exception ex)
            {
            }
        }


        public int GetTableCut(string _style, string _poNo, string _Color, string _Size)
        {
            try {

                ItrackContext context = new ItrackContext();
                return (from item in context.CuttingItem
                        where item.CuttingHeader.StyleID == _style && item.PoNo == _poNo && item.Color == _Color && item.Size == _Size  && item.Date.Day == DateTime.Now.Day && item.Date.Month == DateTime.Now.Month && item.Date.Year == DateTime.Now.Year
                        select item.NoOfItem).Sum();



            }
            catch (Exception ex) {

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



        void GetLedgerItem() {
            try {
                ItrackContext context = new ItrackContext();

                var status = (from item in context.CuttingLedger
                              where item.CuttingLedgerHeaderID == DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year
                              select new { item.StyleNo, item.Po, item.LineNo, item.Color, item.Size, item.TrasctionType, item.TableCut, item.CompletedPcs, item.Cumulative, item.LineIn, item.TotalLineIn, item.HTechIn, item.TotalHTech, item.Stock }).ToList();

                grdSearchStyle.DataSource = status;
            }
            catch (Exception ex) {

            }


        }





        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCuttingledger_Load(object sender, EventArgs e)
        {
            feedStyleCombo();
            GetLedgerItem();
        }

        private void cmbStyleNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedPOCombo(cmbStyleNo.Text);

        }

        private void txtLineIn_Enter(object sender, EventArgs e)
        {
            txtLineIn.SelectAll();
        }

        private void txthIn_Enter(object sender, EventArgs e)
        {
            txthIn.SelectAll();

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTableCut.Text = Convert.ToString(GetTableCut(cmbStyleNo.Text, cmbPoNo.Text, cmbColor.Text, cmbSize.Text));
        }



        List<CuttingLedger> List = new List<CuttingLedger>();



        void addHeader()
        {
            try {
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
            catch (Exception ex) {

            }
        }


        void AddLedger(CuttingLedger _ledger)
        {
            try {
                GenaricRepository<CuttingLedger> _Repository = new GenaricRepository<CuttingLedger>(new ItrackContext());
                _Repository.Insert(_ledger);

            }
            catch (Exception ex)
            { }
        }

        bool ifStatusExist(string Id) {


            try {

                ItrackContext context = new ItrackContext();
                var item = from items in context.CuttingLedgerHeader
                           where items.CuttingLedgerHeaderID == Id

                           select items;

                if (item.Count() > 0)
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




        public int GetTransactionID() {

            try {

                ItrackContext _context = new ItrackContext();
                return (from item in context.CuttingLedger

                 select item.TransactionID).ToList().Max();

            }
            catch (Exception ex) {
                return 0;
            }
          
        }


        void Populate() {
            try {


                CuttingLedger ledger = new CuttingLedger();
                ledger.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

                if (ifStatusExist(ledger.CuttingLedgerHeaderID) == true)
                {


                }
                else
                {
                    addHeader();
                }
                ledger.Date = Convert.ToDateTime(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                ledger.TransactionID = GetTransactionID();
                ledger.StyleNo = cmbStyleNo.Text;
                ledger.Po = cmbPoNo.Text;
                ledger.LineNo = cmbLineNo.Text;
                ledger.Size = cmbSize.Text;
                ledger.Color = cmbColor.Text;
                ledger.TrasctionType = cmbtType.Text;

                if (ledger.TrasctionType == "OB") {
                    ledger.Cumulative = Convert.ToInt16(txtCutOut.Text);
                    ledger.TotalHTech = Convert.ToInt16(txthIn.Text);
                    ledger.TotalLineIn = Convert.ToInt16(txtLineIn.Text);
                    ledger.TotalCutOut = ledger.Cumulative;
                    ledger.HTCumm =ledger.TotalHTech;
                    ledger.LineInCumm = ledger.LineInCumm;

                }
                else {
                    ledger.HTechIn = Convert.ToInt16(txthIn.Text);
                    ledger.LineIn = Convert.ToInt16(txtLineIn.Text);
                    ledger.CompletedPcs = Convert.ToInt16(txtCutOut.Text);

                    ledger.TotalHTech = GetTotalHT(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.HTechIn;

                    ledger.TotalLineIn = GetTotalLIN(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.LineIn;

                    ledger.TotalCutOut = GetTotalCutOut(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.CompletedPcs;

                    ledger.LineInCumm = GetLinCumm(ledger.StyleNo, ledger.Po) + ledger.LineIn;

                    ledger.HTCumm = GetHTCumm(ledger.StyleNo, ledger.Po)+ledger.HTechIn;

                    ledger.Cumulative = GetCumm(ledger.StyleNo, ledger.Po)+ ledger.CompletedPcs;

                }
                ledger.TableCut = Convert.ToInt16(txtTableCut.Text);



                ledger.Stock = ledger.TotalCutOut - ledger.TotalHTech;
                ledger.StockCumm = ledger.Cumulative - ledger.HTCumm;
                AddLedger(ledger);


            }
            catch (Exception ex) {

            }
        }




        void GetSummaryReport(DateTime _from,DateTime _To) {
            try {

                ItrackContext _context = new ItrackContext();
              

            }
            catch (Exception ex) {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
            GetLedgerItem();
        }


        List<dtoCuttingLedgerSummary> lstLedger = new List<dtoCuttingLedgerSummary>();



        

        ItrackContext context = new ItrackContext();
        dtoCuttingLedgerSummary getLastItem(dtoCuttingLedgerSummary _ledger) {
            dtoCuttingLedgerSummary summary = new dtoCuttingLedgerSummary();
            try {
                var lastitem = (from item in context.CuttingLedger
                                where item.StyleNo == _ledger.StyleNo && item.Po == _ledger.Po
                                orderby item.TransactionID
                                select item).ToList().Last();


                summary.StyleNo = lastitem.StyleNo;
                summary.Po = lastitem.Po;
                summary.Date = lastitem.Date;
                summary.LineNo = lastitem.LineNo;
                summary.Color = lastitem.Color;
                summary.Size = lastitem.Size;
                summary.TableCut = lastitem.TableCut;
                summary.CompletedPcs = lastitem.CompletedPcs;
                summary.Cumulative = lastitem.Cumulative;
                summary.LineIn = lastitem.LineIn;
                summary.TotalLineIn = lastitem.TotalLineIn;
                summary.HTechIn = lastitem.HTechIn;
                summary.TotalHTech = lastitem.TotalHTech;
                summary.Stock = lastitem.Stock;
                summary.Cumulative = lastitem.Cumulative;
                summary.HTCumm = lastitem.HTCumm;
                summary.LInCumm = lastitem.LineInCumm;
                summary.StockCumm = lastitem.Stock;
                return summary;
            }
            catch (Exception ex) {
                return null;
            }

           
        }


        List<CuttingLedger> cLedgerList = new List<CuttingLedger>();
        void GetOpenPo() {
            try {


                ItrackContext Context = new ItrackContext();

                var poList = (from item in Context.PurchaseOrderHeader
                             where item.isOpen == true
                             select item).ToList();


                foreach(var po in poList)
                {
                    dtoCuttingLedgerSummary _ledger = new dtoCuttingLedgerSummary();
                    _ledger.Po = po.PurchaseOrderHeaderID;
                    _ledger.StyleNo = po.StyleID;


                    if (getLastItem(_ledger) != null)
                    {

                        _ledger = getLastItem(_ledger);
                        _ledger.OrderQty = getPoQty(po.PurchaseOrderHeaderID);
                        _ledger.Balance = _ledger.OrderQty - _ledger.Cumulative;
                        _ledger.FOBDate = GetFobDate(po.PurchaseOrderHeaderID);
                        lstLedger.Add(_ledger);
                    }
                    else {
                        _ledger.StyleNo = po.StyleID;
                        _ledger.Po = po.PurchaseOrderHeaderID;
                        _ledger.Cumulative = 0;
                        _ledger.HTCumm = 0;
                        _ledger.LInCumm = 0;
                        _ledger.StockCumm = 0;
                        _ledger.OrderQty = getPoQty(po.PurchaseOrderHeaderID);
                        _ledger.Balance = _ledger.OrderQty - _ledger.Cumulative;
                        _ledger.FOBDate = GetFobDate(po.PurchaseOrderHeaderID);
                        lstLedger.Add(_ledger);
                    }
                   
                   
                    //if (_ledger == null) {

                    //    dtoCuttingLedgerSummary dto = new dtoCuttingLedgerSummary();
                       
                    //}
                    //else{
                       
                    //}
                 

                }



                rptLedgerByPo s = new rptLedgerByPo();
                s.DataSource = lstLedger;

                DevExpress.XtraReports.UI.ReportPrintTool tool = new ReportPrintTool(s);
                tool.ShowPreview();

            }
            catch (Exception ex) {

            }

        }


        int getPoQty(string _poNo) {
            try{
                ItrackContext _context = new ItrackContext();
                var item = (from items in _context.PurchaseOrderItems
                        where items.PurchaseOrderHeaderID == _poNo
                        select items.Quantity).ToList();

                if (item.Count > 0)
                {
                    return item.Sum();
                    
                }
                else {
                    return 0;
                }
               

            }
            catch(Exception ex){
                return 0;
            }
        }



        Nullable<System.DateTime> GetFobDate(string _po) {

            try {
                ItrackContext _context = new ItrackContext();
                var item = (from items in _context.PurchaseOrderHeader
                            where items.PurchaseOrderHeaderID == _po
                            select items.EndDate).ToList();

                return item.Last();
            }
            catch (Exception ex) {
                return null;
            }
        }




        void printReport() {

            ItrackContext context = new ItrackContext();

            //var report = (from item in context.CuttingLedger
            //              where item.CuttingLedgerHeaderID == DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year
            //              select item).ToList();



            //rptLedgerSummary s = new rptLedgerSummary();
            //s.DataSource = report;

            //DevExpress.XtraReports.UI.ReportPrintTool tool = new ReportPrintTool(s);
            //tool.ShowPreview();


            var report = (from item in context.AssetBarcode
                         
                          select item).ToList();



            XtraReport1 s = new XtraReport1();
            s.DataSource = report;

            DevExpress.XtraReports.UI.ReportPrintTool tool = new ReportPrintTool(s);
            tool.ShowPreview();

        }


     void Populate(CutIssuItem _Item,string _styleNo,string _type)
        {

            CuttingLedger ledger = new CuttingLedger();
            CuttingStock _stock = new CuttingStock();



            ledger.Date = Convert.ToDateTime(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            _stock.Date = ledger.Date;

            ledger.TransactionID = GetTransactionID();
            ledger.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            
            ledger.StyleNo = _styleNo;

            ledger.Po = _Item.PONo;

            ledger.LineNo = cmbLineNo.Text;

            ledger.Size = _Item.Size;

            ledger.Color = _Item.Color;

            ledger.TrasctionType = _type;

           

        if(ledger.TrasctionType == "PRO")
            {
                ledger.LineIn = _Item.NoOfItem;
                ledger.TableCut = 0;

            }
            else if(ledger.TrasctionType == "CUT-PRO")
            {
                ledger.CompletedPcs = _Item.NoOfItem;
                ledger.TableCut = _Item.NoOfItem;

            }
            else
            {
                ledger.HTechIn = _Item.NoOfItem;
                ledger.TableCut = 0;
            }

           

            //
           

            //
            ledger.TotalHTech = GetTotalHT(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.HTechIn;

            //
            ledger.TotalLineIn = GetTotalLIN(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.LineIn;

            //
            ledger.TotalCutOut = GetTotalCutOut(ledger.StyleNo, ledger.Po, ledger.Color, ledger.Size) + ledger.CompletedPcs;

            ledger.Cumulative = GetCumm(ledger.StyleNo, ledger.Po) + ledger.CompletedPcs;

            //
            ledger.LineInCumm = GetLinCumm(ledger.StyleNo, ledger.Po) + ledger.LineIn;

            //
            ledger.HTCumm = GetHTCumm(ledger.StyleNo, ledger.Po) + ledger.HTechIn;

            //
           


           
           


            ledger.Stock = ledger.TotalCutOut - ledger.TotalHTech;
            ledger.StockCumm = ledger.Cumulative - ledger.HTCumm;
            ledger.CuttingLedgerHeaderID = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            if (ifStatusExist(ledger.CuttingLedgerHeaderID) == true)
            {


            }
            else
            {
                addHeader();
            }

            AddLedger(ledger);

        }



        bool isLedgerExist(DateTime _date,string _styleNo,string _Po,string _Color,string _Size)
        {
            ItrackContext _ctx = new ItrackContext();
            var item = (from i in _ctx.CuttingLedger
                        where i.Date.Day == _date.Day && i.Date.Month==_date.Month && i.Date.Year==_date.Year && i.StyleNo == _styleNo && i.Po == _Po && i.Color == _Color && i.Size == _Size
                        select new { i.TableCut }).ToList();
            if (item.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        int GetComplatePcs(DateTime _date,string _styleNo,string _PoNo,string _Color,string _Size)
        {
            ItrackContext _cntx = new ItrackContext();
            var cut = (from item in _cntx.CutIssuItem
                       where item.CutIssueHeader.Date.Day == _date.Day && item.CutIssueHeader.Date.Month == _date.Month && item.CutIssueHeader.Date.Year == _date.Year && item.CutIssueHeader.StyleNo == _styleNo && item.PONo == _PoNo && item.Color == _Color && item.Size == _Size
                       group item by new { item.CutIssueHeader.StyleNo, item.PONo, item.Color, item.Size } into G
                       select new { G.Key.StyleNo, G.Key.PONo, G.Key.Color, G.Key.Size, Pcs = G.Sum(x => x.NoOfItem) }).ToList().Last();


            return cut.Pcs;


        }

        void DayEnd(DateTime _date) {
          try  {

                ItrackContext _context = new ItrackContext();

                CutIssuItem _issue = new CutIssuItem();
                //check table cut 

                var tablecut = (from cut in _context.CuttingItem

                                where cut.Date.Day == _date.Day && cut.Date.Month == _date.Month && cut.Date.Year == _date.Year

                                group cut by new { cut.CuttingHeader.StyleID, cut.PoNo, cut.Size, cut.Color } into G

                                select new { G.Key.StyleID, G.Key.PoNo, G.Key.Color, G.Key.Size, Pcs = G.Sum(a => a.NoOfItem) }).ToList();


                foreach (var tcut in tablecut)
                {



                    Debug.WriteLine(tcut.Pcs);
                    CutIssuItem issue = new CutIssuItem();

                    issue.PONo = tcut.PoNo;

                    issue.Color = tcut.Color;
                    issue.Size = tcut.Size;
                    issue.NoOfItem = tcut.Pcs;
                    Populate(issue, tcut.StyleID, "CUT-PRO");



                }






                
                var data = ( from item in _context.CutIssuItem
                             where item.CutIssueHeader.Date.Day == _date.Day && item.CutIssueHeader.Date.Month == _date.Month && item.CutIssueHeader.Date.Year == _date.Year
                             group item by new {item.CutIssueHeader.Type, item.CutIssueHeader.StyleNo,item.PONo, item.Size, item.Color } into G
                           select new {G.Key.Type, G.Key.StyleNo, G.Key.PONo, G.Key.Color, G.Key.Size, Pcs = G.Sum(a => a.NoOfItem) }).ToList();


               

                foreach (var item in data)
                {
                    
                    _issue.PONo = item.PONo;
                 
                    _issue.Color = item.Color;
                    _issue.Size = item.Size;
                    _issue.NoOfItem = item.Pcs;
                 

                    Populate(_issue, item.StyleNo, item.Type);
                }



             


            }
            catch (Exception ex)
            {

            }

        }










        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // printReport();
            DayEnd(DateTime.Now);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(chkSummary.Checked == true)
            {
                GetOpenPo();
            }
        }
    }
}