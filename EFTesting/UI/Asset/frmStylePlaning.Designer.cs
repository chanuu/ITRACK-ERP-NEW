namespace EFTesting.UI.Asset
{
    partial class frmStylePlaning
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.eFAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFResourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFResourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.DataSource = this.eFAppointmentBindingSource;
            this.schedulerStorage1.Resources.DataSource = this.eFResourceBindingSource;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsView.NavigationButtons.NextCaption = "Next ";
            this.schedulerControl1.OptionsView.NavigationButtons.PrevCaption = "Previous ";
            this.schedulerControl1.Size = new System.Drawing.Size(1064, 489);
            this.schedulerControl1.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 1;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.TimelineScrollBarVisible = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.AllDayAreaScrollBarVisible = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // frmStylePlaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 489);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "frmStylePlaning";
            this.Text = "Style Planing";
            this.Load += new System.EventHandler(this.frmStylePlaning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFResourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.BindingSource eFAppointmentBindingSource;
        private System.Windows.Forms.BindingSource eFResourceBindingSource;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}