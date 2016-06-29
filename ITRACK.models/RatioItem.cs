using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class RatioItem
    {
        public int RatioItemID { get; set; }

        public string Size { get; set; }

        public int Lot { get; set; }

        public string CuttingRatioID { get; set; }

        public virtual CuttingRatio CuttingRatio { get; set; }

       
    }
}
