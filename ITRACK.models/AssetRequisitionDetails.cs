using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class AssetRequisitionDetails
    {
        public int AssetRequisitionDetailsID { get; set; }

        public string AssetNo { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public virtual AssetBarcode AssetBarcode { get; set; }

        public virtual AssetRequisition AssetRequisition { get; set; }

        public string AssetRequisitionID { get; set; }



    }
}
