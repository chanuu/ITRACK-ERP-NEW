using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
   public class clsRuningNoEngine
    {
        public RunningNo Nos { get; set; }


        public string GenarateNo(RunningNo _Nos,int  Count)
        {

            try {

                int CurrentNo =   Count+1;
                _Nos.Code = _Nos.Prefix + CurrentNo.ToString().PadLeft(_Nos.Length,'0');
                return _Nos.Code;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        }


        public string Genarate(RunningNo _Nos, string Code)
        {

            try
            {

                int CurrentNo = Convert.ToInt16(Code.Remove(0, _Nos.Prefix.Length)) + 1;
               _Nos.Code = _Nos.Prefix + CurrentNo.ToString().PadLeft(_Nos.Length, '0');
                return _Nos.Code;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }








    }
}
