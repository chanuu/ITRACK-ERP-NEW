using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class CuttingLedgerHeader:BaseEntity
    {


        public string CuttingLedgerHeaderID { get; set; }
        public string Remark { get; set; }


        public virtual ICollection<CuttingLedger> CuttingLedger { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    }
}
