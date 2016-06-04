using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class CutIssuItem
    {

        public int CutIssuItemID { get; set; }

        public string CutNo { get; set; }

        public string PONo { get; set; }

        public int LotNo { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public int NoOfItem { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public string CutIssueHeaderID { get; set; }

        public virtual CutIssueHeader CutIssueHeader { get; set; }


    }
}
