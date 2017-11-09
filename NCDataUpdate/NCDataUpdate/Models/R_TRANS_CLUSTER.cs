using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_TRANS_CLUSTER
    {
        public decimal ID_TRANS_CLUSTER { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_CLUSTER { get; set; }
    }
}
