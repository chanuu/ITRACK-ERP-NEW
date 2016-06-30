using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class CuttingLedgerHeader:BaseEntity
    {

        [Key]
        [Column(Order = 1)]
        public string CuttingLedgerHeaderID { get; set; }

       
        public string Remark { get; set; }


        public virtual ICollection<CuttingLedger> CuttingLedger { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    }
}
