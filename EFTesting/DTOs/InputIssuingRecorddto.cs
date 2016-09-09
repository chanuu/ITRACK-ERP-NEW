using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
    public class InputIssuingRecorddto
    {
        public string StyleNo { get; set; }

        public DateTime Date { get; set; }

        public string LineNo { get; set; }

        public string PONo { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int NoOfItem { get; set; }

    }

}
