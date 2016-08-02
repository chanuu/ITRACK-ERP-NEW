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
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using EFTesting.ViewModel;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.UI.User_Accounts;

namespace EFTesting.UI.Cutting_report
{
    public partial class frmCuttingDaliySelection : DevExpress.XtraEditors.XtraForm
    {
        public frmCuttingDaliySelection()
        {
            InitializeComponent();
        }

        //public string StyleNo { get; set; }
        //public frmCuttingDaliySelection(string _styleNo)
        //{
        //    InitializeComponent();
        //    this.StyleNo = _styleNo;
        //}


        private void GetCuttingDetailsReport()
        {
            try
            {
                //   rptCuttingDetails report = new rptCuttingDetails();
                //  report.DataSource = GetCuttingDetailsReport(txtStyleNo.Text);

                rptCutS report = new rptCutS();
                report.DataSource = GetList();
                report.Landscape = true;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        List<CutReport> lst = new List<CutReport>();

        private List<CutReport> GetList()
        {
            GenaricRepository<CuttingItem> _CuttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
           
            lst.Clear();

            if (chkDayCut.Checked == true && chkByStyle.Checked ==false && chkByPo.Checked == false)

            {
                ItrackContext con = new ItrackContext();
                DateTime _from = Convert.ToDateTime(txtFrom.Text);

                DateTime _to = Convert.ToDateTime(txtTo.Text);

                var items =( from item in con.CuttingItem
                            where item.CuttingHeader.Style.CompanyID == frmLoging._user.Employee.CompanyID && item.Date >= _from && item.Date <= _to
                            select item).ToList();
                
                foreach (var item in items)
                {

                   
                    lst.Add(new CutReport { StyleNo = item.CuttingHeader.Style.StyleNo, Date = item.Date, PoNo = item.PoNo, Color = item.Color, Size = item.Size, Pcs = item.NoOfItem });

                }

            }
            else if (chkByStyle.Checked == true && chkDayCut.Checked == true)
            {
              
            }
            else if (chkByPo.Checked == true && chkDayCut.Checked == false)
            {
                ItrackContext con = new ItrackContext();
                var items = from item in con.CuttingItem
                            where item.CuttingHeader.StyleID == txtStyleNo.Text && item.PoNo == txtPoNo.Text
                            select item;


                foreach (var item in items)
                {

                    lst.Add(new CutReport { StyleNo = item.CuttingHeader.Style.StyleNo, Date = item.Date, PoNo = item.PoNo, Color = item.Color, Size = item.Size, Pcs = item.NoOfItem });

                }
            }
           
            return lst;
        }


        void Preview() {

            if (chkByStyle.Checked == true && chkDayCut.Checked == false)
            {
                byStyle();
            }
            else if (chkByStyle.Checked == true && chkDayCut.Checked == true)
            {
                byStyleAndDate();
            }
            else if (chkByStyle.Checked == false && chkDayCut.Checked == true)
            {
                ByDateRange();
            }else if(chkByStyle.Checked == true && chkDayCut.Checked == false && chkByPo.Checked==true)
            {
                byStyleAndPo();
            }
            else if (chkByStyle.Checked == true && chkDayCut.Checked == false && chkByPo.Checked==true)
            {
                byStyleAndDateAndPo();
            }

         

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();

            // GetCuttingDetailsReport();
            Preview();

           splashScreenManager1.CloseWaitForm();
        }












        void ByDateRange() {


            ItrackContext con = new ItrackContext();
            DateTime _from = Convert.ToDateTime(txtFrom.Text);

            DateTime _to = Convert.ToDateTime(txtTo.Text);

            var items =( from item in con.CuttingItem
                        where  item.Date >= _from && item.Date <= _to
                        select item).ToList();

            Debug.WriteLine(items.Last().CuttingHeader.Style.StyleNo);


            lst.Clear();
            foreach(var lines in items)
            {
                CutReport _report = new CutReport();
                _report.Color = lines.Color;
                _report.Date = lines.Date;
                _report.Pcs = lines.NoOfItem;
                _report.PoNo = lines.PoNo;
                _report.Size = lines.Size;
                _report.StyleNo = lines.CuttingHeader.Style.StyleNo;
                lst.Add(_report);
            }
          

            rptCutS report = new rptCutS();
            report.DataSource = lst;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

        


        }

        void byStyleAndDate()
        {

            ItrackContext db = new ItrackContext();
            DateTime _from = Convert.ToDateTime(txtFrom.Text);

            DateTime _to = Convert.ToDateTime(txtTo.Text);

            var items = from item in db.CuttingItem
                        where item.CuttingHeader.StyleID == txtStyleNo.Text && item.Date >= _from && item.Date <= _to
                        select item;
          //  db.Database.Connection.Close();
            lst.Clear();
            foreach (var lines in items)
            {
                CutReport _report = new CutReport();
                _report.Color = lines.Color;
                _report.Date = lines.Date;
                _report.Pcs = lines.NoOfItem;
                _report.PoNo = lines.PoNo;
                _report.Size = lines.Size;
                _report.StyleNo = lines.CuttingHeader.Style.StyleNo;
                lst.Add(_report);
            }

            
            rptCutS report = new rptCutS();
            report.DataSource = lst;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

        }


        void byStyle() {
             ItrackContext context = new ItrackContext();
         

            var items = from item in context.CuttingItem
                        where item.CuttingHeader.StyleID == txtStyleNo.Text
                        select item;

            lst.Clear();

            foreach (var lines in items)
            {
                CutReport _report = new CutReport();
                _report.Color = lines.Color;
                _report.Date = lines.Date;
                _report.Pcs = lines.NoOfItem;
                _report.PoNo = lines.PoNo;
                _report.Size = lines.Size;
                _report.StyleNo = lines.CuttingHeader.Style.StyleNo;
                lst.Add(_report);
            }

            context.Database.Connection.Close();
            rptCutS report = new rptCutS();
            report.DataSource = lst;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();


        }






        void byStyleAndPo()
        {
            ItrackContext context = new ItrackContext();


            var items = from item in context.CuttingItem
                        where item.CuttingHeader.StyleID == txtStyleNo.Text && item.PoNo == txtPoNo.Text
                        select item;

            lst.Clear();

            foreach (var lines in items)
            {
                CutReport _report = new CutReport();
                _report.Color = lines.Color;
                _report.Date = lines.Date;
                _report.Pcs = lines.NoOfItem;
                _report.PoNo = lines.PoNo;
                _report.Size = lines.Size;
                _report.StyleNo = lines.CuttingHeader.Style.StyleNo;
                lst.Add(_report);
            }

            context.Database.Connection.Close();
            rptCutS report = new rptCutS();
            report.DataSource = lst;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();


        }



        void byStyleAndDateAndPo()
        {
            ItrackContext context = new ItrackContext();

            DateTime _from = Convert.ToDateTime(txtFrom.Text);

            DateTime _to = Convert.ToDateTime(txtTo.Text);
            var items = from item in context.CuttingItem
                        where item.CuttingHeader.StyleID == txtStyleNo.Text && item.PoNo == txtPoNo.Text && item.Date >= _from && item.Date <= _to
                        select item;

            lst.Clear();

            foreach (var lines in items)
            {
                CutReport _report = new CutReport();
                _report.Color = lines.Color;
                _report.Date = lines.Date;
                _report.Pcs = lines.NoOfItem;
                _report.PoNo = lines.PoNo;
                _report.Size = lines.Size;
                _report.StyleNo = lines.CuttingHeader.Style.StyleNo;
                lst.Add(_report);
            }

            context.Database.Connection.Close();
            rptCutS report = new rptCutS();
            report.DataSource = lst;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();


        }
    }


}

    
