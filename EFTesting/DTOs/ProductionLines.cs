using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
    class ProductionLines
    {
        public int ID { get; set; }

        public string ProductionLine { get; set; }

        public string Description { get; set; }


        List<ProductionLines> lstPro = new List<ProductionLines>();
        public List<ProductionLines> Seed() {



            lstPro.Add(new ProductionLines { ID=1,ProductionLine="V-1",Description="N/A" });
            lstPro.Add(new ProductionLines { ID = 2, ProductionLine = "V-2", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 3, ProductionLine = "V-3", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 4, ProductionLine = "V-4", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 5, ProductionLine = "V-5", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 6, ProductionLine = "V-6", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 7, ProductionLine = "V-7", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 8, ProductionLine = "V-8", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 9, ProductionLine = "V-9", Description = "N/A" });
            lstPro.Add(new ProductionLines { ID = 10, ProductionLine = "V-10", Description = "N/A" });





            return lstPro;
        }

        
    }
}
