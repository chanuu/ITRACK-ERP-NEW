namespace EFTesting.UI
{
    partial class frmRunningNo
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
            this.txtPrefix = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStarting = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVenue = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStarting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVenue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(138, 143);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Properties.NullValuePrompt = "Please Enter Prefix";
            this.txtPrefix.Size = new System.Drawing.Size(226, 20);
            this.txtPrefix.TabIndex = 67;
            this.txtPrefix.EditValueChanged += new System.EventHandler(this.txtPrefix_EditValueChanged_1);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(138, 242);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.NullValuePrompt = "Code Generate";
            this.txtCode.Size = new System.Drawing.Size(226, 20);
            this.txtCode.TabIndex = 65;
            this.txtCode.EditValueChanged += new System.EventHandler(this.txtCode_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Code";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(138, 192);
            this.txtLength.Name = "txtLength";
            this.txtLength.Properties.NullValuePrompt = "Please Enter Length";
            this.txtLength.Size = new System.Drawing.Size(226, 20);
            this.txtLength.TabIndex = 63;
            this.txtLength.EditValueChanged += new System.EventHandler(this.txtLength_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Prefix";
            // 
            // txtStarting
            // 
            this.txtStarting.Location = new System.Drawing.Point(138, 94);
            this.txtStarting.Name = "txtStarting";
            this.txtStarting.Properties.NullValuePrompt = "Please Enter Starting";
            this.txtStarting.Size = new System.Drawing.Size(226, 20);
            this.txtStarting.TabIndex = 60;
            this.txtStarting.EditValueChanged += new System.EventHandler(this.txtStarting_EditValueChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Starting";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(138, 49);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVenue.Properties.Items.AddRange(new object[] {
            "PO",
            "GRN",
            "REQ",
            "SPE",
            "ASS",
            "TRA",
            "ASSREQ"});
            this.txtVenue.Properties.NullValuePrompt = "Please Enter Venue";
            this.txtVenue.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtVenue.Size = new System.Drawing.Size(226, 20);
            this.txtVenue.TabIndex = 58;
            this.txtVenue.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Venue";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(230, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Update";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(138, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(47, 300);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 57;
            this.btnNew.Text = "New";
            // 
            // frmRunningNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 393);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStarting);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmRunningNo";
            this.Text = "frmRunningNo";
            this.Load += new System.EventHandler(this.frmRunningNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStarting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVenue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPrefix;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtStarting;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.ComboBoxEdit txtVenue;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}