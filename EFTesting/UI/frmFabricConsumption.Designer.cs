namespace EFTesting.UI
{
    partial class frmFabricConsumption
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
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.txtAvailBal = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEditFabric = new DevExpress.XtraEditors.SimpleButton();
            this.grdFabricDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label33 = new System.Windows.Forms.Label();
            this.txtActualBalance = new DevExpress.XtraEditors.TextEdit();
            this.label32 = new System.Windows.Forms.Label();
            this.txtFabused = new DevExpress.XtraEditors.TextEdit();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNotedBalance = new DevExpress.XtraEditors.TextEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.txtNoOfPlys = new DevExpress.XtraEditors.TextEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.txtRollHegiht = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.txtRollWidth = new DevExpress.XtraEditors.TextEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRoleNo = new DevExpress.XtraEditors.TextEdit();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAddFabric = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            this.txtFrom = new DevExpress.XtraEditors.TextEdit();
            this.chkByStyle = new DevExpress.XtraEditors.CheckEdit();
            this.chkDay = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAvailBal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFabricDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabused.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotedBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfPlys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollHegiht.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleNo.Properties)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(10, 53);
            this.grdSearch.MainView = this.gridView3;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(1085, 400);
            this.grdSearch.TabIndex = 71;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSearch;
            this.gridView3.Name = "gridView3";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(571, 23);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 68;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton3.Location = new System.Drawing.Point(385, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 39);
            this.simpleButton3.TabIndex = 72;
            this.simpleButton3.Text = "Print";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(295, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(862, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 69;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(475, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(204, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(112, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(21, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 70;
            this.btnNew.Text = "New";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 57);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(1171, 460);
            this.xtraTabControl1.TabIndex = 73;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.grdSearchStyle);
            this.xtraTabPage3.Controls.Add(this.label1);
            this.xtraTabPage3.Controls.Add(this.txtStyleNo);
            this.xtraTabPage3.Controls.Add(this.label37);
            this.xtraTabPage3.Controls.Add(this.txtAvailBal);
            this.xtraTabPage3.Controls.Add(this.simpleButton5);
            this.xtraTabPage3.Controls.Add(this.txtMNo);
            this.xtraTabPage3.Controls.Add(this.btnEditFabric);
            this.xtraTabPage3.Controls.Add(this.grdFabricDetails);
            this.xtraTabPage3.Controls.Add(this.label33);
            this.xtraTabPage3.Controls.Add(this.txtActualBalance);
            this.xtraTabPage3.Controls.Add(this.label32);
            this.xtraTabPage3.Controls.Add(this.txtFabused);
            this.xtraTabPage3.Controls.Add(this.label31);
            this.xtraTabPage3.Controls.Add(this.txtNotedBalance);
            this.xtraTabPage3.Controls.Add(this.label30);
            this.xtraTabPage3.Controls.Add(this.txtNoOfPlys);
            this.xtraTabPage3.Controls.Add(this.label28);
            this.xtraTabPage3.Controls.Add(this.txtRollHegiht);
            this.xtraTabPage3.Controls.Add(this.label27);
            this.xtraTabPage3.Controls.Add(this.txtRollWidth);
            this.xtraTabPage3.Controls.Add(this.label26);
            this.xtraTabPage3.Controls.Add(this.txtRoleNo);
            this.xtraTabPage3.Controls.Add(this.label29);
            this.xtraTabPage3.Controls.Add(this.label25);
            this.xtraTabPage3.Controls.Add(this.btnAddFabric);
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1132, 454);
            this.xtraTabPage3.Text = "F/Consumption";
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(45, 70);
            this.grdSearchStyle.MainView = this.gridView2;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(1006, 325);
            this.grdSearchStyle.TabIndex = 114;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdSearchStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchStyle_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearchStyle;
            this.gridView2.Name = "gridView2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(46, 47);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(183, 20);
            this.txtStyleNo.TabIndex = 112;
            this.txtStyleNo.EditValueChanged += new System.EventHandler(this.txtStyleNo_EditValueChanged);
            this.txtStyleNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStyleNo_KeyDown);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(627, 28);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 13);
            this.label37.TabIndex = 111;
            this.label37.Text = "Avail Balance";
            // 
            // txtAvailBal
            // 
            this.txtAvailBal.EditValue = "";
            this.txtAvailBal.Location = new System.Drawing.Point(633, 47);
            this.txtAvailBal.Name = "txtAvailBal";
            this.txtAvailBal.Properties.AccessibleDescription = "";
            this.txtAvailBal.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtAvailBal.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtAvailBal.Size = new System.Drawing.Size(204, 20);
            this.txtAvailBal.TabIndex = 110;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(221, 124);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 109;
            this.simpleButton5.Text = "Print";
            // 
            // txtMNo
            // 
            this.txtMNo.Location = new System.Drawing.Point(235, 47);
            this.txtMNo.Name = "txtMNo";
            this.txtMNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMNo.Size = new System.Drawing.Size(179, 20);
            this.txtMNo.TabIndex = 108;
            // 
            // btnEditFabric
            // 
            this.btnEditFabric.Location = new System.Drawing.Point(135, 124);
            this.btnEditFabric.Name = "btnEditFabric";
            this.btnEditFabric.Size = new System.Drawing.Size(75, 23);
            this.btnEditFabric.TabIndex = 107;
            this.btnEditFabric.Text = "Edit";
            // 
            // grdFabricDetails
            // 
            this.grdFabricDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFabricDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdFabricDetails.Location = new System.Drawing.Point(48, 160);
            this.grdFabricDetails.MainView = this.gridView4;
            this.grdFabricDetails.Name = "grdFabricDetails";
            this.grdFabricDetails.Size = new System.Drawing.Size(1063, 284);
            this.grdFabricDetails.TabIndex = 106;
            this.grdFabricDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdFabricDetails;
            this.gridView4.Name = "gridView4";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(629, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 13);
            this.label33.TabIndex = 105;
            this.label33.Text = "Actual Balance";
            // 
            // txtActualBalance
            // 
            this.txtActualBalance.EditValue = "";
            this.txtActualBalance.Location = new System.Drawing.Point(631, 89);
            this.txtActualBalance.Name = "txtActualBalance";
            this.txtActualBalance.Properties.AccessibleDescription = "";
            this.txtActualBalance.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtActualBalance.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtActualBalance.Size = new System.Drawing.Size(206, 20);
            this.txtActualBalance.TabIndex = 104;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(843, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 103;
            this.label32.Text = "Fab Used";
            // 
            // txtFabused
            // 
            this.txtFabused.EditValue = "";
            this.txtFabused.Location = new System.Drawing.Point(845, 89);
            this.txtFabused.Name = "txtFabused";
            this.txtFabused.Properties.AccessibleDescription = "";
            this.txtFabused.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtFabused.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtFabused.Size = new System.Drawing.Size(206, 20);
            this.txtFabused.TabIndex = 102;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(416, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 13);
            this.label31.TabIndex = 101;
            this.label31.Text = "Noted Balance";
            // 
            // txtNotedBalance
            // 
            this.txtNotedBalance.EditValue = "";
            this.txtNotedBalance.Location = new System.Drawing.Point(418, 89);
            this.txtNotedBalance.Name = "txtNotedBalance";
            this.txtNotedBalance.Properties.AccessibleDescription = "";
            this.txtNotedBalance.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtNotedBalance.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNotedBalance.Size = new System.Drawing.Size(206, 20);
            this.txtNotedBalance.TabIndex = 100;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(229, 70);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 13);
            this.label30.TabIndex = 99;
            this.label30.Text = "No Of Plys";
            // 
            // txtNoOfPlys
            // 
            this.txtNoOfPlys.EditValue = "";
            this.txtNoOfPlys.Location = new System.Drawing.Point(231, 89);
            this.txtNoOfPlys.Name = "txtNoOfPlys";
            this.txtNoOfPlys.Properties.AccessibleDescription = "";
            this.txtNoOfPlys.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtNoOfPlys.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNoOfPlys.Size = new System.Drawing.Size(183, 20);
            this.txtNoOfPlys.TabIndex = 98;
            this.txtNoOfPlys.Leave += new System.EventHandler(this.txtNoOfPlys_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(843, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 13);
            this.label28.TabIndex = 97;
            this.label28.Text = "Fabric Roll Length";
            // 
            // txtRollHegiht
            // 
            this.txtRollHegiht.EditValue = "";
            this.txtRollHegiht.Location = new System.Drawing.Point(845, 47);
            this.txtRollHegiht.Name = "txtRollHegiht";
            this.txtRollHegiht.Properties.AccessibleDescription = "";
            this.txtRollHegiht.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtRollHegiht.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRollHegiht.Size = new System.Drawing.Size(206, 20);
            this.txtRollHegiht.TabIndex = 96;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(43, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 95;
            this.label27.Text = "Marker Length";
            // 
            // txtRollWidth
            // 
            this.txtRollWidth.EditValue = "";
            this.txtRollWidth.Location = new System.Drawing.Point(46, 89);
            this.txtRollWidth.Name = "txtRollWidth";
            this.txtRollWidth.Properties.AccessibleDescription = "";
            this.txtRollWidth.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtRollWidth.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRollWidth.Size = new System.Drawing.Size(183, 20);
            this.txtRollWidth.TabIndex = 94;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(418, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 13);
            this.label26.TabIndex = 93;
            this.label26.Text = "Fabric Roll No";
            // 
            // txtRoleNo
            // 
            this.txtRoleNo.EditValue = "";
            this.txtRoleNo.Location = new System.Drawing.Point(420, 49);
            this.txtRoleNo.Name = "txtRoleNo";
            this.txtRoleNo.Properties.AccessibleDescription = "";
            this.txtRoleNo.Properties.NullValuePrompt = "Please Enter Markr Number";
            this.txtRoleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRoleNo.Size = new System.Drawing.Size(206, 20);
            this.txtRoleNo.TabIndex = 92;
            this.txtRoleNo.Leave += new System.EventHandler(this.txtRoleNo_Leave);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(232, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 91;
            this.label29.Text = "Marker No";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(46, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(164, 13);
            this.label25.TabIndex = 86;
            this.label25.Text = "Laying Details / Fabric Roll Entry ";
            // 
            // btnAddFabric
            // 
            this.btnAddFabric.Location = new System.Drawing.Point(49, 124);
            this.btnAddFabric.Name = "btnAddFabric";
            this.btnAddFabric.Size = new System.Drawing.Size(75, 23);
            this.btnAddFabric.TabIndex = 2;
            this.btnAddFabric.Text = "Add";
            this.btnAddFabric.Click += new System.EventHandler(this.btnAddFabric_Click);
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.simpleButton2);
            this.xtraTabPage5.Controls.Add(this.simpleButton4);
            this.xtraTabPage5.Controls.Add(this.lbl2);
            this.xtraTabPage5.Controls.Add(this.lbl1);
            this.xtraTabPage5.Controls.Add(this.txtTo);
            this.xtraTabPage5.Controls.Add(this.txtFrom);
            this.xtraTabPage5.Controls.Add(this.chkByStyle);
            this.xtraTabPage5.Controls.Add(this.chkDay);
            this.xtraTabPage5.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1132, 454);
            this.xtraTabPage5.Text = "Reports";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(138, 171);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 87;
            this.simpleButton2.Text = "Close";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(57, 171);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 86;
            this.simpleButton4.Text = "Print";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(274, 95);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 13);
            this.lbl2.TabIndex = 85;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(57, 91);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 84;
            this.lbl1.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(269, 119);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(203, 20);
            this.txtTo.TabIndex = 83;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(57, 119);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(203, 20);
            this.txtFrom.TabIndex = 82;
            // 
            // chkByStyle
            // 
            this.chkByStyle.Location = new System.Drawing.Point(149, 55);
            this.chkByStyle.Name = "chkByStyle";
            this.chkByStyle.Properties.Caption = "By Style No";
            this.chkByStyle.Size = new System.Drawing.Size(75, 19);
            this.chkByStyle.TabIndex = 81;
            // 
            // chkDay
            // 
            this.chkDay.Location = new System.Drawing.Point(57, 55);
            this.chkDay.Name = "chkDay";
            this.chkDay.Properties.Caption = "Daily ";
            this.chkDay.Size = new System.Drawing.Size(75, 19);
            this.chkDay.TabIndex = 80;
            // 
            // frmFabricConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 519);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmFabricConsumption";
            this.Text = "Fabric Consumption";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFabricConsumption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAvailBal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFabricDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabused.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotedBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfPlys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollHegiht.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleNo.Properties)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkByStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.TextEdit txtAvailBal;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.ComboBoxEdit txtMNo;
        private DevExpress.XtraEditors.SimpleButton btnEditFabric;
        private DevExpress.XtraGrid.GridControl grdFabricDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.TextEdit txtActualBalance;
        private System.Windows.Forms.Label label32;
        private DevExpress.XtraEditors.TextEdit txtFabused;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.TextEdit txtNotedBalance;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.TextEdit txtNoOfPlys;
        private System.Windows.Forms.Label label28;
        private DevExpress.XtraEditors.TextEdit txtRollHegiht;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.TextEdit txtRollWidth;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraEditors.TextEdit txtRoleNo;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private DevExpress.XtraEditors.SimpleButton btnAddFabric;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.CheckEdit chkByStyle;
        private DevExpress.XtraEditors.CheckEdit chkDay;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private DevExpress.XtraEditors.TextEdit txtTo;
        private DevExpress.XtraEditors.TextEdit txtFrom;
    }
}