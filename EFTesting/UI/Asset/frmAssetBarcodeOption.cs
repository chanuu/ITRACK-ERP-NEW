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

namespace EFTesting.UI.Asset
{
    public partial class frmAssetBarcodeOption : DevExpress.XtraEditors.XtraForm
    {
        public frmAssetBarcodeOption()
        {
            InitializeComponent();
        }

        private void frmAssetBarcodeOption_Load(object sender, EventArgs e)
        {
            if (chkAssetID.Checked == true)
            {
                lbl1.Text = "Asset ID";
                lbl2.Hide();
                txtTo.Hide();
            }
            
        }
    }
}