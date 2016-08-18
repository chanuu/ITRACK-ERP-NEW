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
using DevExpress.XtraReports.UI;
using EFTesting.Reports.Asset;
using EFTesting.Reports.Cutting_Report;

namespace EFTesting.UI.Asset.Report
{
    public partial class frmFabricConsumtionVsActual : DevExpress.XtraEditors.XtraForm
    {
        public frmFabricConsumtionVsActual()
        {
            InitializeComponent();
        }



        void PrintAllStyle() {
            try {

                ItrackContext _Context = new ItrackContext();

                var print = (from item in _Context.EstimateFabricConsumption
                            select item).ToList();

                rptLayerFabricConsumtion report = new rptLayerFabricConsumtion();
                report.DataSource = print;
                report.Landscape = true;
                ReportPrintTool tool = new ReportPrintTool(report);
               tool.ShowPreview();

            }
            catch (Exception ex) {

            }
        }


        void PrintByDay(DateTime _from,DateTime _to)
        {
            try
            {

                ItrackContext _Context = new ItrackContext();

                var print = (from item in _Context.EstimateFabricConsumption
                             where item.Date >= _from && item.Date <=_to
                             select item).ToList();

                rptLayerFabricConsumtion report = new rptLayerFabricConsumtion();
                report.DataSource = print;
                report.Landscape = true;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();

            }
            catch (Exception ex)
            {

            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(chkByDate.Checked == true && chkByStyle.Checked == false)
            {
                PrintByDay(Convert.ToDateTime(txtFrom.Text), Convert.ToDateTime(txtTo.Text));

            }
            else if(chkByStyle.Checked == true && chkByDate.Checked == false)
            {
                PrintAllStyle();
            }
            
        }
    }
}