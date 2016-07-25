using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class SerialEntry
    {
        public string SerialEntryID { get; set; }

        public string RollNo { get; set; }

        public Int32 SRNo { get; set; }

        public double TotalMeters { get; set; }

        public string Color { get; set; }

        public double RollWidth { get; set; }

        public string Shade { get; set; }

        public double Shrinkage { get; set; }

        public virtual ICollection<SpecialEntry> SpecialEntry { get; set; }

        public string ItemsID { get; set; }

        public virtual Items Items { get; set; }

       public string SpecialEntryID { get; set; }





    }
}
