namespace EFTesting.UI.Asset
{
    partial class dlgRequirement
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
            this.txtStyleID = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.txtLineNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStyleID
            // 
            this.txtStyleID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStyleID.EditValue = "";
            this.txtStyleID.Location = new System.Drawing.Point(34, 53);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Properties.AccessibleName = "Subject";
            this.txtStyleID.Size = new System.Drawing.Size(221, 20);
            this.txtStyleID.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AccessibleName = "Subject";
            this.lblSubject.Location = new System.Drawing.Point(34, 34);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(42, 13);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "&Style ID:";
            // 
            // txtLineNo
            // 
            this.txtLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLineNo.EditValue = "";
            this.txtLineNo.Location = new System.Drawing.Point(261, 53);
            this.txtLineNo.Name = "txtLineNo";
            this.txtLineNo.Properties.AccessibleName = "Subject";
            this.txtLineNo.Size = new System.Drawing.Size(221, 20);
            this.txtLineNo.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Subject";
            this.labelControl1.Location = new System.Drawing.Point(261, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "&Line No";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(488, 53);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.AccessibleName = "Subject";
            this.txtRemark.Size = new System.Drawing.Size(221, 20);
            this.txtRemark.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.AccessibleName = "Subject";
            this.labelControl2.Location = new System.Drawing.Point(488, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "&Remark";
            // 
            // grdItems
            // 
            this.grdItems.Location = new System.Drawing.Point(34, 79);
            this.grdItems.MainView = this.gridView1;
            this.grdItems.Name = "grdItems";
            this.grdItems.Size = new System.Drawing.Size(809, 308);
            this.grdItems.TabIndex = 30;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dlgRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 427);
            this.Controls.Add(this.grdItems);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLineNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtStyleID);
            this.Controls.Add(this.lblSubject);
            this.Name = "dlgRequirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Machine Requirement[View]";
            this.Load += new System.EventHandler(this.dlgRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.TextEdit txtStyleID;
        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.TextEdit txtLineNo;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.TextEdit txtRemark;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}