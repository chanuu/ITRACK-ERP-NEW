using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class AssetVerification
    {
        [Key]
        public string AssetVerificationID { get; set; }

        public DateTime Date { get; set; }

        public string LocationCode { get; set; }

        public string VerificationBy { get; set; }

        public string Remark { get; set; }

        public string ApprovedBy { get; set; }

        public Nullable<DateTime> ApprovedAt { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company {get;set;}

        public virtual ICollection<AssetVerificationDetails> AssetVerificationDetails { get; set; }



    }
}
