namespace EFTesting.UI.Asset.Report
{
    partial class frmFabricConsumtionVsActual
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
            this.txtTo = new DevExpress.XtraEditors.DateEdit();
            this.txtFrom = new DevExpress.XtraEditors.DateEdit();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.chkByStyle = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllL = new DevExpress.XtraEditors.CheckEdit();
            this.chkByDate = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTo
            // 
            this.txtTo.EditValue = null;
            this.txtTo.Location = new System.Drawing.Point(234, 141);
            this.txtTo.Name = "txtTo";
            this.txtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 99;
            // 
            // txtFrom
            // 
            this.txtFrom.EditValue = null;
            this.txtFrom.Location = new System.Drawing.Point(28, 141);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Size = new System.Drawing.Size(200, 20);
            this.txtFrom.TabIndex = 98;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(231, 116);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 97;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 116);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 96;
            this.lbl1.Text = "From";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(106, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "Close";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(25, 180);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 94;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(25, 77);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(203, 20);
            this.txtStyleNo.TabIndex = 92;
            // 
            // chkByStyle
            // 
            this.chkByStyle.Location = new System.Drawing.Point(117, 27);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Properties.Caption = "By Style No";
            this.chkByStyle.Size = new System.Drawing.Size(75, 19);
            this.chkByStyle.TabIndex = 91;
            // 
            // chkAllL
            // 
            this.chkAllL.Location = new System.Drawing.Point(25, 27);
            this.chkAllL.Name = "chkAllL";
            this.chkAllL.Properties.Caption = "All";
            this.chkAllL.Size = new System.Drawing.Size(75, 19);
            this.chkAllL.TabIndex = 90;
            // 
            // chkByDate
            // 
            this.chkByDate.Location = new System.Drawing.Point(234, 27);
            this.chkByDate.Name = "chkByDate";
            this.chkByDate.Properties.Caption = "By Date";
            this.chkByDate.Size = new System.Drawing.Size(75, 19);
            this.chkByDate.TabIndex = 100;
            // 
            // frmFabricConsumtionVsActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.chkByDate);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.chkByStyle);
            this.Controls.Add(this.chkAllL);
            this.Name = "frmFabricConsumtionVsActual";
            this.Text = "FabricConsumtion Vs Actual";
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtTo;
        private DevExpress.XtraEditors.DateEdit txtFrom;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraEditors.CheckEdit chkByStyle;
        private DevExpress.XtraEditors.CheckEdit chkAllL;
        private DevExpress.XtraEditors.CheckEdit chkByDate;
    }
}