using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class SpecialEntry
    {
        public string SpecialEntryID { get; set; }

        public string PoNo { get; set; }

        public string GrnNo { get; set; }

        public string Date { get; set; }

        public string DispatchNo { get; set; }

        public string TotalRollQty { get; set; }

        public string TotalLength { get; set; }

        public string Remarks { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual SerialEntry SerialEntry { get; set; }

        public string SerialEntryID { get; set; }


    }
}
