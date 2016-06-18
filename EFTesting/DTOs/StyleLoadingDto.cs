using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class StyleLoadingDto
    {
        public string StyleNo { get; set; }

        public string LineNo { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Complete { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }


    }
}
