namespace EFTesting.UI.User_Accounts
{
    partial class frmLoging
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPWord = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblError = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EFTesting.UI.WaitForm1), true, true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(157, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.AccessibleDescription = "";
            this.txtUserName.Properties.NullValuePrompt = "User Name";
            this.txtUserName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtUserName.Size = new System.Drawing.Size(251, 20);
            this.txtUserName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Password";
            // 
            // txtPWord
            // 
            this.txtPWord.EditValue = "";
            this.txtPWord.Location = new System.Drawing.Point(157, 85);
            this.txtPWord.Name = "txtPWord";
            this.txtPWord.Properties.AccessibleDescription = "";
            this.txtPWord.Properties.NullValuePrompt = "Password";
            this.txtPWord.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPWord.Properties.PasswordChar = '*';
            this.txtPWord.Size = new System.Drawing.Size(251, 20);
            this.txtPWord.TabIndex = 37;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(157, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Login";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.save1;
            this.simpleButton1.Location = new System.Drawing.Point(248, 120);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 40;
            this.simpleButton1.Text = "Close";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(39, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 41;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmLoging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 240);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmLoging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loging";
            this.Load += new System.EventHandler(this.frmLoging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPWord.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtPWord;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lblError;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}