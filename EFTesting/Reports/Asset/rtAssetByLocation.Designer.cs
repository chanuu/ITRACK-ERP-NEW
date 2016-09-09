namespace EFTesting.Reports.Asset
{
    partial class rtAssetByLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtAssetByLocation));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrRichText10 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText11 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fieldModel1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldAssetLocation1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldAvailable1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 1.041667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10.41667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 5.208333F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel2,
            this.xrPictureBox1,
            this.xrRichText10,
            this.xrRichText11,
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 368.75F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(665.6665F, 64.2532F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(210.7501F, 14F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Report Generated Based On Stock Verification at:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(645.8334F, 36.31198F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(231.5834F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Report Generated Based On Stock Verification at:";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Date")});
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(877.4168F, 36.31198F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(124.9998F, 14F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "txtDate";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AssetVerificationNo")});
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(876.4166F, 64.2532F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(126F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 22.12715F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(120.75F, 66.41235F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrRichText10
            // 
            this.xrRichText10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText10.LocationFloat = new DevExpress.Utils.PointFloat(95.04164F, 22.12715F);
            this.xrRichText10.Name = "xrRichText10";
            this.xrRichText10.SerializableRtfString = resources.GetString("xrRichText10.SerializableRtfString");
            this.xrRichText10.SizeF = new System.Drawing.SizeF(441.5834F, 46.12607F);
            this.xrRichText10.StylePriority.UseBorders = false;
            this.xrRichText10.StylePriority.UseFont = false;
            // 
            // xrRichText11
            // 
            this.xrRichText11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText11.LocationFloat = new DevExpress.Utils.PointFloat(113.4999F, 64.2532F);
            this.xrRichText11.Name = "xrRichText11";
            this.xrRichText11.SerializableRtfString = resources.GetString("xrRichText11.SerializableRtfString");
            this.xrRichText11.SizeF = new System.Drawing.SizeF(333.2499F, 30.2863F);
            this.xrRichText11.StylePriority.UseBorders = false;
            this.xrRichText11.StylePriority.UseFont = false;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8F);
            this.xrPivotGrid1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValueTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValueTotal.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Calibri", 8F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.GrandTotalCell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldModel1,
            this.fieldAssetLocation1,
            this.fieldAvailable1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 108.0812F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1053F, 197.5F);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.UI.DTO.AssetVerificationLocationdto);
            // 
            // fieldModel1
            // 
            this.fieldModel1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.CustomTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldModel1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldModel1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldModel1.Appearance.FieldValueGrandTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldModel1.Appearance.FieldValueTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldModel1.Appearance.GrandTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldModel1.Appearance.TotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldModel1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldModel1.AreaIndex = 0;
            this.fieldModel1.FieldName = "Model";
            this.fieldModel1.Name = "fieldModel1";
            this.fieldModel1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldAssetLocation1
            // 
            this.fieldAssetLocation1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAssetLocation1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAssetLocation1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAssetLocation1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAssetLocation1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAssetLocation1.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAssetLocation1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAssetLocation1.AreaIndex = 0;
            this.fieldAssetLocation1.FieldName = "AssetLocation";
            this.fieldAssetLocation1.GrandTotalText = "Total";
            this.fieldAssetLocation1.Name = "fieldAssetLocation1";
            this.fieldAssetLocation1.Width = 50;
            // 
            // fieldAvailable1
            // 
            this.fieldAvailable1.Appearance.Cell.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAvailable1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAvailable1.Appearance.CustomTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.CustomTotalCell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldAvailable1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAvailable1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldAvailable1.Appearance.FieldValueGrandTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValueGrandTotal.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAvailable1.Appearance.FieldValueTotal.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.FieldValueTotal.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.fieldAvailable1.Appearance.GrandTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.GrandTotalCell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Appearance.TotalCell.Font = new System.Drawing.Font("Calibri", 8F);
            this.fieldAvailable1.Appearance.TotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldAvailable1.Appearance.TotalCell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldAvailable1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldAvailable1.AreaIndex = 0;
            this.fieldAvailable1.FieldName = "Available";
            this.fieldAvailable1.Name = "fieldAvailable1";
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrPageInfo1,
            this.xrLabel32,
            this.xrLabel33});
            this.ReportFooter.HeightF = 131.25F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(22.04164F, 75.95831F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(186.4583F, 23F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "REPORT GENARATED AT";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(208.4999F, 75.95831F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(175F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(22.04164F, 98.95834F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(186.4583F, 23F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "BY ITRACK ERP - VTW";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(732.8749F, 75.95831F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(302.1668F, 23F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "ALL RIGHT RESERVED COPY RIGHTS 2016";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rtAssetByLocation
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(21, 24, 10, 5);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldModel1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAssetLocation1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldAvailable1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText10;
        private DevExpress.XtraReports.UI.XRRichText xrRichText11;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
    }
}
