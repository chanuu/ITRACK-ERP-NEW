using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class PurchaseOrderHeader:BaseEntity
    {

        [Key]
        [Column(Order = 1)]
        public string PurchaseOrderHeaderID { get; set; }


        public string PoNo { get; set; }

        public string DeliveryTerms { get; set; }

        public bool PlaceWashingFactory { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public string Remark { get; set; }

        public bool isOpen { get; set; }
        public virtual Style Style { get; set; }

        public string StyleID { get; set; }

        public virtual ICollection<PurchaseOrderItems> PurchaseOrderItems { get; set; }

    }
}
