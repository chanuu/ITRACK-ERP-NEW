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
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using System.Diagnostics;

namespace EFTesting.UI.Cutting_report
{
    public partial class frmFabricreport : DevExpress.XtraEditors.XtraForm
    {
        public frmFabricreport()
        {
            InitializeComponent();
        }

        Style _style = new Style();
        private void GetCuttingDetailsReport()
        {
            try
            {
                //   rptCuttingDetails report = new rptCuttingDetails();
                //  report.DataSource = GetCuttingDetailsReport(txtStyleNo.Text);

                rptFabric report = new rptFabric();

                ItrackContext _context = new ItrackContext();
                if (chkByStyle.Checked == true)
                {
                    var list = (from item in _context.FabricLedger
                                where item.StyleNo == _style.StyleID
                                select item).ToList();

                    report.DataSource = list;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }
                else
                {
                    DateTime _from = Convert.ToDateTime(txtFrom.Text);
                    DateTime _to = Convert.ToDateTime(txtTo.Text);
                    var list = (from item in _context.FabricConsumption
                                where item.Date > _from && item.Date < _to
                                select item).ToList();

                    report.DataSource = list;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            GetCuttingDetailsReport();
        }
    }
}