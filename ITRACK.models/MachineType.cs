using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class MachineType
    {
        public string MachineTypeID { get; set; }

        public string MachineTypeName { get; set; }


        public string Remark { get; set; }

        public string GroupID { get; set; }

        public virtual Group Group { get; set; }
    }
}
