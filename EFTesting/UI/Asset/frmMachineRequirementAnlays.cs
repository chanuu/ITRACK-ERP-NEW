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
using ITRACK.models;
using EFTesting.DTOs;

namespace EFTesting.UI.Asset
{
    public partial class frmMachineRequirementAnlays : DevExpress.XtraEditors.XtraForm
    {
        public frmMachineRequirementAnlays()
        {
            InitializeComponent();
        }

        List<MachineListdto> lstMachines = new List<MachineListdto>();

        void UpdateItems(string type, int _nos)
        {
            try
            {
                foreach (var item in lstMachines.Where(x => x.MachineType == type))

                {
                    item.RequiredMachine = _nos+item.RequiredMachine;
                }

            }
            catch (Exception ex)
            {

            }

        }


        bool isAvaible(string _type) {
            try {
                bool status = false;
                var items = (from item in lstMachines
                             where item.MachineType == _type
                             select item).ToList();

                if (items.Count > 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                return status;
            }
            catch (Exception ex) {
                return false;
            }
        }


        void Process(DateTime _expected) {
            try {
                ItrackContext _context = new ItrackContext();
               
                backgroundWorker1.ReportProgress(0, "Looking For Styles between expected date range.Wait..");
                var styles = (from item in _context.StyleLoading

                             where item.EndDate>=_expected

                             select new { item.StyleID }).ToList();

                lstMachines.Clear();
                foreach (var style in styles)
                {
                    var stylelist = (from list in _context.MachineRequirementItem
                                    where list.MachineRequirement.StyleID == style.StyleID
                                    select list).ToList();

                    backgroundWorker1.ReportProgress(0, "Analyze Requirement Of "+ style.StyleID);
                   
                    foreach (var formated in stylelist)
                    {
                        backgroundWorker1.ReportProgress(0, "Finslizing Informations Of "+ style.StyleID);
                        MachineListdto dto = new MachineListdto();
                        dto.Location = formated.MachineRequirement.LocationCode;
                        dto.MachineType = formated.MachineType;
                        dto.RequiredMachine = formated.Nos;
                        dto.AvailableMachine = 0;
                        dto.Variance = 0;
                        dto.No = lstMachines.Count + 1;

                        if (isAvaible(dto.MachineType) == true)
                        {
                            UpdateItems(dto.MachineType, dto.RequiredMachine);
                        }
                        else
                        {
                            lstMachines.Add(dto);
                        }
                        
                    }

                  

                    backgroundWorker1.ReportProgress(1, lstMachines);


                }

               
                backgroundWorker1.ReportProgress(100, "Complete !");
               



            }
            catch (Exception ex) {

            }

        }






        private void btnProcess_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Process(Convert.ToDateTime(txtExpected.Text));

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           

            if (e.ProgressPercentage == 1)
            {
                grdStyleLoading.DataSource = null;
                grdStyleLoading.DataSource = e.UserState;
            }
            else
            {
                lblStatus.Text = e.UserState.ToString();
            }
        }
    }
}