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
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using EFTesting.UI.Inventory;
using EFTesting.UI.Asset;
using DevExpress.LookAndFeel;
using EFTesting.UI.User_Accounts;
using EFTesting.UI.Cutting_report;
using System.Diagnostics;
using EFTesting.UI.Asset.Report;

namespace EFTesting.UI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           // DevExpress.UserSkins.TouchSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            
            
            ribbonControl1.Minimized = true;
            UserLookAndFeel.Default.SkinName = "Metropolis";
            this.ShowMdiChildCaptionInParentTitle = true;

          


        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown();
            gallery.Manager = barManager1;
            SkinHelper.InitSkinGalleryDropDown(gallery);
            gallery.ShowPopup(MousePosition);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmCompany objfrmMChild = new UI.frmCompany();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmBuyer objfrmMChild = new UI.frmBuyer();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmStyleMaster objfrmMChild = new UI.frmStyleMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.EmployeeMaster objfrmMChild = new UI.EmployeeMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmPurchaseOrder objfrmMChild = new UI.frmPurchaseOrder();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmSketchMaster objfrmMChild = new UI.frmSketchMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmParts objfrmMChild = new UI.frmParts();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            UI.frmOperation objfrmMChild = new UI.frmOperation();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmDividingPlan objfrmMChild = new UI.frmDividingPlan();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
           
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmOparationScaning objfrmMChild = new UI.frmOparationScaning();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmProduction objfrmMChild = new UI.frmProduction();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnDayend_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmDayend objfrmMChild = new UI.frmDayend();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPoDeliveriesDialog dialog = new frmPoDeliveriesDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHourlyProductionDialog dialog = new frmHourlyProductionDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmIndividualProductionDialog dialog = new frmIndividualProductionDialog();
            dialog.ShowDialog();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmScaningTimeScadual objfrmMChild = new UI.frmScaningTimeScadual();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmOfflineScaning objfrmMChild = new UI.frmOfflineScaning();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            dailyProductionDialog dialog = new dailyProductionDialog();
            dialog.ShowDialog();

        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            dlgBundleSelect dialog = new dlgBundleSelect();
            dialog.ShowDialog();
        }

        private void btnCuttingStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmCuttingStatus objfrmMChild = new UI.frmCuttingStatus();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
           

        }

        private void btnIssue_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmCutIssuing objfrmMChild = new UI.frmCutIssuing();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnCutting_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmCuttingMaster objfrmMChild = new UI.frmCuttingMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnBundle_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmBundlingMaster objfrmMChild = new UI.frmBundlingMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnCuttingLedger_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UI.frmCuttingledger objfrmMChild = new UI.frmCuttingledger();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnCustomFiled_ItemClick(object sender, ItemClickEventArgs e)
        {
         

            splashScreenManager1.ShowWaitForm();
            frmCustomFiledSetup objfrmMChild = new frmCustomFiledSetup();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();


        }

        private void btnItemMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmItemMaster objfrmMChild = new frmItemMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmSuplierMaster objfrmMChild = new frmSuplierMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();


        }

        private void btnPo_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmPo objfrmMChild = new frmPo();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnGrn_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmGrn objfrmMChild = new frmGrn();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnSpecialEntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmSpecialEntry objfrmMChild = new frmSpecialEntry();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnRequi_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmStockRequisition objfrmMChild = new frmStockRequisition();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnAsset_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmAsset objfrmMChild = new frmAsset();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnVerification_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmAssetVerification objfrmMChild = new frmAssetVerification();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnMachineType_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmMachineType objfrmMChild = new frmMachineType();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnMachine_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            frmMachineReqirement objfrmMChild = new frmMachineReqirement();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnStyleLoading_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            frmStylePlaning objfrmMChild = new frmStylePlaning();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnAnalays_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmMachineRequirementAnlays objfrmMChild = new frmMachineRequirementAnlays();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmUserAccounts objfrmMChild = new frmUserAccounts();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnRatio_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmRatio objfrmMChild = new frmRatio();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnCut_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmCuttingDaliySelection objfrmMChild = new frmCuttingDaliySelection();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoging _log = new frmLoging();
            _log.Show();
            this.Hide();
        }

        private void btnRequirement_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmMachineRequirement objfrmMChild = new frmMachineRequirement();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnConsumtion_ItemClick(object sender, ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            frmFabricConsumption objfrmMChild = new frmFabricConsumption();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();

        }

        private void btnOperation_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmOperation objfrmMChild = new frmOperation();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btncutPO_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            splashScreenManager1.ShowWaitForm();
            frmPoDeliveriesDialog objfrmMChild = new frmPoDeliveriesDialog();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnFab_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmFabricreport objfrmMChild = new frmFabricreport();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void btnActual_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmFabricConsumtionVsActual objfrmMChild = new frmFabricConsumtionVsActual();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmDayend objfrmMChild = new frmDayend();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            frmRentManagement objfrmMChild = new frmRentManagement();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
            splashScreenManager1.CloseWaitForm();
        }
    }
}