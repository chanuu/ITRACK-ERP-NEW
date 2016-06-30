using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class StyleLoading
    {

        [Key]
        [Column(Order = 1)]
        public int StyleLoadingID { get; set; }


       
        public string LocationCode { get; set; }

        public string LineNo { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    

         public string StyleID { get; set; }

       

        public virtual Style Style { get; set; }





    }
}
