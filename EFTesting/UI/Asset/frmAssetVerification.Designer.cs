namespace EFTesting.UI.Asset
{
    partial class frmAssetVerification
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
            this.Progress = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtVerificationID = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new DevExpress.XtraEditors.MemoEdit();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textfileOpen = new System.Windows.Forms.OpenFileDialog();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Progress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerificationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(42, 150);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(1046, 10);
            this.Progress.TabIndex = 118;
            // 
            // txtVerificationID
            // 
            this.txtVerificationID.EditValue = "";
            this.txtVerificationID.Location = new System.Drawing.Point(54, 70);
            this.txtVerificationID.Name = "txtVerificationID";
            this.txtVerificationID.Properties.AccessibleDescription = "";
            this.txtVerificationID.Properties.NullValuePrompt = "Opration No";
            this.txtVerificationID.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtVerificationID.Size = new System.Drawing.Size(251, 20);
            this.txtVerificationID.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Asset Verification ID";
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(822, 70);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.AccessibleDescription = "";
            this.txtRemark.Properties.NullValuePrompt = "Opration No";
            this.txtRemark.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtRemark.Size = new System.Drawing.Size(251, 20);
            this.txtRemark.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Remark";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(42, 163);
            this.txtLog.Name = "txtLog";
            this.txtLog.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtLog.Properties.Appearance.Options.UseForeColor = true;
            this.txtLog.Size = new System.Drawing.Size(1064, 320);
            this.txtLog.TabIndex = 113;
            this.txtLog.EditValueChanged += new System.EventHandler(this.txtLog_EditValueChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.EditValue = "";
            this.txtLocation.Location = new System.Drawing.Point(565, 70);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Properties.AccessibleDescription = "";
            this.txtLocation.Properties.NullValuePrompt = "Opration No";
            this.txtLocation.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtLocation.Size = new System.Drawing.Size(251, 20);
            this.txtLocation.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Scan Date";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(311, 69);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(248, 21);
            this.txtDate.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Offline Asset Barcode Scan";
            // 
            // textfileOpen
            // 
            this.textfileOpen.FileName = "openFileDialog1";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton5.Location = new System.Drawing.Point(726, 96);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(162, 39);
            this.simpleButton5.TabIndex = 121;
            this.simpleButton5.Text = "Verification Location";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton3.Location = new System.Drawing.Point(558, 96);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(162, 39);
            this.simpleButton3.TabIndex = 120;
            this.simpleButton3.Text = "Verification";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton2.Location = new System.Drawing.Point(390, 96);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(162, 39);
            this.simpleButton2.TabIndex = 119;
            this.simpleButton2.Text = "Print";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton1.Location = new System.Drawing.Point(222, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(162, 39);
            this.simpleButton1.TabIndex = 112;
            this.simpleButton1.Text = "Process";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::EFTesting.Properties.Resources.save;
            this.simpleButton4.Location = new System.Drawing.Point(54, 96);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(162, 39);
            this.simpleButton4.TabIndex = 111;
            this.simpleButton4.Text = "Upload ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // frmAssetVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 504);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.txtVerificationID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "frmAssetVerification";
            this.Text = "Asset Verification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAssetVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Progress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerificationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ProgressBarControl Progress;
        private DevExpress.XtraEditors.TextEdit txtVerificationID;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit txtLog;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog textfileOpen;
    }
}