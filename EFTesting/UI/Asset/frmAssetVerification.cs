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
using DevExpress.XtraReports.UI;
using EFTesting.UI.DTO;
using EFTesting.ViewModel;
using System.Diagnostics;
using EFTesting.Reports.Asset;

namespace EFTesting.UI.Asset
{
    public partial class frmAssetVerification : DevExpress.XtraEditors.XtraForm
    {
        public frmAssetVerification()
        {
            InitializeComponent();
        }


        #region CUID
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<AssetBarcode> _AsserBarcodeRepo = new GenaricRepository<AssetBarcode>(new ItrackContext());
        Company _Company = new Company();
        AssetBarcode _AssetBarcode = new AssetBarcode();


        #endregion

        private bool ProcessTextFile()
        {

            // textfileOpen.Filter = "Text Files (*.txt) | *.doc";
            textfileOpen.InitialDirectory = @"C:\";
            textfileOpen.Title = "Select Text File To Process";
            TextFileReadingHelper _helper = new TextFileReadingHelper();
            if (textfileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                string _path = textfileOpen.FileName;

                txtLocation.Text = _path;



            }

            return true;

        }

        AssetBarcode _assetbarcode = new AssetBarcode();

        TextFileReadingHelper _helper = new TextFileReadingHelper();

        public string AssetUsedLocationID { get; set; }
      

        bool isAssetBarcodeExit = false;

        int _AssetCount = 0;
        private void AssetScan()
        {
            Progress.Properties.Step = 1;
            Progress.Properties.PercentView = true;

            Progress.Properties.Minimum = 0;

            Progress.Properties.Maximum = _helper.getAllLines(txtLocation.Text).ToList().Count;
            Progress.Show();

            Progress.ShowProgressInTaskBar = true;

            int i = 0;

            foreach (var Line in _helper.getAllLines(txtLocation.Text))
            {



                if (Line.Length == 4)
                {
                    GenaricRepository<AssetBarcode> _AssetBardeRepos = new GenaricRepository<AssetBarcode>(new ItrackContext());
                    var astlist = _AssetBardeRepos.GetAll();
                    if (astlist.Count() > 0)
                    {
                        _assetbarcode.AssetUsedBy = Line;
                        AssetUsedLocationID = Line;

                        txtLog.MaskBox.AppendText("Used Current Location  -> :" + _assetbarcode.AssetUsedBy + "" + "\r\n");
                        isAssetBarcodeExit = true;

                    }
                    else
                    {

                        Debug.WriteLine("Error :" + Line + "\r\n");

                        isAssetBarcodeExit = false;
                        txtLog.MaskBox.AppendText("Error   ->Canot find Location :" + Line + "" + "\r\n");

                    }


                }
                else if (Line.Length == 9)
                {

                    offlineScaning(Line);

                    AssetVerificationHeader();
                    AssetVerification(Line);
                    //  Debug.WriteLine(Line);


                }

                Progress.PerformStep();
                Progress.Update();

                i = i + 1;

            }

            Progress.Hide();


        }




        private void AssetVerification(string _assetId)
        {
            try
            {
                AssetVerificationDetails _details = new AssetVerificationDetails();

                GenaricRepository<AssetVerificationDetails> _BarcodeRepos = new GenaricRepository<AssetVerificationDetails>(new ItrackContext());
                ItrackContext _context = new ItrackContext();

                var asset = (from item in _context.AssetBarcode
                             where item.AssetBarcodeID == _assetId

                             select item).ToList().Last();

                _details.AssetVerificationID = txtVerificationID.Text;

                _details.AssetID = asset.AssetBarcodeID;
                _details.RefNo = asset.AlternetAsset;
                _details.Remark = txtRemark.Text;
                _details.Condition = "Working";
                _details.UserdBy = AssetUsedLocationID;
                _details.AssetBarcodeID = _details.AssetID;
                _BarcodeRepos.Insert(_details);

                feedledger(_details);
                UpdateLocationOfMachine(_details.UserdBy, _details.AssetID);

                ////asset ledger 

            }
            catch (Exception ex)
            {


            }

        }


        void UpdateCurrentStatusOfMachine(string _status)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

        }


        void UpdateLocationOfMachine(string _location, string _assetNo)
        {
            try
            {
                ItrackContext _context = new ItrackContext();
                string _query = "Update AssetBarcodes Set AssetUsedBy = '" + _location + "' where AssetBarcodeID = '" + _assetNo + "'";
                _context.Database.ExecuteSqlCommand(_query);
            }
            catch (Exception ex)
            {


            }

        }


        private void AssetVerificationHeader()
        {

            try
            {
                AssetVerification asset = new AssetVerification();

                GenaricRepository<AssetVerification> _BarcodeRepos = new GenaricRepository<AssetVerification>(new ItrackContext());


                asset.AssetVerificationID = txtVerificationID.Text;
                asset.Date = DateTime.Now;
                asset.CompanyID = 5;
                asset.ApprovedBy = "Admin";
                asset.Remark = txtRemark.Text;
                _BarcodeRepos.Insert(asset);

            }
            catch (Exception ex)
            {

            }

        }



        private void offlineScaning(string _barcode)
        {
            try
            {
                GenaricRepository<AssetBarcode> _BarcodeRepos = new GenaricRepository<AssetBarcode>(new ItrackContext());
                GenaricRepository<AssetBarcode> _EditBarcodeRepos = new GenaricRepository<AssetBarcode>(new ItrackContext());
                foreach (var barcode in _BarcodeRepos.GetAll().Where(p => p.AssetBarcodeID == _barcode).ToList())
                {
                    

                    AssetBarcode _abarcode = new AssetBarcode();
                    _abarcode.AssetName = barcode.AssetName;
                    _abarcode.AssetBarcodeID = barcode.AssetBarcodeID;
                    _abarcode.AlternetAsset = barcode.AlternetAsset;
                    _abarcode.CustomField1 = barcode.CustomField1;
                    if (isAssetBarcodeExit == true)
                    {
                        txtLog.MaskBox.AppendText("Barcode ID -> :" + _barcode + "   Asset ID-> :" + _abarcode.AlternetAsset + "  Machine Type :" + _abarcode.CustomField1 + "\r\n");

                    }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        //feed leger
        private void feedledger(AssetVerificationDetails _item)
        {
            try
            {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }

                AssetLedger _Ledger = new AssetLedger();

                _Ledger.CompanyID = _Company.CompanyID;
                _Ledger.TransactionID = GetNewCode();
                _Ledger.Date = DateTime.Now;
                _Ledger.AssetID = _item.AssetID;
                _Ledger.DocType = "ASV";
                _Ledger.DocNo = txtVerificationID.Text;
                _Ledger.LocationCode = _Company.LocationCode;
                _Ledger.AssetType = GetAssetType(_Ledger.AssetID);
                _Ledger.UsedBy = _item.UserdBy;
                _Ledger.Status = _item.Condition;

                _Ledger.FeedAssetLedger(_Ledger);
            }
            catch (Exception ex)
            {

            }



        }



        string GetAssetType(string _id)
        {

            try
            {
                ItrackContext _context = new ItrackContext();
                var asset = (from item in _context.AssetBarcode where item.AssetBarcodeID == _id select new { item.AssetName }).ToList().Last();
                return asset.AssetName;

            }
            catch (Exception ex)
            {

                return null;
            }
        }



        List<AssetLedger> lstAssetDetails = new List<AssetLedger>();

        //private void feedAssetDetails (AssetLedger _AssetLedger)
        //{
        //    try
        //    {
        //        lstAssetDetails.Add(_AssetLedger);
        //        var itemList = from items in lstAssetDetails select new {items.AssetID, items.AssetType, items.UsedBy};


        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}


        //private void AddAssetDetails()
        //{
        //    try
        //    {
        //        AssetLedger _AssetLedger = new AssetLedger();

        //        foreach (var item in lstAssetDetails)
        //        {
        //            GenaricRepository<AssetLedger> _AssetLedgerRepo = new GenaricRepository<AssetLedger>(new ItrackContext());
        //            _AssetLedger.LocationCode = item.LocationCode;
        //            _AssetLedger.TransactionID = item.TransactionID;
        //            _AssetLedger.Date = item.Date;
        //            _AssetLedger.AssetID = item.AssetID;
        //            _AssetLedger.DocType = item.DocType;
        //            _AssetLedger.DocNo = item.DocNo;
        //            _AssetLedger.AssetType = item.AssetType;
        //            _AssetLedger.UsedBy = item.UsedBy;
        //            _AssetLedger.Status = item.Status;

        //            _AssetLedgerRepo.Insert(_AssetLedger);    
        //        }

        //        feedledger(_AssetLedger);
        //    }

        //    catch (Exception ex)
        //    {

        //    }

        //}


        int getSPECount()
        {
            try
            {
                GenaricRepository<AssetLedger> _AssetLedgerRepo = new GenaricRepository<AssetLedger>(new ItrackContext());
                return _AssetLedgerRepo.GetAll().ToList().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }

        string LastTransctionID = "";
        string GetNewCode()
        {

            try
            {

                RunningNo _No = new RunningNo();
                clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "TRA"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    LastTransctionID = _Engine.GenarateNo(_No, getSPECount());


                }

                return LastTransctionID;
            }
            catch (Exception ex)

            {
                return "";
                // Debug.WriteLine(ex.Message);
            }


        }


        int getAssetCount()
        {
            try
            {
                GenaricRepository<AssetVerification> _AssetVerificationRepo = new GenaricRepository<AssetVerification>(new ItrackContext());
                return _AssetVerificationRepo.GetAll().ToList().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }


        void AssetVerificationLocationReport(string _ID)
        {
            try
            {

                lstAssetVerificationLocationDto.Clear();
                var item = (from j in _cntx.AssetVerificationDetails
                            where j.AssetVerificationID == _ID

                            group j by new { j.UserdBy, j.AssetBarcode.CustomField1, j.AssetVerification.Date, j.AssetVerification.AssetVerificationID } into G
                            select new { G.Key.UserdBy, G.Key.CustomField1, G.Key.Date, G.Key.AssetVerificationID, Machines = G.Count() }).ToList();


                foreach (var asset in item)
                {


                    try
                    {
                        AssetVerificationLocationdto _dtol = new AssetVerificationLocationdto();
                        _dtol.Model = asset.CustomField1;
                        _dtol.Available = asset.Machines;
                        _dtol.Date = asset.Date;
                        _dtol.AssetVerificationNo = asset.AssetVerificationID;
                        _dtol.AssetLocation = asset.UserdBy;
                        //_dtol.No = lstAssetVerificationLocationDto.Count + 1;

                        lstAssetVerificationLocationDto.Add(_dtol);

                    }


                    catch (Exception ex)
                    {

                    }

                }

                rtAssetByLocation repo = new rtAssetByLocation();

                repo.DataSource = lstAssetVerificationLocationDto;
                // repo.DataMember = "AssetVerificationLocationdto";
                repo.PrintingSystem.Document.AutoFitToPagesWidth = 1;

                ReportPrintTool preview = new ReportPrintTool(repo);

                preview.ShowPreview();

            }
            catch (Exception ex)
            {
            }




        }


        void GetNewCodeAsset()
        {

            try
            {

                RunningNo _No = new RunningNo();
                clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "TRA"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtVerificationID.Text = _Engine.GenarateNo(_No, getAssetCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }




        List<AssetVerificationdto> lstAssetVerificationDto = new List<AssetVerificationdto>();



        ItrackContext _cntx = new ItrackContext();



        int GetMachineCount(string _ID, string _TYpe)
        {

            var machine = (from j in _cntx.AssetVerificationDetails
                           where j.AssetVerificationID == _ID && j.AssetBarcode.CustomField1 == _TYpe
                           select j).ToList();
            return machine.Count;
        }



        void AssetVerificationReport(string _ID)
        {
            try
            {

                lstAssetVerificationDto.Clear();
                var item = (from j in _cntx.AssetVerificationDetails
                            where j.AssetVerificationID == _ID

                            group j by new { j.UserdBy, j.AssetBarcode.CustomField1, j.AssetBarcode.CustomField2 } into G
                            select new { G.Key.UserdBy, G.Key.CustomField1, G.Key.CustomField2, Machines = G.Count() }).ToList();


                //////var item = from j in _cntx.AssetVerificationDetails
                //////           where j.AssetVerificationID == _ID
                //////           select new { j.AssetBarcode.CustomField1,j.AssetBarcode.CustomField2 ,j.UserdBy};   

                foreach (var asset in item)
                {


                    try
                    {
                        AssetVerificationdto dto = new AssetVerificationdto();

                        dto.Model = asset.CustomField1;
                        dto.Available = asset.Machines;
                        dto.Brand = asset.CustomField2;
                        dto.AssetLocation = asset.UserdBy;
                        dto.No = lstAssetVerificationDto.Count + 1;
                        lstAssetVerificationDto.Add(dto);


                    }


                    catch (Exception ex)
                    {

                    }

                }

                //rtAssetVerification repo = new rtAssetVerification();

                //repo.DataSource = lstAssetVerificationDto;

                //ReportPrintTool preview = new ReportPrintTool(repo);

                //preview.ShowPreview();

            }
            catch (Exception ex)
            {
            }




        }



        List<AssetVerificationLocationdto> lstAssetVerificationLocationDto = new List<AssetVerificationLocationdto>();

        ItrackContext _con = new ItrackContext();

        int GetAssetMachineCount(string _ID, string _TYpe)
        {

            var machine = (from j in _cntx.AssetVerificationDetails
                           where j.AssetVerificationID == _ID && j.AssetBarcode.CustomField1 == _TYpe
                           select j).ToList();
            return machine.Count;
        }


     




        List<Assetlistdto> lstAssetDto = new List<Assetlistdto>();

        ItrackContext _context = new ItrackContext();
        int _getAvalibleMachineByType(string _type)
        {

            return (from item in _context.AssetBarcode
                    where item.CustomField1 == _type
                    select new { item.AssetBarcodeID }).ToList().Count;

        }


        int _getInUseMachineByType(string _type)
        {

            return (from item in _context.AssetBarcode

                    where item.AssetStatus == "In-Use" && item.CustomField1 == _type
                    select new { item.AssetBarcodeID }).ToList().Count();

        }

        void print()
        {

            ItrackContext _context = new ItrackContext();

            var MachineType = (from item in _context.AssetBarcode

                               select new { item.CustomField1 }).ToList().Distinct();

            foreach (var machine in MachineType)
            {

                Assetlistdto _dto = new Assetlistdto();

                _dto.Model = machine.CustomField1;
                _dto.Available = _getAvalibleMachineByType(_dto.Model);
                _dto.InUse = _getInUseMachineByType(_dto.Model);
                _dto.GivenOnLoan = 0;
                _dto.Reject = 0;
                _dto.No = lstAssetDto.Count + 1;

                lstAssetDto.Add(_dto);
                Debug.WriteLine(machine.CustomField1 + "   Avail :   " + _dto.Available + "  In-Use :" + _dto.InUse);
            }

            rtAssetByCondtion report = new rtAssetByCondtion();

            var machineList = from item in lstAssetDto
                                  //  orderby item.Available descending
                              select item;
            report.DataSource = machineList;

            ReportPrintTool preview = new ReportPrintTool(report);

            preview.ShowPreview();

        }

        string getlastverificationID()
        {
            try
            {
                ItrackContext _cntx = new ItrackContext();
                return (from item in _cntx.AssetVerification
                        select item.AssetVerificationID
                        ).ToList().Last();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        void AssetVerificationReports(string _ID)
        {
            try
            {

                lstAssetVerificationDto.Clear();
                var item = (from j in _cntx.AssetVerificationDetails
                            where j.AssetVerificationID == _ID

                            group j by new { j.UserdBy, j.AssetBarcode.CustomField1, j.AssetBarcode.CustomField2 } into G
                            select new { G.Key.UserdBy, G.Key.CustomField1, G.Key.CustomField2, Machines = G.Count() }).ToList();


                //////var item = from j in _cntx.AssetVerificationDetails
                //////           where j.AssetVerificationID == _ID
                //////           select new { j.AssetBarcode.CustomField1,j.AssetBarcode.CustomField2 ,j.UserdBy};   

                foreach (var asset in item)
                {


                    try
                    {
                        AssetVerificationdto dto = new AssetVerificationdto();

                        dto.Model = asset.CustomField1;
                        dto.Available = asset.Machines;
                        dto.Brand = asset.CustomField2;
                        dto.AssetLocation = asset.UserdBy;
                        dto.No = lstAssetVerificationDto.Count + 1;
                        lstAssetVerificationDto.Add(dto);


                    }


                    catch (Exception ex)
                    {

                    }

                }

                rtAsset_Verification repo = new rtAsset_Verification();

                repo.DataSource = lstAssetVerificationDto;

                ReportPrintTool preview = new ReportPrintTool(repo);

                preview.ShowPreview();

            }
            catch (Exception ex)
            {
            }




        }



        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ProcessTextFile();
            GetNewCodeAsset();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AssetScan();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            AssetVerificationReports(getlastverificationID());
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            AssetVerificationLocationReport(getlastverificationID());
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            print();
        }

        private void frmAssetVerification_Load(object sender, EventArgs e)
        {

        }

        private void txtLog_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}