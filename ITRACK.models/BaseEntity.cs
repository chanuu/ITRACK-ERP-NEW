using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class BaseEntity
    {

        public string CreatedBy { get; set; }

        public string CreatedTime { get; set; }

       

        public Nullable<System.DateTime> CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }


        public string LastModifiedAt { get; set; }


     public  void UpdateLastModified(string _query) {
            ItrackContext context = new ItrackContext();
            context.Database.ExecuteSqlCommand(_query);
        }



    }
}
