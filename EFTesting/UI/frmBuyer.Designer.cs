namespace EFTesting.UI
{
    partial class frmBuyer
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
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaxNo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeleNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyerName = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastModfied = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreatedDate = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastModfied.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(376, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(195, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(103, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(12, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 63);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(968, 406);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtEmail);
            this.xtraTabPage1.Controls.Add(this.txtAddress);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtFaxNo);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtTeleNo);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtBuyerName);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(888, 400);
            this.xtraTabPage1.Text = "Profile ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(177, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AccessibleDescription = "";
            this.txtEmail.Properties.NullValuePrompt = "Please Enter Fax No";
            this.txtEmail.Size = new System.Drawing.Size(251, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.EditValue = "";
            this.txtAddress.Location = new System.Drawing.Point(177, 212);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.NullValuePrompt = "Shipping Address";
            this.txtAddress.Size = new System.Drawing.Size(289, 96);
            this.txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Shipping Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buyer Fax No";
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.EditValue = "";
            this.txtFaxNo.Location = new System.Drawing.Point(177, 130);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Properties.AccessibleDescription = "";
            this.txtFaxNo.Properties.NullValuePrompt = "Please Enter Fax No";
            this.txtFaxNo.Size = new System.Drawing.Size(251, 20);
            this.txtFaxNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buyer Tele No";
            // 
            // txtTeleNo
            // 
            this.txtTeleNo.EditValue = "";
            this.txtTeleNo.Location = new System.Drawing.Point(177, 92);
            this.txtTeleNo.Name = "txtTeleNo";
            this.txtTeleNo.Properties.AccessibleDescription = "";
            this.txtTeleNo.Properties.NullValuePrompt = "Please Enter Tele No";
            this.txtTeleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTeleNo.Size = new System.Drawing.Size(251, 20);
            this.txtTeleNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buyer Name";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.EditValue = "";
            this.txtBuyerName.Location = new System.Drawing.Point(177, 54);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Properties.AccessibleDescription = "";
            this.txtBuyerName.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtBuyerName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtBuyerName.Size = new System.Drawing.Size(251, 20);
            this.txtBuyerName.TabIndex = 1;
            this.txtBuyerName.EditValueChanged += new System.EventHandler(this.txtBuyerName_EditValueChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(888, 424);
            this.xtraTabPage2.Text = "Styles ";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(888, 424);
            this.xtraTabPage3.Text = "Other";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(476, 22);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 9;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(12, 49);
            this.grdSearch.MainView = this.gridView1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(960, 334);
            this.grdSearch.TabIndex = 14;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearch.Click += new System.EventHandler(this.grdSearch_Click);
            this.grdSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdSearch_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearch;
            this.gridView1.Name = "gridView1";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(767, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(286, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Last Modified";
            // 
            // txtLastModfied
            // 
            this.txtLastModfied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLastModfied.EditValue = "";
            this.txtLastModfied.Location = new System.Drawing.Point(663, 475);
            this.txtLastModfied.Name = "txtLastModfied";
            this.txtLastModfied.Properties.AccessibleDescription = "";
            this.txtLastModfied.Properties.NullText = "Please Enter Buyer Name";
            this.txtLastModfied.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtLastModfied.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLastModfied.Size = new System.Drawing.Size(209, 20);
            this.txtLastModfied.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Created By";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCreatedBy.EditValue = "";
            this.txtCreatedBy.Location = new System.Drawing.Point(366, 475);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Properties.AccessibleDescription = "";
            this.txtCreatedBy.Properties.NullText = "Please Enter Buyer Name";
            this.txtCreatedBy.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtCreatedBy.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(209, 20);
            this.txtCreatedBy.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Created Date";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCreatedDate.EditValue = "";
            this.txtCreatedDate.Location = new System.Drawing.Point(92, 475);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Properties.AccessibleDescription = "";
            this.txtCreatedDate.Properties.NullText = "Please Enter Buyer Name";
            this.txtCreatedDate.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtCreatedDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(188, 20);
            this.txtCreatedDate.TabIndex = 38;
            // 
            // frmBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 499);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLastModfied);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmBuyer";
            this.Text = "Buyer Master Files ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBuyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastModfied.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBuyerName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtFaxNo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTeleNo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtLastModfied;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtCreatedBy;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtCreatedDate;
    }
}