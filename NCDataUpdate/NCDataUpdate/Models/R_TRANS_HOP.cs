using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_TRANS_HOP
    {
        public decimal ID_TRANS_HOP { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_STEP_FROM { get; set; }
        public Nullable<decimal> ID_STEP_TO { get; set; }
        public string ENABLED { get; set; }
    }
}
