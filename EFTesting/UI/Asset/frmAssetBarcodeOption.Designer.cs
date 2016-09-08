namespace EFTesting.UI.Asset
{
    partial class frmAssetBarcodeOption
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAssetIdRange = new DevExpress.XtraEditors.CheckEdit();
            this.chkAssetID = new DevExpress.XtraEditors.CheckEdit();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            this.txtFrom = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkAssetIdRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAssetIdRange
            // 
            this.chkAssetIdRange.Location = new System.Drawing.Point(170, 26);
            this.chkAssetIdRange.Name = "chkAssetIdRange";
            this.chkAssetIdRange.Properties.Caption = "Asset ID Range";
            this.chkAssetIdRange.Size = new System.Drawing.Size(115, 19);
            this.chkAssetIdRange.TabIndex = 3;
            // 
            // chkAssetID
            // 
            this.chkAssetID.Location = new System.Drawing.Point(37, 26);
            this.chkAssetID.Name = "chkAssetID";
            this.chkAssetID.Properties.Caption = "Asset ID";
            this.chkAssetID.Size = new System.Drawing.Size(75, 19);
            this.chkAssetID.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(274, 61);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(37, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(269, 85);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(203, 20);
            this.txtTo.TabIndex = 8;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(37, 85);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(203, 20);
            this.txtFrom.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(117, 120);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 66;
            this.simpleButton1.Text = "Close";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(36, 120);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 65;
            this.simpleButton3.Text = "Print";
            // 
            // frmAssetBarcodeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 164);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.chkAssetIdRange);
            this.Controls.Add(this.chkAssetID);
            this.Name = "frmAssetBarcodeOption";
            this.Text = "frmAssetBarcodeOption";
            this.Load += new System.EventHandler(this.frmAssetBarcodeOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkAssetIdRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkAssetIdRange;
        private DevExpress.XtraEditors.CheckEdit chkAssetID;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.TextEdit txtTo;
        private DevExpress.XtraEditors.TextEdit txtFrom;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}