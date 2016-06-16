using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class MachineListdto
    {

        public int No { get; set; }

        public string MachineType { get; set; }

        public int RequiredMachine { get; set; }

        public int AvailableMachine { get; set; }

        public int Variance { get; set; }

        public string Location { get; set; }
    }
}
