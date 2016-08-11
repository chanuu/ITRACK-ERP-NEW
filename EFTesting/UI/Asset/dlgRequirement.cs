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

namespace EFTesting.UI.Asset
{
    public partial class dlgRequirement : DevExpress.XtraEditors.XtraForm
    {
        public dlgRequirement()
        {
            InitializeComponent();
        }

        public string StyleNo { get; set; }
        public dlgRequirement(string _StyleID)
        {
            InitializeComponent();
            this.StyleNo = _StyleID;
        }


        void GetRequirement()
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                var items = (from item in _context.MachineRequirementItem
                             where item.MachineRequirement.StyleID == this.StyleNo
                             select new { item.MachineRequirementItemID, item.MachineType, item.Nos }).ToList();
                grdItems.DataSource = items;

                var header = (from item in _context.MachineRequirementItem
                             where item.MachineRequirement.StyleID == this.StyleNo
                             select new { item.MachineRequirement }).ToList();
                txtLineNo.Text = header.Last().MachineRequirement.LineNo;
                txtRemark.Text = header.Last().MachineRequirement.Remark;
                txtStyleID.Text = header.Last().MachineRequirement.StyleNo;


            }
            catch (Exception ex)
            {

            }
        }

        private void dlgRequirement_Load(object sender, EventArgs e)
        {
            GetRequirement();
        }
    }
}