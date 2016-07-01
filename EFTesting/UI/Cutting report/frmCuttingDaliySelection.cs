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


        private List<CutReport> GetList()
        {
            GenaricRepository<CuttingItem> _CuttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
            List<CutReport> lst = new List<CutReport>();
           

           if(chkDayCut.Checked == true && chkByStyle.Checked ==false && chkByPo.Checked == false)

            {
                ItrackContext con = new ItrackContext();
                DateTime _from = Convert.ToDateTime(txtFrom.Text);

                DateTime _to = Convert.ToDateTime(txtTo.Text);

                var items =( from item in con.CuttingItem
                            where item.CuttingHeader.Style.CompanyID == frmLoging._user.Employee.CompanyID && item.Date >= _from && item.Date <= _to
                            select item).ToList();
                lst.Clear();
                foreach (var item in items)
                {

                   
                    lst.Add(new CutReport { StyleNo = item.CuttingHeader.StyleID, Date = item.Date, PoNo = item.PoNo, Color = item.Color, Size = item.Size, Pcs = item.NoOfItem });

                }

            }
            else if (chkByStyle.Checked == true && chkDayCut.Checked == true)
            {
                ItrackContext con = new ItrackContext();
                DateTime _from = Convert.ToDateTime(txtFrom.Text);

                DateTime _to = Convert.ToDateTime(txtTo.Text);

                var items = from item in con.CuttingItem
                            where item.CuttingHeader.StyleID == txtStyleNo.Text && item.Date >= _from && item.Date <= _to
                            select item;

                lst.Clear();

                foreach (var item in items)
                {

                    lst.Add(new CutReport { StyleNo = item.CuttingHeader.StyleID, Date = item.Date, PoNo = item.PoNo, Color = item.Color, Size = item.Size, Pcs = item.NoOfItem });

                }
            }
            else if (chkByPo.Checked == true && chkDayCut.Checked == false)
            {
                ItrackContext con = new ItrackContext();
                var items = from item in con.CuttingItem
                            where item.CuttingHeader.StyleID == txtStyleNo.Text && item.PoNo == txtPoNo.Text
                            select item;


                foreach (var item in items)
                {

                    lst.Add(new CutReport { StyleNo = item.CuttingHeader.StyleID, Date = item.Date, PoNo = item.PoNo, Color = item.Color, Size = item.Size, Pcs = item.NoOfItem });

                }
            }
           
            return lst;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GetCuttingDetailsReport();
        }
    }
}