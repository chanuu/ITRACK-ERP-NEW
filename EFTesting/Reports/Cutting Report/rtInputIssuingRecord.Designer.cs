namespace EFTesting.Reports.Cutting_Report
{
    partial class rtInputIssuingRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtInputIssuingRecord));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldColor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLineNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldNoOfItem = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPONo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSize = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 32F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1,
            this.xrLabel31,
            this.xrLabel29,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 277.0833F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.Appearance.TotalCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldColor,
            this.fieldDate,
            this.fieldLineNo,
            this.fieldNoOfItem,
            this.fieldPONo,
            this.fieldSize,
            this.fieldStyleNo});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00008F, 98.95834F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(778.9999F, 168.125F);
            // 
            // fieldColor
            // 
            this.fieldColor.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldColor.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldColor.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldColor.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldColor.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldColor.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldColor.Appearance.TotalCell.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldColor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldColor.AreaIndex = 4;
            this.fieldColor.FieldName = "Color";
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Width = 80;
            // 
            // fieldDate
            // 
            this.fieldDate.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldDate.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.ValueFormat.FormatString = "d";
            this.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldDate.Width = 75;
            // 
            // fieldLineNo
            // 
            this.fieldLineNo.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldLineNo.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldLineNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLineNo.AreaIndex = 2;
            this.fieldLineNo.FieldName = "LineNo";
            this.fieldLineNo.Name = "fieldLineNo";
            this.fieldLineNo.Width = 70;
            // 
            // fieldNoOfItem
            // 
            this.fieldNoOfItem.Appearance.FieldValue.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldNoOfItem.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldNoOfItem.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldNoOfItem.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldNoOfItem.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldNoOfItem.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldNoOfItem.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldNoOfItem.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNoOfItem.AreaIndex = 0;
            this.fieldNoOfItem.FieldName = "NoOfItem";
            this.fieldNoOfItem.Name = "fieldNoOfItem";
            this.fieldNoOfItem.Width = 50;
            // 
            // fieldPONo
            // 
            this.fieldPONo.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldPONo.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldPONo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPONo.AreaIndex = 3;
            this.fieldPONo.FieldName = "PONo";
            this.fieldPONo.Name = "fieldPONo";
            this.fieldPONo.Width = 80;
            // 
            // fieldSize
            // 
            this.fieldSize.Appearance.CustomTotalCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldSize.Appearance.FieldHeader.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.fieldSize.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSize.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldSize.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldSize.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldSize.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldSize.Appearance.TotalCell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldSize.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSize.AreaIndex = 0;
            this.fieldSize.FieldName = "Size";
            this.fieldSize.Name = "fieldSize";
            this.fieldSize.Width = 50;
            // 
            // fieldStyleNo
            // 
            this.fieldStyleNo.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fieldStyleNo.Appearance.FieldValue.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldStyleNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo.AreaIndex = 1;
            this.fieldStyleNo.FieldName = "StyleNo";
            this.fieldStyleNo.Name = "fieldStyleNo";
            this.fieldStyleNo.Width = 80;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(142.7084F, 41.04169F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(415.2777F, 18.20835F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "GENARATED BY: ADMIN";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(142.7083F, 10.00001F);
            this.xrLabel29.Multiline = true;
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(415.2778F, 26.54169F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "INPUT ISSUING RECORD";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(118.0555F, 67.25004F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Expanded = false;
            this.GroupHeader1.HeightF = 100F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.DTOs.InputIssuingRecorddto);
            // 
            // rtInputIssuingRecord
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(28, 23, 32, 100);
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldColor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLineNo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldNoOfItem;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPONo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSize;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
    }
}
