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
using DevExpress.Office.Utils;
using System.Diagnostics;
using ITRACK.models;
using EFTesting.DTOs;

namespace EFTesting.UI
{
    public partial class frmBundlePrintoption : DevExpress.XtraEditors.XtraForm
    {
        public frmBundlePrintoption()
        {
            InitializeComponent();
        }

        private void chkCutId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCutId.Checked == true) {
                lbl1.Text = "Cut ID";
                lbl2.Hide();
                txtTo.Hide();
            }
        }

        frmPrintBarcode _barcode = new frmPrintBarcode();
        private void printBarcode() {

            splashScreenManager1.ShowWaitForm();
            if (chkCutId.Checked == true)
            {

                _barcode.Options = 1;
                _barcode.CutNo = Convert.ToInt32(txtFrom.Text);
            }
            else if (chkCutIdRange.Checked == true)
            {
                _barcode.Options = 2;
                _barcode.From = Convert.ToInt32(txtFrom.Text);
                _barcode.To = Convert.ToInt32(txtTo.Text);
            }
            else if (chkBundleRange.Checked == true) {
                _barcode.Options = 3;
                _barcode.From = Convert.ToInt32(txtFrom.Text);
                _barcode.To = Convert.ToInt32(txtTo.Text);
            } else if (chkCutIssueSticker.Checked == true)
            {
                _barcode.From = Convert.ToInt32(txtFrom.Text);
                _barcode.To = Convert.ToInt32(txtTo.Text);
               

            }
           
                splashScreenManager1.CloseWaitForm();

            if(chkCutIssueSticker.Checked == true)
            {
                FeedCutIssueSticker(_barcode.From, _barcode.To);
            }
            else
            {
                PrintBarcode(_barcode);
            }
                

           
           
        

        }





        void FeedCutIssueSticker(int _from,int _to) {
            try {



                ItrackContext _con = new ItrackContext();

                /*   var items = (from item in _con.CuttingItem
                                where item.BundleHeader >= _from && item.CuttingItemID < _to
                                select item
                                ).ToList();
                                */

                List<CutIssueDto> lstDto = new List<CutIssueDto>();
               


                var items = (from item in _con.BundleDetails
                             where item.BundleHeaderID >= _from && item.BundleHeaderID <= _to
                             select item).ToList();


                foreach(var rows in items)
                {
                    CutIssueDto _dto = new CutIssueDto();
                    _dto.PoNo = rows.BundleHeader.CuttingItem.CuttingHeader.Style.StyleNo;
                    _dto.CutNo = rows.BundleHeader.CuttingItem.CutNo;
                    _dto.MarkerNo = rows.BundleHeader.CuttingItem.MarkerNo;
                    _dto.NoOfItem =Convert.ToInt16( rows.BundleHeader.CuttingItem.NoOfItem);
                    _dto.Color = rows.BundleHeader.CuttingItem.Color;
                    lstDto.Add(_dto);

                }


                rptCutIssue lbl = new rptCutIssue();
                lbl.DataSource = lstDto.GroupBy(x => x.CutNo)
      .Select(g => g.First());
                ReportPrintTool tool = new ReportPrintTool(lbl);
                tool.ShowPreview();


            }
            catch (Exception ex) {

            }

        }


         void PrintBarcode(frmPrintBarcode _barcode) {
            try 
            {
                InitializeComponent();
                splashScreenManager1.ShowWaitForm();
                
                //sBundleTicket report = new sBundleTicket();
                //rptBarcodeList s = new rptBarcodeList();
               OprationBarcodeList list = new OprationBarcodeList();

               //report.SetDataSource(list.StickerBarcodeList(pBarocde.Options, pBarocde.CutNo, pBarocde.From, pBarocde.To));

               //this.crystalReportViewer1.ReportSource = report;

                BarcodeLabel lbl = new BarcodeLabel();
                lbl.DataSource = list.StickerBarcodeList(_barcode.Options, _barcode.CutNo, _barcode.From, _barcode.To);
                lbl.CreateDocument();
                XtraReport report = new XtraReport();
                report.PrintingSystem.ContinuousPageNumbering = false;

                int pageCount = lbl.Pages.Count;

                for (int i = lbl.Pages.Count; i > 0; i--)
                {
                    report.Pages.Add(lbl.Pages[i - 1]);
                }

                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();


                splashScreenManager1.CloseWaitForm();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.Message);
            }
           
          
          
        }
        private void chkCutIdRange_CheckedChanged(object sender, EventArgs e)
        {
            txtTo.Show();
            lbl2.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            printBarcode();
        }

        private void frmBundlePrintoption_Load(object sender, EventArgs e)
        {

        }
    }
}