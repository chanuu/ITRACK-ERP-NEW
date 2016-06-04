namespace EFTesting.UI
{
    partial class frmCuttingStatus
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCuttingStock = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label24 = new System.Windows.Forms.Label();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtToDate = new DevExpress.XtraEditors.DateEdit();
            this.txtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EFTesting.UI.WaitForm1), true, true);
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuttingStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton3.Location = new System.Drawing.Point(286, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 39);
            this.simpleButton3.TabIndex = 71;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(196, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(104, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Save";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(13, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 70;
            this.btnNew.Text = "New";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.txtDate);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.grdCuttingStock);
            this.xtraTabPage2.Controls.Add(this.label24);
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1165, 442);
            this.xtraTabPage2.Text = "Marker ";
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(36, 54);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(191, 20);
            this.txtDate.TabIndex = 92;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(233, 52);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 91;
            this.simpleButton2.Text = "Refresh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date";
            // 
            // grdCuttingStock
            // 
            this.grdCuttingStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCuttingStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCuttingStock.Location = new System.Drawing.Point(36, 80);
            this.grdCuttingStock.MainView = this.gridView1;
            this.grdCuttingStock.Name = "grdCuttingStock";
            this.grdCuttingStock.Size = new System.Drawing.Size(1083, 334);
            this.grdCuttingStock.TabIndex = 88;
            this.grdCuttingStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCuttingStock;
            this.gridView1.Name = "gridView1";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdCuttingStock;
            this.gridView4.Name = "gridView4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(67, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(167, 13);
            this.label24.TabIndex = 85;
            this.label24.Text = "Marker Details and Layer Details  ";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearchStyle;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(57, 88);
            this.grdSearchStyle.MainView = this.gridView2;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(1083, 334);
            this.grdSearchStyle.TabIndex = 1;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSearchStyle;
            this.gridView3.Name = "gridView3";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtToDate);
            this.xtraTabPage1.Controls.Add(this.txtFromDate);
            this.xtraTabPage1.Controls.Add(this.btnRefresh);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.grdSearchStyle);
            this.xtraTabPage1.Controls.Add(this.label23);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1165, 442);
            this.xtraTabPage1.Text = "Header";
            // 
            // txtToDate
            // 
            this.txtToDate.EditValue = null;
            this.txtToDate.Location = new System.Drawing.Point(451, 62);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtToDate.Size = new System.Drawing.Size(191, 20);
            this.txtToDate.TabIndex = 57;
            // 
            // txtFromDate
            // 
            this.txtFromDate.EditValue = null;
            this.txtFromDate.Location = new System.Drawing.Point(254, 62);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Size = new System.Drawing.Size(191, 20);
            this.txtFromDate.TabIndex = 56;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(648, 59);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "To Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "From Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(54, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(185, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Cutting Status / Daliy Cutting Figures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(57, 62);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Cutting Ticket";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(191, 20);
            this.txtStyleNo.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 68);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1204, 448);
            this.xtraTabControl1.TabIndex = 72;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // frmCuttingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 528);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmCuttingStatus";
            this.Text = "Cutting Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuttingStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.DateEdit txtToDate;
        private DevExpress.XtraEditors.DateEdit txtFromDate;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl grdCuttingStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}