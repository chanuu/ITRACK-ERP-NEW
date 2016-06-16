using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class MachineRequirementItem
    {

        public int MachineRequirementItemID { get; set; }

        public string MachineType { get; set; }

        public int Nos { get; set; }

        public string Remark { get; set; }

        public virtual MachineRequirement MachineRequirement { get; set; }

        public string MachineRequirementID { get; set; }


    }
}
