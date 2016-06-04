using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class CutIssueHeader
    {

    
        public string CutIssueHeaderID { get; set; }

        public DateTime Date { get; set; }

        public string StyleNo { get; set; }

        public string Type { get; set; }


        public string LineNo { get; set; }

        public string InputRequestedBy { get; set; }

        public string Remark { get; set; }

        public virtual Style Style { get; set; }

        public virtual ICollection<CutIssuItem> CutIssuItem { get; set; }



    }
}
