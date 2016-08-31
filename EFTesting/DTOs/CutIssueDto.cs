using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
  public  class CutIssueDto
    {

        public string PoNo { get; set; }

        public string CutNo { get; set; }

        public string LineNo { get; set; }

        public string MarkerNo { get; set; }

        public int NoOfItem { get; set; }

        public string Color { get; set; }
    }
}
