using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class PrintWorkOrder
    {

        public int Noos { get; set; }

  

        public string StyleNo { get; set; }

        public string LineNo { get; set; }

        public Int64 BundleHeaderId { get; set; }

        public int CuttingItemID { get; set; }

        public string CutNo { get; set; }

        public string PoNo { get; set; }

       
        public int NoofItem { get; set; }

        public int NoOfLayers { get; set; }

        public int BundleSize { get; set; }

        public bool Genarated { get; set; }
    }
}
