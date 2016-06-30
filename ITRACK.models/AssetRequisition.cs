using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class AssetRequisition
    {
        public string AssetRequisitionID { get; set; }

        public string LocationCode { get; set; }

        public string CompanyCode { get; set; }

        public string DocumentType { get; set; }

        public DateTime  DocumentDate { get; set; }

        public string TargetLocationCode { get; set; }

        public virtual ICollection <AssetRequisitionDetails> AssetRequisitionDetails { get; set; }

        public int AssetRequisitionDetailsID { get; set; }




    }
}
