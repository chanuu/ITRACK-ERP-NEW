using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class FabricConsumption
    {
        public int FabricConsumptionID { get; set; }

        public string StyleNo { get; set; }

        public string PoNo { get; set; }

        public string MarkerNo { get; set; }

        public DateTime Date { get; set; }

        public double EstimateConsumtion { get; set; }

        public double ActualConsumption { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    }
}
