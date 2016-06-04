using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class CuttingStock
    {

        [Key]
        [Column(Order = 1)]
        public DateTime Date { get; set; }


        [Key]
        [Column(Order = 2)]
        public string StyleNo { get; set; }


        [Key]
        [Column(Order =3)]
        public string PoNo { get; set; }

        [Key]
        [Column(Order = 4)]
        public string ProductionLineNo { get; set; }


        public string FabricType { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Color { get; set; }
        [Key]
        [Column(Order = 6)]
        public string Size { get; set; }

        [Key]
        [Column(Order = 7)]
        public string TNoteNo { get; set; }

        public int HtechIn { get; set; }

        public int LineIn { get; set; }


        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    public  CuttingStock (
            DateTime _date,
            string _styleNo,
            string _poNo,
            string _lineNo,
            string _fabType,
            string _color,
            string _Size,
            int _TableCut,
            int _CompletePcs,
            int _LineIn,
            int _HtechIn

            ) {

            this.Date = _date;
            this.StyleNo = _styleNo;
            this.PoNo = _poNo;
            this.ProductionLineNo = _lineNo;
            this.FabricType = _fabType;
            this.Color = _color;
            this.Size = _Size;
         
            this.LineIn = _LineIn;
            this.HtechIn = _HtechIn;


        }

      public  CuttingStock()
        {

        }


    }
}
