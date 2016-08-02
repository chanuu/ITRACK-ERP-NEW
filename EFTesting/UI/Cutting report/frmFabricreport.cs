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
using EFTesting.DTOs;

namespace EFTesting.UI.Cutting_report
{
    public partial class frmFabricreport : DevExpress.XtraEditors.XtraForm
    {
        public frmFabricreport()
        {
            InitializeComponent();
        }

        Style _style = new Style();


        List<FabricUtilizationdto> lstFabric = new List<FabricUtilizationdto>();
        private void GetCuttingDetailsReport()
        {
            try
            {
                //   rptCuttingDetails report = new rptCuttingDetails();
                //  report.DataSource = GetCuttingDetailsReport(txtStyleNo.Text);

                rptFabric report = new rptFabric();

                ItrackContext _context = new ItrackContext();
                if (chkByStyle.Checked == true && chkDay.Checked ==false)
                {
                    lstFabric.Clear();
                    var list = (from item in _context.FabricLedger
                                where item.StyleNo == txtStyleNo.Text
                                select item).ToList();

                    foreach (var item in list)
                    {
                        FabricUtilizationdto dto = new FabricUtilizationdto();
                        dto.StyleNo = item.StyleRef;
                        dto.MarkerNo = item.MarkerNo;
                        dto.NoOfFlys = item.NoOfFlys;
                        dto.Date = item.Date;
                        dto.RollNo = item.RollNo;
                        dto.NotedLength = item.NotedLength;
                        dto.MarkerLength = item.MarkerLength;
                        dto.FabricUsed = item.FabricUsed;
                        dto.NotedBalance = item.NotedBalance;
                        dto.ActualBalance = item.ActualBalance;

                        if (dto.ActualBalance != 0)
                        {
                            // calcute balance shortage
                            dto.Shortage = dto.NotedBalance - dto.ActualBalance;
                        }

                        lstFabric.Add(dto);
                    }

                    report.DataSource = lstFabric;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                } else if(chkByStyle.Checked == true && chkDay.Checked ==true)
                {
                    lstFabric.Clear();
                    DateTime _from = Convert.ToDateTime(txtFrom.Text);
                    DateTime _to = Convert.ToDateTime(txtTo.Text);
                    var list = (from item in _context.FabricLedger
                                where item.StyleNo == txtStyleNo.Text && item.Date >= _from && item.Date <= _to
                                select item).ToList();

                    foreach (var item in list)
                    {
                        FabricUtilizationdto dto = new FabricUtilizationdto();
                        dto.StyleNo = item.StyleRef;
                        dto.MarkerNo = item.MarkerNo;
                        dto.NoOfFlys = item.NoOfFlys;
                        dto.Date = item.Date;
                        dto.RollNo = item.RollNo;
                        dto.NotedLength = item.NotedLength;
                        dto.MarkerLength = item.MarkerLength;
                        dto.FabricUsed = item.FabricUsed;
                        dto.NotedBalance = item.NotedBalance;
                        dto.ActualBalance = item.ActualBalance;

                        if (dto.ActualBalance != 0)
                        {
                            // calcute balance shortage
                            dto.Shortage = dto.NotedBalance - dto.ActualBalance;
                        }

                        lstFabric.Add(dto);
                    }

                    report.DataSource = lstFabric;
                    report.Landscape = true;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }
                else
                {
                    lstFabric.Clear();
                  DateTime _from = Convert.ToDateTime(txtFrom.Text);
                    DateTime _to = Convert.ToDateTime(txtTo.Text);
                    var list = (from item in _context.FabricLedger
                                where item.Date >= _from && item.Date <= _to
                                select item).ToList();

                    foreach (var item in list)
                    {
                        FabricUtilizationdto dto = new FabricUtilizationdto();
                        dto.StyleNo = item.StyleRef;
                        dto.MarkerNo = item.MarkerNo;
                        dto.NoOfFlys = item.NoOfFlys;
                        dto.Date = item.Date;
                        dto.RollNo = item.RollNo;
                        dto.NotedLength = item.NotedLength;
                        dto.MarkerLength = item.MarkerLength;
                        dto.FabricUsed = item.FabricUsed;
                        dto.NotedBalance = item.NotedBalance;
                        dto.ActualBalance = item.ActualBalance;

                        if (dto.ActualBalance != 0)
                        {
                            // calcute balance shortage
                            dto.Shortage = dto.NotedBalance - dto.ActualBalance;
                        }

                        lstFabric.Add(dto);
                    }
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

        /*
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

        }  */

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            GetCuttingDetailsReport();
        }


        void searchStyle(string _key) {
            ItrackContext _context = new ItrackContext();
            var items = (from item in _context.Style
                         where item.StyleNo.Contains(_key)
                         select new { item.StyleNo, item.StyleID, item.Buyer.BuyerName, item.Remark }).ToList();

            if (items.Count > 0)
            {
                grdSearchStyle.Show();
                grdSearchStyle.DataSource = items;
            }


        }

        private void txtStyleNo_EditValueChanged(object sender, EventArgs e)
        {
            searchStyle(ID);
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

        string ID = "";
        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
               
               txtStyleNo.Text = gridView1.GetFocusedRowCellValue("StyleNo").ToString();
                ID = gridView1.GetFocusedRowCellValue("StyleID").ToString();
                grdSearchStyle.Hide();
               
            }
        }

        private void frmFabricreport_Load(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
        }
    }
}