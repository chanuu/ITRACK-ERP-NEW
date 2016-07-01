using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class Department
    {
        [Key]
        public Int32 DepartmentID { get; set; }

        public string Name { get; set; }
        public string Remark { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }
    }
}
