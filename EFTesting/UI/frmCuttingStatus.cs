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
using DevExpress.Office.Utils;
using System.Diagnostics;
using EFTesting.DTOs;
using DevExpress.XtraGrid;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmCuttingStatus : DevExpress.XtraEditors.XtraForm
    {
        public frmCuttingStatus()
        {
            InitializeComponent();
        }


        List<CuttingStock> lstCutting = new List<CuttingStock>();
        ItrackContext _context = new ItrackContext();

        //void Refresh(DateTime _from,DateTime _To,string _style)
        //{
        //    try {
        //        lstCutting.Clear();
        //        var list = (from items in _context.CuttingItem

        //                   where items.Date >= _from && items.Date <=_To where items.CuttingHeader.StyleID == _style

        //                   group items by new {items.Date, items.CuttingHeader.StyleID, items.PoNo,items.LineNo, items.Color, items.Size } into ItemG

        //                   select new { ItemG.Key.Date, ItemG.Key.StyleID, ItemG.Key.PoNo, ItemG.Key.LineNo, ItemG.Key.Color, ItemG.Key.Size, NoPcs = ItemG.Sum(c => c.NoOfItem) }).ToList();


                

        //        foreach (var i in list) {


        //            var stock = (from x in _context.CuttingStock
        //                        where x.Date == i.Date && x.StyleNo == i.StyleID && x.PoNo == i.PoNo && x.ProductionLineNo == i.LineNo && x.Color == i.Color && x.Size == i.Size

        //                         select new { x.CompletePcs, x.LineIn, x.HtechIn }).ToList();

        //            int CPcs = 0;
        //            int hIn = 0;
        //            int lIn = 0;
        //            try {

        //                foreach (var selected in stock)
        //                {

        //                    CPcs = selected.CompletePcs;
        //                    hIn = selected.HtechIn;
        //                    lIn = selected.LineIn;

                         
        //                }

        //            }
        //            catch (Exception ex) {
        //            }

        //            CuttingStock _stock = new CuttingStock(i.Date, i.StyleID, i.PoNo, i.LineNo, "", i.Color, i.Size, i.NoPcs, CPcs, lIn, hIn);
        //            lstCutting.Add(_stock);



        //        }



        //        grdSearchStyle.DataSource = lstCutting;

        //        //grid custumizations
        //        gridView2.Columns["CompanyID"].Visible = false;
        //        gridView2.Columns["Company"].Visible = false;
        //        gridView2.Columns["CreatedBy"].Visible = false;
        //        gridView2.Columns["CreatedTime"].Visible = false;
        //        gridView2.Columns["CreatedDate"].Visible = false;
        //        gridView2.Columns["LastModifiedBy"].Visible = false;
        //        gridView2.Columns["LastModifiedAt"].Visible = false;
                
        //        gridView2.Columns["CuttingStockQty"].Visible = false;

        //        gridView2.Columns["ProductionLineNo"].Width = 120;
        //        gridView2.Columns["StyleNo"].Width = 120;
        //        gridView2.Columns["Date"].Width = 120;
        //        gridView2.Columns["NoPcs"].Width = 60;
        //        gridView2.Columns["HtechIn"].Width = 60;
        //        gridView2.Columns["LineIn"].Width = 60;



        //    }
        //    catch (Exception ex) {
        //    }

        //}




        //void UpdateItem() {
        //    try {
        //        CuttingStock stock = new CuttingStock();
        //        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        //        foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
        //        {
        //            stock.CompanyID = item.CompanyID;

        //        }
        //        for (int i = 0; i < gridView2.RowCount ; i++)
        //        {

        //            stock.Date =Convert.ToDateTime(gridView2.GetRowCellValue(i, "Date").ToString());
        //            stock.StyleNo = gridView2.GetRowCellValue(i, "StyleNo").ToString();
        //            stock.PoNo = gridView2.GetRowCellValue(i, "PoNo").ToString();
        //            stock.ProductionLineNo = gridView2.GetRowCellValue(i, "ProductionLineNo").ToString();
        //            stock.Color = gridView2.GetRowCellValue(i, "Color").ToString();
        //            stock.Size = gridView2.GetRowCellValue(i, "Size").ToString();
        //            stock.LineIn = Convert.ToInt16( gridView2.GetRowCellValue(i, "LineIn").ToString());
        //            stock.HtechIn = Convert.ToInt16( gridView2.GetRowCellValue(i, "HtechIn").ToString());
        //            stock.NoPcs = Convert.ToInt16(gridView2.GetRowCellValue(i, "NoPcs").ToString());
        //            stock.CompletePcs = Convert.ToInt16(gridView2.GetRowCellValue(i, "CompletePcs").ToString());

        //            if (isItemExist(stock.Date, stock.StyleNo, stock.PoNo, stock.ProductionLineNo,stock.Color,stock.Size) == true)
        //            {
        //                // UpdateItem
        //                GenaricRepository<CuttingStock> _CuttingRepository = new GenaricRepository<CuttingStock>(new ItrackContext());
        //                stock.CreatedDate = DateTime.Now;
        //                stock.CreatedBy = "";
        //                stock.CreatedTime = "";

        //                _CuttingRepository.Update(stock);

        //            }
        //            else
        //            {
        //                // Add Item
        //                GenaricRepository<CuttingStock> _CuttingRepository = new GenaricRepository<CuttingStock>(new ItrackContext());
        //                stock.CreatedDate =  DateTime.Now;
        //                stock.CreatedBy = "";
        //                stock.CreatedTime = "";

        //                _CuttingRepository.Insert(stock);
        //            }
        //        }

        //    }
        //    catch (Exception ex) {

        //    }

        //}


        bool isItemExist(DateTime _date,string _StyleNo,string _Po,string _LineNo,string _color,string _size) {

            try {
                ItrackContext _context = new ItrackContext();
                var items = from item in _context.CuttingStock
                            where item.Date == _date && item.StyleNo == _StyleNo && item.PoNo == _Po && item.ProductionLineNo == _LineNo && item.Color ==_color && item.Size == _size
                            select item;

                if (items.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) {
                return false;
            }

           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //Refresh(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), txtStyleNo.Text);
            //splashScreenManager1.CloseWaitForm();
            //Debug.WriteLine(gridView2.RowCount+ "  Row Count");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //UpdateItem();
        }

        List<dtoCuttingStatusSummary> LstCuttingItem = new List<dtoCuttingStatusSummary>();



        //void Print(DateTime _date) {
        //    try {

        //        ItrackContext _context = new ItrackContext();

        //        int i = 1;
        //        var stock = from item in _context.CuttingStock
        //                   where item.Date == _date.Date
        //                    group item by new {item.StyleNo, item.Date,item.Color,item.PoNo,item.ProductionLineNo} into G
        //                    select new { G.Key.Date,G.Key.StyleNo,G.Key.PoNo,G.Key.ProductionLineNo,G.Key.Color,TableCut=G.Sum(a=>a.NoPcs),  HTechIn=G.Sum(x=>x.HtechIn),LineIn=G.Sum(y=>y.LineIn),CompletePcs=G.Sum(z=>z.CompletePcs)};
        //        foreach (var item in stock)

        //        {
        //            dtoCuttingStatusSummary dto = new dtoCuttingStatusSummary();
        //            dto.Date = item.Date;
        //            dto.Color = item.Color;
        //            dto.StyleNo = item.StyleNo;
        //            dto.LineNo = item.ProductionLineNo;
        //            dto.PoNo = item.PoNo;
        //            dto.TableCut = item.TableCut;
        //            dto.CompletedPcs = item.CompletePcs;
        //            dto.HTechIn = item.HTechIn;
        //            dto.LineIn = item.LineIn;
        //            dto.Nos = i;
        //            i++;

        //            //if (LstCuttingItem.Count == 0)
        //            //{
        //            //    dto.Cumulative = dto.GetCummByStyle(item.StyleNo,item.PoNo,item.ProductionLineNo,item.Date)+dto.CompletedPcs;
        //            //}
        //            //else {
        //            //    dto.Cumulative =dto.CompletedPcs+ dto.GetCumm(LstCuttingItem, item.Date.Date, item.ProductionLineNo, item.StyleNo, item.Color,item.PoNo);
        //            //}

        //            dto.Cumulative = dto.GetCummByStyle(item.StyleNo, item.PoNo, item.ProductionLineNo, item.Date) + dto.CompletedPcs;

        //            dto.TotalHTech = dto.GetTotalHTechByStyle(item.StyleNo, item.PoNo, item.ProductionLineNo, item.Date)+dto.HTechIn;


        //            dto.Stock = dto.Cumulative - dto.TotalHTech;
        //            //if (LstCuttingItem.Count == 0)
        //            //{
        //            //    dto.Stock = dto.Cumulative - dto.HTechIn;
        //            //}
        //            //else {
        //            //    dto.Stock = dto.Cumulative - dto.GetStock(LstCuttingItem, item.Date.Date, item.ProductionLineNo, item.StyleNo, item.Color);
        //            //}
                   
                   
        //            LstCuttingItem.Add(dto);
        //        }


        //       grdCuttingStock.DataSource = LstCuttingItem;
        //        //gridView2.Columns["CompletedPcs"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "CompletedPcs", "Sum={0}");
        //        //GridColumnSummaryItem sum = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "CompletedPcs", "Max={0}");
        //        //gridView2.Columns["CompletedPcs"].Summary.Add(sum);

        //        GridGroupSummaryItem sum = new GridGroupSummaryItem();
        //        sum.FieldName = "CompletedPcs";
        //        sum.ShowInGroupColumnFooter = gridView2.Columns["CompletedPcs"];
        //        sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //        sum.DisplayFormat = "Sum = {0:c2}";
        //        gridView2.GroupSummary.Add(sum);


               



        //    }
        //    catch (Exception ex)
        //    { }
        //}



        private void simpleButton3_Click(object sender, EventArgs e)
        {
            rptCuttingStatus s = new rptCuttingStatus();
            s.DataSource = LstCuttingItem;

            DevExpress.XtraReports.UI.ReportPrintTool tool = new ReportPrintTool(s);
            tool.ShowPreview();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //Print(Convert.ToDateTime(txtDate.Text));

           
            //splashScreenManager1.CloseWaitForm();
        }
    }
    


}