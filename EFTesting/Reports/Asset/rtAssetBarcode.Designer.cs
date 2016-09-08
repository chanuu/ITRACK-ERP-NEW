namespace EFTesting.Reports.Asset
{
    partial class rtAssetBarcode
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtAssetBarcode));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 390F;
            this.Detail.MultiColumn.ColumnSpacing = 40F;
            this.Detail.MultiColumn.ColumnWidth = 550F;
            this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.CanGrow = false;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5,
            this.xrBarCode1,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrRichText1,
            this.xrRichText2,
            this.xrRichText3,
            this.xrRichText4});
            this.xrPanel1.Dpi = 254F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(550F, 370F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AssetBarcodeID")});
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 326.58F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(254F, 33.42001F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AssetBarcodeID")});
            this.xrBarCode1.Dpi = 254F;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 170.6152F);
            this.xrBarCode1.Module = 5.08F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(512.9134F, 150.0065F);
            this.xrBarCode1.StylePriority.UseBorders = false;
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomField4")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(180.403F, 126.9262F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(350.597F, 33.28459F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomField2")});
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(180.403F, 88.13253F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(350.597F, 33.2846F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomField3")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(180.403F, 49.84795F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(350.597F, 33.28459F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomField1")});
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(180.403F, 11.62918F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(350.597F, 33.28459F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrRichText1
            // 
            this.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText1.Dpi = 254F;
            this.xrRichText1.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 11.62918F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(149.4896F, 33.28459F);
            this.xrRichText1.StylePriority.UseBorders = false;
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrRichText2
            // 
            this.xrRichText2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText2.Dpi = 254F;
            this.xrRichText2.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 49.84795F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(149.4896F, 33.28459F);
            this.xrRichText2.StylePriority.UseBorders = false;
            this.xrRichText2.StylePriority.UseFont = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText3.Dpi = 254F;
            this.xrRichText3.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 88.13253F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(149.4896F, 33.28459F);
            this.xrRichText3.StylePriority.UseBorders = false;
            this.xrRichText3.StylePriority.UseFont = false;
            // 
            // xrRichText4
            // 
            this.xrRichText4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText4.Dpi = 254F;
            this.xrRichText4.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(18.08649F, 126.9262F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(149.4896F, 33.28459F);
            this.xrRichText4.StylePriority.UseBorders = false;
            this.xrRichText4.StylePriority.UseFont = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText5,
            this.xrRichText6});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 430F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrRichText5
            // 
            this.xrRichText5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText5.Dpi = 254F;
            this.xrRichText5.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(354.1455F, 117.9563F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(1233.709F, 117.1602F);
            this.xrRichText5.StylePriority.UseBorders = false;
            this.xrRichText5.StylePriority.UseFont = false;
            // 
            // xrRichText6
            // 
            this.xrRichText6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText6.Dpi = 254F;
            this.xrRichText6.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(502.3122F, 236.1164F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(871.2295F, 76.92722F);
            this.xrRichText6.StylePriority.UseBorders = false;
            this.xrRichText6.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ITRACK.models.AssetBarcode);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AlternetAsset")});
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(277F, 325.6216F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(254F, 34.3783F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // rtAssetBarcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataSource = this.bindingSource1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(130, 0, 430, 0);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = 18;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.XRRichText xrRichText4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText5;
        private DevExpress.XtraReports.UI.XRRichText xrRichText6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    }
}
