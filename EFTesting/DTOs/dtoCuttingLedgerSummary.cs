using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class dtoCuttingLedgerSummary
    {
        public int Nos { get; set; }

        public DateTime Date { get; set; }

     
        public string StyleNo { get; set; }

       
        public string Po { get; set; }
       
        public string LineNo { get; set; }

        
        public string Size { get; set; }

        
        public string Color { get; set; }

        public string TrasctionType { get; set; }

        public int TableCut { get; set; }

        public int CompletedPcs { get; set; }

        public int Cumulative { get; set; }

        public int LineIn { get; set; }

        public int TotalLineIn { get; set; }

        public int HTechIn { get; set; }

        public int TotalHTech { get; set; }

        public int Stock { get; set; }

        public int StockCumm { get; set; }

        public int HTCumm { get; set; }

        public int LInCumm { get; set; }

        public int OrderQty { get; set; }

        public int Balance { get; set; }


        public Nullable<System.DateTime> FOBDate { get; set; }
    }
}
