﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EFTesting.Reports;
using ITRACK.models;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmDayend : DevExpress.XtraEditors.XtraForm
    {
        public frmDayend()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //   addDayendHeader();
            //    DateTime _now = Convert.ToDateTime(txtdate.Text);
            //    clsProductionSummary.DoDayend(lblStatus,progressPanel1,_now);

            FinlizedFabricReport(Convert.ToDateTime(txtfrom.Text), Convert.ToDateTime(txtTo.Text));

        }





        #region CUttingDPT

        bool FinlizedFabricReport(DateTime _from,DateTime _to) {
            try {
                ItrackContext _context = new ItrackContext();

                var items = (from item in _context.EstimateFabricConsumption
                            where item.Date >= _from && item.Date <= _to
                            select item).ToList();


                foreach(var row in items)
                {
                //  Debug.WriteLine("Marker No- "+row.MarkerNo+ "  Estimate -" +row.TotalFabricUsed+"   Actual"+ GetFabricUsage(row.StyleID, row.MarkerNo));
                    UpdateFabric(row.StyleID, row.MarkerNo, GetFabricUsage(row.StyleID, row.MarkerNo), GetFabricUsage(row.StyleID, row.MarkerNo) - row.TotalFabricUsed);
                }

                return true;
            }
            catch (Exception ex) {
                return false;
            }

        }

        private void UpdateFabric(string _styleNo,string _markerNo,double _Actual,double _def)
        {
            try
            {
                ItrackContext context = new ItrackContext();
                string _Query = "Update EstimateFabricConsumptions set ActualFabUsed = '"+ _Actual +"' ,Defference = '"+ _def +"' where MarkerNo = '"+ _markerNo +"' and StyleID = '"+ _styleNo +"'";
                context.Database.ExecuteSqlCommand(_Query);
            }
            catch (Exception ex)
            {

            }


        }

        double GetFabricUsage(string _styleID,string _MkrNo)
        {
            try
            {
                ItrackContext _cntx = new ItrackContext();
                var data = (from item in _cntx.FabricLedger

                            where item.StyleNo == _styleID && item.MarkerNo == _MkrNo

                            select item).ToList();


              return  data.Select(c => c.FabricUsed).Sum();
            
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
            
        



        #endregion



















        #region CRUD
        DayendHeader _header = new DayendHeader();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        DayendHeader AssignHeader() {

            try {
              

              foreach (var item in _CompanyRepository.GetAll().Where(x=> x.isDefaultCompany==true) ) {
                  _header.CompanyID = item.CompanyID;

                }

              _header.Date = DateTime.Now;
              _header.DayendBy = "Admin";
              DateTime _now = Convert.ToDateTime(txtfrom.Text);
              _header.DayendHeaderID =Convert.ToString( _now.Year + _now.Month + _now.Day);
              _header.DayendTime =Convert.ToString( DateTime.Now);
              _header.ApprovedBy = "None";
              _header.ApprovedAt = "None";
              _header.Status = "Pending";

                return _header;
            }
            catch(Exception ex){
               
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        void addDayendHeader() {
            try {
                GenaricRepository<DayendHeader> _DayendHeaderRepository = new GenaricRepository<DayendHeader>(new ItrackContext());
                _DayendHeaderRepository.Add(AssignHeader());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }

        #endregion 

        private void frmDayend_Load(object sender, EventArgs e)
        {
            progressPanel1.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clsProductionSummary p = new clsProductionSummary();
            rptDayend _report = new rptDayend();


            Debug.WriteLine(p.GetDayendHeader(DateTime.Now).Count() + " Data Row Count");
            _report.DataSource = p.GetDayendHeader(DateTime.Now);

            ReportPrintTool tool = new ReportPrintTool(_report);
            tool.ShowPreview();
         //  p.AddIndividualProductionSummary(DateTime.Now);

         //  p.AddCuttingSummary(DateTime.Now);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            HourlyProduction _report = new HourlyProduction();
            
            ReportPrintTool tool = new ReportPrintTool(_report);
            tool.ShowPreview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           ItrackContext t = new ItrackContext();
           Debug.WriteLine("Start : " + DateTime.Now.ToString());
           var item = (from items in t.OprationBarcodes
                       where items.BundleDetails.BundleHeader.CuttingItem.CuttingItemID >1230 && items.BundleDetails.BundleHeader.CuttingItem.CuttingItemID <1234
                       select new {
              items. OprationBarcodesID,
              items.BundleDetails.BundleNo,
              items.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID


           
           }).ToList();

           foreach (var i in item)
           {
              
               Debug.WriteLine(i.OprationBarcodesID,i.BundleNo,i.StyleID);
              
           }
           Debug.WriteLine("End : " + DateTime.Now.ToString());
        }
    }
}