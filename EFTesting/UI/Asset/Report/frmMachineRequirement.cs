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
using System.IO;

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
                              where st.EndDate > today  && st.LineNo == _department.Name
                              orderby st.StartDate
                              select new { st.Style.StyleNo,st.StyleID, st.LineNo, st.StartDate, st.EndDate }).ToList();
                int i = 0;
                foreach( var selectedStyle in styles)
                {
                    if (i == 0)
                    {
                         MachineRequirementReportDto dtoCurrent = new MachineRequirementReportDto();
                        dtoCurrent.StyleNo = selectedStyle.StyleNo;
                        dtoCurrent.StyleID = selectedStyle.StyleID;
                        dtoCurrent.Location = selectedStyle.LineNo;
                        dtoCurrent.StartDate = selectedStyle.StartDate;
                        dtoCurrent.EndDate = selectedStyle.EndDate;
                        dtoCurrent.Type = "Current";
                        feedDto(dtoCurrent.StyleID, dtoCurrent);
                        


                    }else if (i == 1)
                    {
                       
                        MachineRequirementReportDto dtoNext = new MachineRequirementReportDto();
                        dtoNext.StyleNo = selectedStyle.StyleNo;
                        dtoNext.Location = selectedStyle.LineNo;
                        dtoNext.StartDate = selectedStyle.StartDate;
                        dtoNext.EndDate = selectedStyle.EndDate;
                        dtoNext.StyleID = selectedStyle.StyleID;
                        dtoNext.Type = "Next";
                        feedDto(dtoNext.StyleID, dtoNext);

                    }
                    i++;
                }

                i = 0;



            }



            rptMachineRequrementByLine report = new rptMachineRequrementByLine();
            report.DataSource = lstDto;
            report.Landscape = true;
            ReportPrintTool tool = new ReportPrintTool(report);
           // tool.ShowPreview();




        

            string reportPath = "d:\\MRequirement.xls";

            // Create a report instance.


            // Get its XLS export options.
            XlsExportOptions xlsOptions = report.ExportOptions.Xls;

            // Set XLS-specific export options.
            xlsOptions.ShowGridLines = true;
            xlsOptions.TextExportMode = TextExportMode.Value;

            // Export the report to XLS.
            report.ExportToXls(reportPath);

            // Show the result.
            StartProcess(reportPath);


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
                MachineRequirementReportDto dtoReq = new MachineRequirementReportDto();
                dtoReq.MachineType = I.MachineType;
                dtoReq.Qty = I.Nos;
                dtoReq.StyleNo = _dto.StyleNo;
                dtoReq.StyleID = _dto.StyleID;
                dtoReq.Location = _dto.Location;
                dtoReq.Type = _dto.Type;
                dtoReq.StartDate = _dto.StartDate;
                dtoReq.EndDate = _dto.EndDate;
                lstDto.Add(dtoReq);

                addBalance(dtoReq, lstDto);
                



            }
        }


        void addBalance(MachineRequirementReportDto _dto,  List<MachineRequirementReportDto> lst)
        {
            if(_dto.Type == "Next")
            {
                var row_Item = from _row in lst
                           where  _row.Location == _dto.Location && _row.MachineType == _dto.MachineType && _row.Type == "Current"
                           select _row;

                if (row_Item.Count() > 0)
                {
                    MachineRequirementReportDto newDto = new MachineRequirementReportDto();
                    newDto.Type = "Required Mcs For:";
                    newDto.Location = _dto.Location;
                    newDto.StyleNo = _dto.StyleNo;
                    newDto.StyleID = _dto.StyleID;
                    newDto.MachineType = _dto.MachineType;
                    newDto.Qty = _dto.Qty - row_Item.Last().Qty;
                    lstDto.Add(newDto);

                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            print();
        }

        private void frmMachineRequirement_Load(object sender, EventArgs e)
        {
            chkAllLine.Checked = true;
        }
    }
}