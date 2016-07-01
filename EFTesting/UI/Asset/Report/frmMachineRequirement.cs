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
using EFTesting.DTOs;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.Reports;
using EFTesting.Reports.Asset;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace EFTesting.UI.Asset.Report
{
    public partial class frmMachineRequirement : DevExpress.XtraEditors.XtraForm
    {
        public frmMachineRequirement()
        {
            InitializeComponent();
        }



        List<MachineRequirementReportDto> lstDto = new List<MachineRequirementReportDto>();



       

        void print() {

            ItrackContext _context = new ItrackContext();

            var Departments = from dep in _context.Department
                              select new { dep.Name };

       
            foreach(var _department in Departments)
            {


                DateTime today = DateTime.Now;

                ItrackContext con = new ItrackContext();
               
                var styles = (from st in con.StyleLoading
                              where st.EndDate > today && st.LineNo == _department.Name
                              orderby st.EndDate
                              select new { st.StyleID, st.LineNo, st.StartDate, st.EndDate }).ToList();
                int i = 0;
                foreach( var selectedStyle in styles)
                {
                    if (i == 0)
                    {
                        Debug.WriteLine(" Current Style"+selectedStyle.StyleID + " " + selectedStyle.LineNo + "  " + selectedStyle.StartDate + "  " + selectedStyle.EndDate);
                        MachineRequirementReportDto dtoCurrent = new MachineRequirementReportDto();
                        dtoCurrent.StyleNo = selectedStyle.StyleID;
                        dtoCurrent.Location = selectedStyle.LineNo;
                        dtoCurrent.StartDate = selectedStyle.StartDate;
                        dtoCurrent.EndDate = selectedStyle.EndDate;
                        dtoCurrent.Type = "Current";
                        feedDto(dtoCurrent.StyleNo, dtoCurrent);
                        


                    }else if (i == 1)
                    {
                        Debug.WriteLine(" Next Style" + selectedStyle.StyleID + " " + selectedStyle.LineNo + "  " + selectedStyle.StartDate + "  " + selectedStyle.EndDate);

                        MachineRequirementReportDto dtoCurrent = new MachineRequirementReportDto();
                        dtoCurrent.StyleNo = selectedStyle.StyleID;
                        dtoCurrent.Location = selectedStyle.LineNo;
                        dtoCurrent.StartDate = selectedStyle.StartDate;
                        dtoCurrent.EndDate = selectedStyle.EndDate;
                        dtoCurrent.Type = "Next";
                        feedDto(dtoCurrent.StyleNo, dtoCurrent);
                    }
                    i++;
                }

                i = 0;



            }



            rptMachineRequrementByLine report = new rptMachineRequrementByLine();
            report.DataSource = lstDto;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();


            //string reportPath = "c:\\Test.xls";

            //// Create a report instance.
           

            //// Get its XLS export options.
            //XlsExportOptions xlsOptions = report.ExportOptions.Xls;

            //// Set XLS-specific export options.
            //xlsOptions.ShowGridLines = true;
            //xlsOptions.TextExportMode = TextExportMode.Value;

            //// Export the report to XLS.
            //report.ExportToXls(reportPath);

            //// Show the result.
            //StartProcess(reportPath);


        }


        // Use this method if you want to automaically open
        // the created XLS file in the default program.
        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }



        void feedDto(string _styleNo, MachineRequirementReportDto _dto)
        {
            ItrackContext cntx = new ItrackContext();
            var items = from item in cntx.MachineRequirementItem

                        where item.MachineRequirement.StyleID == _styleNo

                        select new { item.MachineType, item.Nos };
            foreach (var I in items)
            {
                _dto.MachineType = I.MachineType;
                _dto.Qty = I.Nos;
                lstDto.Add(_dto);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}