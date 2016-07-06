namespace EFTesting.Reports.Asset
{
    partial class rptMachineRequrementByLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptMachineRequrementByLine));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldLocation1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStartDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEndDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldType1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldMachineType1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 9.375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 54.16667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldLocation1,
            this.fieldStyleNo1,
            this.fieldStartDate1,
            this.fieldEndDate1,
            this.fieldType1,
            this.fieldMachineType1,
            this.fieldQty1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(9.999879F, 102.7083F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(991.0001F, 203.9583F);
            this.xrPivotGrid1.PrintHeader += new System.EventHandler<DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs>(this.xrPivotGrid1_PrintHeader);
            // 
            // fieldLocation1
            // 
            this.fieldLocation1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldLocation1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldLocation1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLocation1.AreaIndex = 0;
            this.fieldLocation1.FieldName = "Location";
            this.fieldLocation1.Name = "fieldLocation1";
            // 
            // fieldStyleNo1
            // 
            this.fieldStyleNo1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldStyleNo1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldStyleNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo1.AreaIndex = 1;
            this.fieldStyleNo1.FieldName = "StyleNo";
            this.fieldStyleNo1.Name = "fieldStyleNo1";
            // 
            // fieldStartDate1
            // 
            this.fieldStartDate1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldStartDate1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldStartDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStartDate1.AreaIndex = 3;
            this.fieldStartDate1.FieldName = "StartDate";
            this.fieldStartDate1.Name = "fieldStartDate1";
            this.fieldStartDate1.ValueFormat.FormatString = "d";
            this.fieldStartDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldEndDate1
            // 
            this.fieldEndDate1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldEndDate1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldEndDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEndDate1.AreaIndex = 4;
            this.fieldEndDate1.FieldName = "EndDate";
            this.fieldEndDate1.Name = "fieldEndDate1";
            this.fieldEndDate1.ValueFormat.FormatString = "d";
            this.fieldEndDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldType1
            // 
            this.fieldType1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldType1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldType1.AreaIndex = 2;
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            // 
            // fieldMachineType1
            // 
            this.fieldMachineType1.Appearance.Cell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldMachineType1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldMachineType1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldMachineType1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMachineType1.AreaIndex = 0;
            this.fieldMachineType1.FieldName = "MachineType";
            this.fieldMachineType1.Name = "fieldMachineType1";
            this.fieldMachineType1.Width = 250;
            // 
            // fieldQty1
            // 
            this.fieldQty1.Appearance.Cell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldQty1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldQty1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 0;
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 82.95835F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(152.0832F, 9.999974F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(465.625F, 40.70834F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "MACHINE REQUIREMENT";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999879F, 9.999974F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(120.75F, 66.41235F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(233.3332F, 50.70832F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(181.25F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(152.0832F, 50.70832F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(81.25F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "GENARATED AT";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel2,
            this.xrPageInfo1,
            this.xrLabel3,
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 419.7917F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.DTOs.MachineRequirementReportDto);
            // 
            // rptMachineRequrementByLine
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(50, 49, 54, 83);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLocation1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStartDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEndDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldType1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMachineType1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQty1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
