using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using System.Data;

namespace EFTesting.Reports
{
    public partial class rptLedgerByPo : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLedgerByPo()
        {
            InitializeComponent();
        }

        private void xrLabel21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrTableCell2_PreviewClick(object sender, PreviewMouseEventArgs e)
        {


            Debug.WriteLine(xrTableCell2.Text);
            XRLabel label = e.Brick.BrickOwner as XRLabel;
            string fieldName = label.DataBindings[0].DataMember.ToString();
            Debug.WriteLine(fieldName);

        }
    }
}
