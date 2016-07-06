namespace EFTesting.UI.Asset.Report
{
    partial class frmMachineRequirement
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
            this.chkByStyle = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllLine = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtTo = new DevExpress.XtraEditors.DateEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkByStyle
            // 
            this.chkByStyle.Location = new System.Drawing.Point(121, 36);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Properties.Caption = "By Style No";
            this.chkByStyle.Size = new System.Drawing.Size(75, 19);
            this.chkByStyle.TabIndex = 81;
            // 
            // chkAllLine
            // 
            this.chkAllLine.Location = new System.Drawing.Point(29, 36);
            this.chkAllLine.Name = "chkAllLine";
            this.chkAllLine.Properties.Caption = "All Lines";
            this.chkAllLine.Size = new System.Drawing.Size(75, 19);
            this.chkAllLine.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(29, 86);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(203, 20);
            this.txtStyleNo.TabIndex = 82;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(110, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Close";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(29, 189);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 84;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(235, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 87;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 125);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 86;
            this.lbl1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.EditValue = null;
            this.txtFrom.Location = new System.Drawing.Point(32, 150);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Size = new System.Drawing.Size(200, 20);
            this.txtFrom.TabIndex = 88;
            // 
            // txtTo
            // 
            this.txtTo.EditValue = null;
            this.txtTo.Location = new System.Drawing.Point(238, 150);
            this.txtTo.Name = "txtTo";
            this.txtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 89;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMachineRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 407);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.chkByStyle);
            this.Controls.Add(this.chkAllLine);
            this.Name = "frmMachineRequirement";
            this.Text = "Machine Requirement Options";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMachineRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkByStyle;
        private DevExpress.XtraEditors.CheckEdit chkAllLine;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.DateEdit txtFrom;
        private DevExpress.XtraEditors.DateEdit txtTo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}