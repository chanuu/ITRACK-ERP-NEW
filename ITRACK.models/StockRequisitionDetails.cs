using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class StockRequisitionDetails
    {
        public int StockRequisitionDetailsID { get; set; }

        public string ItemCode { get; set; }

        public string Description { get; set; }

        public double AvailableBalance { get; set; }

        public int RequestedQty { get; set; }

        public virtual Items Items { get; set; } 

        public virtual StockRequisition StockRequisition { get; set; }

        public string StockRequisitionID { get; set; }
    }
}
