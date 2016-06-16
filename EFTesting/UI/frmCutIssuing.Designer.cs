namespace EFTesting.UI
{
    partial class frmCutIssuing
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCutNo = new DevExpress.XtraEditors.TextEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.grdItemList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbLineNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIssuNoteNo = new DevExpress.XtraEditors.TextEdit();
            this.txtremark = new DevExpress.XtraEditors.MemoEdit();
            this.txtInputRequestedBy = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.grdCutIssue = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCutNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuNoteNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRequestedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCutIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton3.Location = new System.Drawing.Point(391, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(85, 39);
            this.simpleButton3.TabIndex = 71;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(301, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(868, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 69;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(577, 23);
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
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(481, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(210, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(118, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(27, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 70;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.label25);
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1236, 395);
            this.xtraTabPage3.Text = "Reports";
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
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.label19);
            this.xtraTabPage2.Controls.Add(this.txtCutNo);
            this.xtraTabPage2.Controls.Add(this.label24);
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.grdItemList);
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1236, 395);
            this.xtraTabPage2.Text = "Marker ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 87;
            this.label19.Text = "Cut No";
            // 
            // txtCutNo
            // 
            this.txtCutNo.EditValue = "";
            this.txtCutNo.Location = new System.Drawing.Point(5, 52);
            this.txtCutNo.Name = "txtCutNo";
            this.txtCutNo.Properties.AccessibleDescription = "";
            this.txtCutNo.Properties.NullValuePrompt = "Please Enter Line Number";
            this.txtCutNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCutNo.Size = new System.Drawing.Size(251, 20);
            this.txtCutNo.TabIndex = 86;
            this.txtCutNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCutNo_KeyDown);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(167, 13);
            this.label24.TabIndex = 85;
            this.label24.Text = "Marker Details and Layer Details  ";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(343, 49);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 15;
            this.simpleButton4.Text = "Remove";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(262, 49);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Add";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // grdItemList
            // 
            this.grdItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdItemList.Location = new System.Drawing.Point(6, 78);
            this.grdItemList.MainView = this.gridView1;
            this.grdItemList.Name = "grdItemList";
            this.grdItemList.Size = new System.Drawing.Size(1123, 306);
            this.grdItemList.TabIndex = 57;
            this.grdItemList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridView1.GridControl = this.grdItemList;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grdSearchStyle);
            this.xtraTabPage1.Controls.Add(this.cmbType);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label23);
            this.xtraTabPage1.Controls.Add(this.label11);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Controls.Add(this.cmbLineNo);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtIssuNoteNo);
            this.xtraTabPage1.Controls.Add(this.txtremark);
            this.xtraTabPage1.Controls.Add(this.txtInputRequestedBy);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1236, 395);
            this.xtraTabPage1.Text = "Header";
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(29, 103);
            this.grdSearchStyle.MainView = this.gridView2;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(885, 259);
            this.grdSearchStyle.TabIndex = 1;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdSearchStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchStyle_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearchStyle;
            this.gridView2.Name = "gridView2";
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(165, 105);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Properties.Items.AddRange(new object[] {
            "PRO",
            "H/T"});
            this.cmbType.Properties.NullValuePrompt = "Item Type";
            this.cmbType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbType.Size = new System.Drawing.Size(282, 20);
            this.cmbType.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Input Requested By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Remark";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(36, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(202, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Issue Note Header / Cutting Department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(165, 77);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullValuePrompt = " Style No";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(281, 20);
            this.txtStyleNo.TabIndex = 3;
            this.txtStyleNo.EditValueChanged += new System.EventHandler(this.txtStyleNo_EditValueChanged);
            this.txtStyleNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStyleNo_KeyDown);
            // 
            // cmbLineNo
            // 
            this.cmbLineNo.Location = new System.Drawing.Point(166, 135);
            this.cmbLineNo.Name = "cmbLineNo";
            this.cmbLineNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLineNo.Properties.Items.AddRange(new object[] {
            "V-1",
            "V-2",
            "V-3",
            "V-4",
            "V-5",
            "V-6",
            "V-7",
            "V-8",
            "V-9",
            "V-10",
            "",
            ""});
            this.cmbLineNo.Properties.NullValuePrompt = "Item Type";
            this.cmbLineNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbLineNo.Size = new System.Drawing.Size(282, 20);
            this.cmbLineNo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Line No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Issue Note No";
            // 
            // txtIssuNoteNo
            // 
            this.txtIssuNoteNo.EditValue = "";
            this.txtIssuNoteNo.Location = new System.Drawing.Point(166, 48);
            this.txtIssuNoteNo.Name = "txtIssuNoteNo";
            this.txtIssuNoteNo.Properties.AccessibleDescription = "";
            this.txtIssuNoteNo.Properties.NullValuePrompt = "Cutting Ticket";
            this.txtIssuNoteNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtIssuNoteNo.Size = new System.Drawing.Size(281, 20);
            this.txtIssuNoteNo.TabIndex = 1;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(165, 199);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(283, 96);
            this.txtremark.TabIndex = 51;
            // 
            // txtInputRequestedBy
            // 
            this.txtInputRequestedBy.EditValue = "";
            this.txtInputRequestedBy.Location = new System.Drawing.Point(166, 164);
            this.txtInputRequestedBy.Name = "txtInputRequestedBy";
            this.txtInputRequestedBy.Properties.AccessibleDescription = "";
            this.txtInputRequestedBy.Properties.NullValuePrompt = " Style No";
            this.txtInputRequestedBy.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtInputRequestedBy.Size = new System.Drawing.Size(281, 20);
            this.txtInputRequestedBy.TabIndex = 52;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(27, 66);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1275, 401);
            this.xtraTabControl1.TabIndex = 72;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // grdCutIssue
            // 
            this.grdCutIssue.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCutIssue.Location = new System.Drawing.Point(305, 56);
            this.grdCutIssue.MainView = this.gridView3;
            this.grdCutIssue.Name = "grdCutIssue";
            this.grdCutIssue.Size = new System.Drawing.Size(886, 394);
            this.grdCutIssue.TabIndex = 54;
            this.grdCutIssue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.grdCutIssue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCutIssue_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdCutIssue;
            this.gridView3.Name = "gridView3";
            // 
            // frmCutIssuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 495);
            this.Controls.Add(this.grdCutIssue);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmCutIssuing";
            this.Text = "Cut Issuing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCutIssuing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCutNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuNoteNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInputRequestedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCutIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label25;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.TextEdit txtCutNo;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl grdItemList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLineNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIssuNoteNo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.MemoEdit txtremark;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtInputRequestedBy;
        private DevExpress.XtraGrid.GridControl grdCutIssue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbType;
        private System.Windows.Forms.Label label3;
    }
}