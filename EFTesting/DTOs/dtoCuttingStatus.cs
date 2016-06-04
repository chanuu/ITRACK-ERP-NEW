using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
   public class dtoCuttingStatusSummary
    {

        public int Nos { get; set; }

        public DateTime Date { get; set; }


        public string StyleNo { get; set; }

        public string PoNo { get; set; }

        public string Color { get; set; }


        public string LineNo { get; set; }


        public int TableCut { get; set; }

        public int CompletedPcs { get; set; }

        public int Cumulative { get; set; }

        public int HTechIn { get; set; }

        public int TotalHTech { get; set; }
        public int LineIn { get; set; }


        public int Stock { get; set; }




        public int GetCumm(List<dtoCuttingStatusSummary> lst,DateTime _date,string _line ,string _style,string _color,string _PoNo)
        {
            try {

                int total = 0;
                if (lst.Count > 0)
                {
                   // total = lst.Sum(x => x.CompletedPcs);


                 total =    (from item in lst

                     where item.Date == _date.Date && item.LineNo == _line && item.StyleNo == _style && item.Color == _color && item.PoNo == _PoNo

                     select item.CompletedPcs).ToList().Sum();

                }
                else {
                    total = 0;
                }

                return total;
            }
            catch (Exception ex) {
                return 0;
            }
        }




       

        public int GetTotalHTechByStyle(string _style, string _po, string _line, DateTime _date)
        {
            try
            {
                ItrackContext context = new ItrackContext();

                return (from item in context.CuttingStock
                        where
                item.StyleNo == _style && item.PoNo == _po && item.ProductionLineNo == _line && item.Date < _date
                        select item.HtechIn
                        ).ToList().Sum();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int GetStock(List<dtoCuttingStatusSummary> lst, DateTime _date, string _line, string _style, string _color)
        {
            try
            {

                int total = 0;
                if (lst.Count > 0)
                {
                    // total = lst.Sum(x => x.CompletedPcs);

                    total = (from item in lst

                             where item.Date == _date.Date && item.LineNo == _line && item.StyleNo == _style && item.Color == _color

                             select item.HTechIn).ToList().Sum();

                }
                else
                {
                    total = 0;
                }

                return total;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
