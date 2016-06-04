using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class OfflineAssetScan
    {
        public int OfflineAssetScanID { get; set; }

        public string ScanTime { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }

    }
}
