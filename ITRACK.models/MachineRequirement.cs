using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class MachineRequirement :BaseEntity
    {
        public string MachineRequirementID { get; set; }

        public string StyleNo { get; set; }

        public string LineNo { get; set; }

        public string Remark { get; set; }

        public string LocationCode { get; set; }

        public virtual ICollection<MachineRequirementItem> MachineRequirementItem { get; set; }

        public string StyleID { get; set; }

        public virtual Style Style { get; set; }
    }
}
