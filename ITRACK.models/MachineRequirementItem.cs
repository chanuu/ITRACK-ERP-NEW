using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class MachineRequirementItem
    {

        [Key]
        [Column(Order = 1)]
        public int MachineRequirementItemID { get; set; }

       

        public string MachineType { get; set; }

        public int Nos { get; set; }

        public string Remark { get; set; }

        public virtual MachineRequirement MachineRequirement { get; set; }

        public string MachineRequirementID { get; set; }


    }
}
