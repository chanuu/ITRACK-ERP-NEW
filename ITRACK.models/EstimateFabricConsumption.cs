using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class EstimateFabricConsumption
    {

        public string EstimateFabricConsumptionID { get; set; }

        public string StyleID { get; set; }

        public string MarkerNo { get; set; }

        public DateTime Date { get; set; }

        public int NoofPlys { get; set; }

        public double SinglePcsConsumtion { get; set; }

        public double TotalFabricUsed { get; set; }

        public int TotalPcs { get; set; }

        public double ActualFabUsed { get; set; }

        public double Defference { get; set; }

        public string CuttingRatioID { get; set; }

        public virtual CuttingRatio CuttingRatio { get; set; }

        public virtual Style Style { get; set; }



    }
}
