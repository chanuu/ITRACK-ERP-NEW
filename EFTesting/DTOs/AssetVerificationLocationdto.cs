using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.UI.DTO
{
    public class AssetVerificationLocationdto
    {
        public int No { get; set; }

        public string Model { get; set; }
    
        public string AssetLocation { get; set; }

        public int Available { get; set; }

        public DateTime Date { get; set; }

        public string AssetVerificationNo { get; set; }

    }
}
