﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EFTesting.Reports.Asset
{
    public partial class rptMachineRequrementByLine : DevExpress.XtraReports.UI.XtraReport
    {
        public rptMachineRequrementByLine()
        {
            InitializeComponent();
        }

        private void xrPivotGrid1_PrintHeader(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs e)
        {
           
        }
    }
}
