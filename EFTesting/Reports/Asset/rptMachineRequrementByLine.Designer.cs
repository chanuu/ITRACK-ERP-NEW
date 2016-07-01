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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldCompanyName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLocation1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStartDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldEndDate1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldType1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldMachineType1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQty1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
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
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.TopMargin.HeightF = 245.8333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 82.95835F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldCompanyName1,
            this.fieldLocation1,
            this.fieldStyleNo1,
            this.fieldStartDate1,
            this.fieldEndDate1,
            this.fieldType1,
            this.fieldMachineType1,
            this.fieldQty1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 43.33334F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(991.0001F, 192.5F);
            // 
            // fieldCompanyName1
            // 
            this.fieldCompanyName1.AreaIndex = 0;
            this.fieldCompanyName1.FieldName = "CompanyName";
            this.fieldCompanyName1.Name = "fieldCompanyName1";
            // 
            // fieldLocation1
            // 
            this.fieldLocation1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLocation1.AreaIndex = 0;
            this.fieldLocation1.FieldName = "Location";
            this.fieldLocation1.Name = "fieldLocation1";
            // 
            // fieldStyleNo1
            // 
            this.fieldStyleNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo1.AreaIndex = 2;
            this.fieldStyleNo1.FieldName = "StyleNo";
            this.fieldStyleNo1.Name = "fieldStyleNo1";
            // 
            // fieldStartDate1
            // 
            this.fieldStartDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStartDate1.AreaIndex = 3;
            this.fieldStartDate1.FieldName = "StartDate";
            this.fieldStartDate1.Name = "fieldStartDate1";
            // 
            // fieldEndDate1
            // 
            this.fieldEndDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEndDate1.AreaIndex = 4;
            this.fieldEndDate1.FieldName = "EndDate";
            this.fieldEndDate1.Name = "fieldEndDate1";
            // 
            // fieldType1
            // 
            this.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldType1.AreaIndex = 1;
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            // 
            // fieldMachineType1
            // 
            this.fieldMachineType1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMachineType1.AreaIndex = 0;
            this.fieldMachineType1.FieldName = "MachineType";
            this.fieldMachineType1.Name = "fieldMachineType1";
            // 
            // fieldQty1
            // 
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 0;
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
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
            this.BottomMargin});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(50, 49, 246, 83);
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
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCompanyName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLocation1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStartDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldEndDate1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldType1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMachineType1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQty1;
    }
}
