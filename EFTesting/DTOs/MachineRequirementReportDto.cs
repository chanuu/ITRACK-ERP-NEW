using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class MachineRequirementReportDto
    {
        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string StyleNo { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Type { get; set; }

        public string MachineType { get; set; }

        public int Qty { get; set; }



    }
}
