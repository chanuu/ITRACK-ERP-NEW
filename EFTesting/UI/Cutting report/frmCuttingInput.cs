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
using EFTesting.Reports.Cutting_Report;
using DevExpress.XtraReports.UI;
using EFTesting.DTOs;

namespace EFTesting.UI.Cutting_report
{
    public partial class frmCuttingInput : DevExpress.XtraEditors.XtraForm
    {
        public frmCuttingInput()
        {
            InitializeComponent();
        }

        private void chkDayCut_CheckedChanged(object sender, EventArgs e)
        {

        }




        void GetDalyInput()
        {

            try
            {
                ItrackContext _context = new ItrackContext();

                DateTime _from = Convert.ToDateTime(txtFrom.Text);

                DateTime _to = Convert.ToDateTime(txtTo.Text);

                var items = (from item in _context.CutIssuItem
                             where item.CutIssueHeader.Date >= _from && item.CutIssueHeader.Date <= _to
                             select item).ToList();


                List<InputIssuingRecorddto> lstDto = new List<InputIssuingRecorddto>();
                

                foreach(var row in items)
                {
                    InputIssuingRecorddto _item = new InputIssuingRecorddto();
                    _item.Color = row.Color;
                    _item.Size = row.Size;
                    _item.PONo = row.PONo;
                    _item.NoOfItem = row.NoOfItem;
                    _item.LineNo = row.CutIssueHeader.LineNo;
                    _item.StyleNo = row.CutIssueHeader.StyleNo;
                    _item.Date = Convert.ToDateTime(row.CutIssueHeader.Date.ToShortDateString());

                    lstDto.Add(_item);

                }



             rtInputIssuingRecord report = new rtInputIssuingRecord();
                report.DataSource = lstDto;
                report.Landscape = true;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();



            }
            catch (Exception ex)
            {

            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(chkDayCut.Checked == true)
            {
                GetDalyInput();
            }
        }

        private void frmCuttingInput_Load(object sender, EventArgs e)
        {

        }
    }
}