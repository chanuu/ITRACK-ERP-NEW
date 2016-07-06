using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public class CuttingRatio
    {

        [Key]
        [Column(Order = 1)]
        public string CuttingRatioID { get; set; }

       public string Color { get; set; }

        public string Length { get; set; }

        public double MarkerLength { get; set; }

        public double MarkerWidth { get; set; }

        public string Remark { get; set; }

        public string FabricType { get; set; }

        public virtual Style Style { get; set; }

        public string StyleID { get; set; }

        public virtual ICollection<RatioItem> RatioItem { get; set; }


    }
}
