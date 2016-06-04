using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class AssetLedger
    {

        public string LocationCode { get; set; }

        [Key]
        public string TransactionID { get; set; }

        public DateTime Date { get; set; }

        public string AssetID { get; set; }

        public string DocType { get; set; }

        public string DocNo { get; set; }

        public string AssetType { get; set; }

        public string UsedBy { get; set; }

        public string Status { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


        public bool FeedAssetLedger(AssetLedger _ledger)
        {

            try
            {

                GenaricRepository<AssetLedger> _AssetLedgerRepo = new GenaricRepository<AssetLedger>(new ItrackContext());
                _AssetLedgerRepo.Insert(_ledger);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }



        }

    }
}
