﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.DTOs
{
  public  class FabricUtilizationdto
    {
        public int FabricLedgerID { get; set; }

        public string StyleNo { get; set; }

        public string MarkerNo { get; set; }

        public string RollNo { get; set; }

        public double NotedLength { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }

        public double MarkerLength { get; set; }

        public int NoOfFlys { get; set; }

        public double FabricUsed { get; set; }

        public double NotedBalance { get; set; }

        public double ActualBalance { get; set; }

        public double Shortage { get; set; }

       
    }
}
