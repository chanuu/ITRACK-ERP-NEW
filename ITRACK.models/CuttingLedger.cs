using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class CuttingLedger
    {

        public int TransactionID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 2)]
        public string StyleNo { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Po { get; set; }
        [Key]
        [Column(Order = 4)]
        public string LineNo { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Size { get; set; }

        [Key]
        [Column(Order = 6)]
        public string Color { get; set; }

        [Key]
        [Column(Order = 7)]
        public string TrasctionType { get; set; }

      

        public int TableCut { get; set; }

        public int CompletedPcs { get; set; }

        public int TotalCutOut { get; set; }

        public int Cumulative { get; set; }

        public int LineIn { get; set; }

        public int TotalLineIn { get; set; }

        public int LineInCumm { get; set; }

        public int HTechIn { get; set; }

        public int  TotalHTech { get; set; }

        public int HTCumm { get; set; }


        public int Stock { get; set; }

        public int StockCumm { get; set; }

        public virtual CuttingLedgerHeader CuttingLedgerHeader { get; set; }

        public string CuttingLedgerHeaderID { get; set; }




    }
}
