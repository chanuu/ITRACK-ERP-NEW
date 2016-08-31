using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
   public class GenarateTags
    {

       private Int64 LastBundleNo = 0;
       private Int64 LastTagNo;
       private string LastCutNo;
       private Int64 NoOfBundle;
       private Int64 Remain;
       private bool isSmallBundleExist = false;
       BundleDetails _bandleDetails = new BundleDetails();
       OprationBarcodes _barcode = new OprationBarcodes();

       public bool genarateBundle(int _noOfLayer,int _noOfItem,int _bundleSize,string _styleNo) {
           try {

               LastBundleNo = GetLastBundleNo(_styleNo);
               NoOfBundle = _noOfLayer / _bundleSize;

               Remain = _noOfLayer -  NoOfBundle * _bundleSize;

               if (Remain > 0)
               {
                   NoOfBundle = NoOfBundle + 1;
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
                   NoOfBundle = NoOfBundle - 1;
                   isSmallBundleExist = true;
               }
               else {
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
              
               
               }

               Debug.WriteLine(_bundleSize + "*" + NoOfBundle);
               Debug.WriteLine(Remain + "*" + 1);


               for (int y = 1; y <= _noOfItem; y++) 
               {
              
                  LastBundleNo = 0;
                
                   for (int i = 0; i < NoOfBundle; i++)
                       {

                           Debug.WriteLine("Bundle ID : + " + ((y - 1) * NoOfBundle + i+1).ToString().PadLeft(10, '0') + " |    No of Item" + _bundleSize + " |  Cut No" + y);
                           LastBundleNo = i + 1;
                       }


                       if (isSmallBundleExist == true)
                       {
                           Debug.WriteLine("Bundle ID : + " + ((y-1) *NoOfBundle+ LastBundleNo).ToString().PadLeft(10, '0') + " |    No of Item" + Remain + " |  Cut No" + y);
                       }

              
                   Debug.WriteLine("Cut No -"+y);
               
               }

                   



                   return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }






    

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public bool addBundleDetails(BundleDetails _bandle,Int64 _bundleHeaderID) {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());
               _bandle.BundleHeaderID = _bundleHeaderID;

               _bandle.BundleTagPrintedBy = "None";
               _bandle.BundleTagPrintedTime = "None";
               _bandle.isBundleTagsPrinted = false;
               _bandle.BundleStickerPrintedBy = "None";
               _bandle.BundleStickerPrintedTime = "None";
               _bandle.BundleTagPrintedBy = "None";
               _bandle.LineInTime=Convert.ToDateTime("1900-01-01 00:00:00.000");
               _bandle.LineOutTime = Convert.ToDateTime("1900-01-01 00:00:00.000");
               _bandle.HTechInTime = Convert.ToDateTime("1900-01-01 00:00:00.000");
               _bandle.WHouseInTime = Convert.ToDateTime("1900-01-01 00:00:00.000");
             


               _BundleDetails.Insert(_bandle);
               
               
               return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>

       private string GetLastCutNo()
       {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());
               return  _BundleDetails.GetAll().ToList().Last().CutNo;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return "";
           }
       }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       private int GetLastBundleNo(string _styleNo) {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());

                ItrackContext context = new ItrackContext();
                return Convert.ToInt16( (from item in context.BundleDetails
                       where item.BundleHeader.CuttingItem.CuttingHeader.StyleID == _styleNo 
                                         orderby item.BundleDetailsID
                       select new { item.SerailNo }).ToList().Last().SerailNo);


              // return Convert.ToInt16(_BundleDetails.GetAll().Where(y => y.BundleHeader.CuttingItem.CuttingHeader.StyleID== _styleNo  ).OrderBy(x=>x.BundleDetailsID).ToList().Last().SerailNo);
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return 0;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       private Int64 GetLastTagNo()
       {
           try
           {
                ItrackContext context = new ItrackContext();
                return Convert.ToInt64((from item in context.Workflow
                                        select item.WorkflowName).ToList().Last());


               
           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;
           }
       }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_OprationNo"></param>
        /// <returns> </returns>

       private string GetOprationRole(string _OprationNo) {
           try {
               GenaricRepository<OperationPool> _oprationRepo = new GenaricRepository<OperationPool>(new ItrackContext());
               Debug.WriteLine(_oprationRepo.GetAll().ToList().Where(x => x.OperationPoolID == _OprationNo).Last().OprationRole);
               return  _oprationRepo.GetAll().ToList().Where(x => x.OperationPoolID == _OprationNo).Last().OprationRole;

 
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return "";
           }
       }
      

       /// <summary>
       /// 
       /// </summary>
       /// <param name="_bundleDetails"></param>
       /// <param name="_ditem"></param>
       /// <returns></returns>
       public bool OprationTags(BundleDetails _bundleDetails,string _style,List<OprationBarcodes> barList,string _cutNo,string _stID) {
           try {

               if (barList.Count > 0)
               {
                   LastTagNo = Convert.ToInt64(barList.Last().OprationBarcodesID) + 1;
               }
               else {

                   LastTagNo = GetLastTagNo() + 1;
               }
               
            



                   GenaricRepository<DividingPlanHeader> _DividingPlanHeader = new GenaricRepository<DividingPlanHeader>(new ItrackContext());
                   GenaricRepository<DividingPlanItem> _DividingPlanItemRepo = new GenaricRepository<DividingPlanItem>(new ItrackContext());
                   

                 //  var dividingHeader = from item in _DividingPlanHeader.GetAll().ToList() where item.StyleID == _style && item.LineNo == _LineNo  select item;

                

                ItrackContext cont = new ItrackContext();

                var dividing = (from item in cont.DividingPlanHeader
                               where item.StyleID == _style 
                               select new { item.DividingPlanheaderID }).ToList();

                   if (dividing.Count() > 0) 
                   {

                       int dividingheaderID = dividing.Last().DividingPlanheaderID;

                     //  int count = _DividingPlanItemRepo.GetAll().Count();
                       int currentTagNo = 0;
                       bool needSave = false;


                    ItrackContext context = new ItrackContext();
                    var divdingItems = from x in context.DividingPlanItem
                                       where x.DividingPlanHeaderID == dividingheaderID
                                       orderby x.PartName
                                       select x;

                    //    foreach (var item in _DividingPlanItemRepo.GetAll().Where(x => x.DividingPlanHeaderID == dividingheaderID).OrderBy(x => x.PartName).ToList())

                    foreach (var item in divdingItems)

                    {

                           GenaricRepository<OprationBarcodes> _OprationTagsRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());

                           _barcode.OprationBarcodesID = LastTagNo.ToString().PadLeft(6, '0');
                           _barcode.OprationNO = item.OprationNo;
                        //   _barcode.OprationRole =  GetOprationRole(_barcode.OprationNO);

                           _barcode.OprationRole = "None";
                           
                           _barcode.OprationGrade = "A";
                           _barcode.PartName = item.PartName;
                           _barcode.OparationName = item.OprationName;
                           _barcode.EmployeeID = "None";
                           _barcode.isOparationComplete = false;
                           _barcode.OprationComplteAt = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                           _barcode.BundleDetailsID = _bundleDetails.BundleDetailsID;
                           _barcode.StyleNo = _style;
                           _barcode.LineNo = "N/A";
                           _barcode.OperationPoolID = item.OprationNo;
                           _barcode.WorkstationNo = item.WorkstationNo;
                           _barcode.OpNo = item.OpNo;
                           _barcode.CutNo = _cutNo;
                           _barcode.StyleID = _stID;

                           barList.Add( new OprationBarcodes(_barcode.OprationBarcodesID,_barcode.LineNo,_barcode.StyleNo, _barcode.OprationNO, _barcode.OparationName, _barcode.OprationGrade, _barcode.OprationRole, _barcode.PartName, _barcode.isOparationComplete, _barcode.OprationComplteAt, _barcode.EmployeeID, _barcode.BundleDetailsID,_barcode.OperationPoolID,"0", item.WorkstationNo,item.OpNo,_barcode.CutNo,_barcode.StyleID));
                        //   barList.Add(_barcode);


                            Debug.WriteLine(_barcode.OprationBarcodesID);
                        //   _OprationTagsRepo.InsertLongOpration(_barcode,needSave);




                           LastTagNo = LastTagNo + 1;

                           



                       }




                   




               }
                AddLastTag(Convert.ToString(LastTagNo - 1));
                //   Debug.WriteLine(lstBarcodes.Count + "List Of Barcode ");

                return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }




        public bool AddLastTag(string _no){

            GenaricRepository<Workflow> _BundleDetails = new GenaricRepository<Workflow>(new ItrackContext());
            Workflow w = new Workflow();
            w.WorkflowName = _no;
            w.Remark = "Tags";
            if (_BundleDetails.Insert(w) == true)
            {
                return true;
            }
            else {
                return false;
            }
            

        }


       public void genarateTestData() {
           try {
           

               for(int i = 0 ; i <6000000; i++){
                
                   
                           GenaricRepository<OprationBarcodes> _OprationTagsRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());

                           _barcode.OprationBarcodesID = i.ToString().PadLeft(14, '0');
                           _barcode.OprationNO = "A";
                           _barcode.OprationRole = "";
                           _barcode.OprationGrade = "A";
                           _barcode.PartName = "";
                           _barcode.OparationName = "A"+i;
                           _barcode.EmployeeID = "None";
                           _barcode.isOparationComplete = false;
                           _barcode.OprationComplteAt = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                           _barcode.BundleDetailsID = 449;
                           _OprationTagsRepo.Insert(_barcode);
               
               }
           
           }
           catch(Exception ex){

               Debug.WriteLine(ex.Message);
           
           }
       
       }












       /// <summary>
       /// 
       /// </summary>
       /// <param name="_noOfLayer"></param>
       /// <param name="_noOfItem"></param>
       /// <param name="_bundleSize"></param>
       /// <param name="_bandleHeader"></param>
       /// <returns></returns>
       public bool GenrateBundleTags(int _noOfLayer, int _noOfItem, int _bundleSize,Int64 _bandleHeader,string _styneNo,List<OprationBarcodes> list,string _styleNo,string _cutNo,string _stID)
       {
           try {

                if (LastBundleNo == 0)
                {
                    LastBundleNo = GetLastBundleNo(_styleNo);
                }
                else
                {
                    LastBundleNo = LastBundleNo + 1;
                }
               
               LastCutNo = _cutNo;
               NoOfBundle = _noOfLayer / _bundleSize;

               Remain = _noOfLayer - NoOfBundle * _bundleSize;

               if (Remain > 0)
               {
                   NoOfBundle = NoOfBundle + 1;
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
                   NoOfBundle = NoOfBundle - 1;
                   isSmallBundleExist = true;
               }
               else
               {
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);


               }


               for (int i = 0; i < _noOfItem; i++)
               {



                   Debug.WriteLine("Cut No :" + i);
                   LastCutNo = LastCutNo + 1;
                   for (int j = 0; j < NoOfBundle; j++)
                   {

                       
                       LastBundleNo = LastBundleNo + 1;

                      // Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + _bundleSize + "  Cut No :" + i);
                       _bandleDetails.CutNo = LastCutNo;
                       _bandleDetails.SerailNo = LastBundleNo.ToString().PadLeft(10, '0');
                       _bandleDetails.BundleNo = Convert.ToInt32(LastBundleNo);
                       _bandleDetails.NoOfItem = _bundleSize;

                       // add Bundle Details 
                       addBundleDetails(_bandleDetails, _bandleHeader);
                       

                       //genarate opration Barcode tags 
                       OprationTags(_bandleDetails,_styneNo,list,_cutNo,_stID);



                   }

                   if (isSmallBundleExist == true) {
                       // increment samll bundle current bandle no
                       LastBundleNo = LastBundleNo + 1;

                    //   Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + Remain + "  Cut No :" + i);
                       _bandleDetails.CutNo = LastCutNo;
                       _bandleDetails.SerailNo = LastBundleNo.ToString().PadLeft(10, '0');
                       _bandleDetails.BundleNo =Convert.ToInt32(LastBundleNo);
                       _bandleDetails.NoOfItem = Remain;
                      // add bundle details of small bundle 
                       addBundleDetails(_bandleDetails, _bandleHeader);

                       // add opration tag barcode of small bundle 
                       OprationTags(_bandleDetails, _styneNo, list,_cutNo, _stID);
                   
                   }




               }


                   return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       
       }
    }
}
