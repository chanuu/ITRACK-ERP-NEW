using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class RentManagement
    {
        public string RentManagementID { get; set; }

        public string MachineType { get; set; }

        public string MachineSerialNo { get; set; }

        public string AssetBarcode { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Remark { get; set; }
    }
}
