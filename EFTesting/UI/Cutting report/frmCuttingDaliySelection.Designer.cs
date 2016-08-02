namespace EFTesting.UI.Cutting_report
{
    partial class frmCuttingDaliySelection
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.chkByPo = new DevExpress.XtraEditors.CheckEdit();
            this.chkDayCut = new DevExpress.XtraEditors.CheckEdit();
            this.txtPoNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.chkByStyle = new DevExpress.XtraEditors.CheckEdit();
            this.txtTo = new DevExpress.XtraEditors.DateEdit();
            this.txtFrom = new DevExpress.XtraEditors.DateEdit();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EFTesting.UI.WaitForm1), true, true, true);
            ((System.ComponentModel.ISupportInitialize)(this.chkByPo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayCut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(109, 196);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 74;
            this.simpleButton1.Text = "Close";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(28, 196);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 73;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // chkByPo
            // 
            this.chkByPo.Location = new System.Drawing.Point(224, 34);
            this.chkByPo.Name = "chkByPo";
            this.chkByPo.Properties.Caption = "By Po";
            this.chkByPo.Size = new System.Drawing.Size(115, 19);
            this.chkByPo.TabIndex = 67;
            // 
            // chkDayCut
            // 
            this.chkDayCut.Location = new System.Drawing.Point(31, 34);
            this.chkDayCut.Name = "chkDayCut";
            this.chkDayCut.Properties.Caption = "Daily Cut";
            this.chkDayCut.Size = new System.Drawing.Size(75, 19);
            this.chkDayCut.TabIndex = 66;
            // 
            // txtPoNo
            // 
            this.txtPoNo.Location = new System.Drawing.Point(240, 82);
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Size = new System.Drawing.Size(203, 20);
            this.txtPoNo.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Po No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(28, 82);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(203, 20);
            this.txtStyleNo.TabIndex = 77;
            // 
            // chkByStyle
            // 
            this.chkByStyle.Location = new System.Drawing.Point(123, 34);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Properties.Caption = "By Style No";
            this.chkByStyle.Size = new System.Drawing.Size(75, 19);
            this.chkByStyle.TabIndex = 79;
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
            this.txtTo.TabIndex = 105;
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
            this.txtFrom.TabIndex = 104;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(242, 117);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 103;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 113);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 102;
            this.lbl1.Text = "From";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmCuttingDaliySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 485);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chkByStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoNo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.chkByPo);
            this.Controls.Add(this.chkDayCut);
            this.Name = "frmCuttingDaliySelection";
            this.Text = "Day Cut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chkByPo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDayCut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.CheckEdit chkByPo;
        private DevExpress.XtraEditors.CheckEdit chkDayCut;
        private DevExpress.XtraEditors.TextEdit txtPoNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraEditors.CheckEdit chkByStyle;
        private DevExpress.XtraEditors.DateEdit txtTo;
        private DevExpress.XtraEditors.DateEdit txtFrom;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}