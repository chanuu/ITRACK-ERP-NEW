using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using ITRACK.models;
using System.Data.Entity;
using XtraSchedulerEFTest;
using System.Diagnostics;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;

namespace EFTesting.UI.Asset
{
    public partial class frmStylePlaning : DevExpress.XtraEditors.XtraForm
    {

        private ItrackContext _context;
        public frmStylePlaning()
        {
            InitializeComponent();

            schedulerStorage1.Appointments.CommitIdToDataSource = false;
            schedulerStorage1.Appointments.ResourceSharing = true;
            schedulerControl1.Storage.Resources.ColorSaving = ColorSavingType.ArgbColor;

            #region #appmappings
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.AppointmentId = "UniqueID";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "StyleNo";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceIDs";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "StyleID";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            #endregion #appmappings
            #region #resmappings
            this.schedulerStorage1.Resources.Mappings.Caption = "ResourceName";
            this.schedulerStorage1.Resources.Mappings.Color = "Color";
            this.schedulerStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerStorage1.Resources.Mappings.Image = "Image";
            #endregion #resmappings 

            schedulerControl1.Storage.AppointmentsChanged += Storage_AppointmentsModified;
            schedulerControl1.Storage.AppointmentsInserted += Storage_AppointmentsModified;
            schedulerControl1.Storage.AppointmentsDeleted += Storage_AppointmentsModified;

            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.Start = DateTime.Now.Date;
        }

        public DbSet<StyleLoading> StyleLoading { get; set; }

        void Storage_AppointmentsModified(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            _context.Configuration.AutoDetectChangesEnabled = true;
            int i =   _context.SaveChanges();
           
            _context.Configuration.AutoDetectChangesEnabled = false;
        }
        private void frmStylePlaning_Load(object sender, EventArgs e)
        {
            #region #datainit

            _context = new ItrackContext();
            
            _context.Database.Initialize(false);
            _context.EFAppointments.Load();
            _context.EFResources.Load();

            eFAppointmentBindingSource.DataSource = _context.EFAppointments.Local.ToBindingList<EFAppointment>();
            eFResourceBindingSource.DataSource = _context.EFResources.Local.ToBindingList<EFResource>();
            #endregion #datainit
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            EFTesting.UI.Asset.CustomAppointmentForm1 form = new EFTesting.UI.Asset.CustomAppointmentForm1(scheduler, e.Appointment, e.OpenRecurrenceForm);
            form.Text = "Create Style Loading";
            try
            {
               
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu)
            {
                // Hide the "Change View To" menu item.
                SchedulerPopupMenu itemChangeViewTo = e.Menu.GetPopupMenuById(SchedulerMenuItemId.SwitchViewMenu);
                itemChangeViewTo.Visible = false;

                // Remove unnecessary items.
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);

                // Disable the "New Recurring Appointment" menu item.
                e.Menu.DisableMenuItem(SchedulerMenuItemId.NewRecurringAppointment);

                e.Menu.DisableMenuItem(SchedulerMenuItemId.AppointmentDependencyMenu);

                e.Menu.DisableMenuItem(SchedulerMenuItemId.NewRecurringEvent);



                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                if (item != null) item.Caption = "&New Style";

                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item2 = e.Menu.GetMenuItemById(SchedulerMenuItemId.DeleteAppointment);
                if (item2 != null) item2.Caption = "&Delete Style";

                // Create a menu item for the Scheduler command.
                ISchedulerCommandFactoryService service =
                (ISchedulerCommandFactoryService)schedulerControl1.GetService(typeof(ISchedulerCommandFactoryService));
                SchedulerCommand cmd = service.CreateCommand(SchedulerCommandId.SwitchToGroupByResource);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter =
                    new SchedulerMenuItemCommandWinAdapter(cmd);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);

                // Insert a new item into the Scheduler popup menu and handle its click event.
               
            }
        }
    }
}