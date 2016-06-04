using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class AssetVerificationDetails
    {
        public int AssetVerificationDetailsID { get; set; }

        public string AssetID { get; set; }

        public string RefNo { get; set; }

        public string UserdBy { get; set; }

        public string Condition { get; set; }

        public string Remark { get; set; }

        public string AssetVerificationID { get; set; }

        public virtual AssetVerification AssetVerification { get; set; }

        public virtual AssetBarcode AssetBarcode { get; set; }

        public string AssetBarcodeID { get; set; }

    }
}
