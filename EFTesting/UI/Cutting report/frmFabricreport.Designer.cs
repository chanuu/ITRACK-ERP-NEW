namespace EFTesting.UI.Cutting_report
{
    partial class frmFabricreport
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.chkByStyle = new DevExpress.XtraEditors.CheckEdit();
            this.chkDay = new DevExpress.XtraEditors.CheckEdit();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtTo = new DevExpress.XtraEditors.DateEdit();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(116, 219);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 95;
            this.simpleButton2.Text = "Close";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(35, 219);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 94;
            this.simpleButton4.Text = "Print";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // chkByStyle
            // 
            this.chkByStyle.Location = new System.Drawing.Point(127, 30);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Properties.Caption = "By Style No";
            this.chkByStyle.Size = new System.Drawing.Size(75, 19);
            this.chkByStyle.TabIndex = 89;
            // 
            // chkDay
            // 
            this.chkDay.Location = new System.Drawing.Point(35, 30);
            this.chkDay.Name = "chkDay";
            this.chkDay.Properties.Caption = "Daily ";
            this.chkDay.Size = new System.Drawing.Size(75, 19);
            this.chkDay.TabIndex = 88;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(249, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 97;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 139);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 96;
            this.lbl1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.EditValue = null;
            this.txtFrom.Location = new System.Drawing.Point(35, 167);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Size = new System.Drawing.Size(200, 20);
            this.txtFrom.TabIndex = 100;
            // 
            // txtTo
            // 
            this.txtTo.EditValue = null;
            this.txtTo.Location = new System.Drawing.Point(241, 167);
            this.txtTo.Name = "txtTo";
            this.txtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Size = new System.Drawing.Size(200, 20);
            this.txtTo.TabIndex = 101;
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(35, 98);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(200, 20);
            this.txtStyleNo.TabIndex = 102;
            this.txtStyleNo.EditValueChanged += new System.EventHandler(this.txtStyleNo_EditValueChanged);
            this.txtStyleNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStyleNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Style No";
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(24, 124);
            this.grdSearchStyle.MainView = this.gridView1;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(993, 258);
            this.grdSearchStyle.TabIndex = 104;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearchStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchStyle_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearchStyle;
            this.gridView1.Name = "gridView1";
            // 
            // frmFabricreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 433);
            this.Controls.Add(this.grdSearchStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStyleNo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.chkByStyle);
            this.Controls.Add(this.chkDay);
            this.Name = "frmFabricreport";
            this.Text = "Fabric Consumtion Report";
            this.Load += new System.EventHandler(this.frmFabricreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.CheckEdit chkByStyle;
        private DevExpress.XtraEditors.CheckEdit chkDay;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.DateEdit txtFrom;
        private DevExpress.XtraEditors.DateEdit txtTo;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}