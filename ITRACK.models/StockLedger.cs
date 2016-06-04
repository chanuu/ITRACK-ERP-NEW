using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITRACK.models;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace ITRACK.models
{
   public class StockLedger
    {

       [Key]
        public string TransactionID { get; set; }

        public string ItemCode { get; set; }

        public string ItemType { get; set; }

        public string Category { get; set; }

        public string TransactionType { get; set; }

        public string DocNo { get; set; }

        public DateTime TransactionTime { get; set; }

        public string TransactionBy { get; set; }


        public double Qty { get; set; }

        public double Balance { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }



        public double getAvailableBalance(string _ItemCode)
        {
            try {

                ItrackContext context = new ItrackContext();
                return (from item in context.StockLedger
                        where item.ItemCode == _ItemCode
                        select item).ToList().Last().Qty;
                

            }
            catch (Exception ex) {
                return 0;
            }

        }



        public bool FeedLedger(StockLedger _ledger) {

            try {

                GenaricRepository<StockLedger> _GRNRepo = new GenaricRepository<StockLedger>(new ItrackContext());               
                _GRNRepo.Add(_ledger);
                return true;
            }
            catch (Exception ex) {
                return false;
            }



        }


        public double GetAvailBalance(string _itemcode) {
            try {
                ItrackContext context = new ItrackContext();
                return (from item in context.StockLedger
                        where
                        item.ItemCode == _itemcode
                        select new { item.Balance }).ToList().Last().Balance;

                        
            }
                       
            catch (Exception ex) {
                return 0;
            }

        }


        public string GetTransactionID()
        {
            try
            {

                RunningNo _No = new RunningNo();
                string _Code = "";
               // clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "TR"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    _Code = _No.GenarateNo(_No, getLedgerCount());


                }
                return _Code;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "";
            }

        }


        int getLedgerCount()
        {
            try
            {
                GenaricRepository<StockLedger> _LedgerRepo = new GenaricRepository<StockLedger>(new ItrackContext());
                return _LedgerRepo.GetAll().ToList().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }



    }
}
