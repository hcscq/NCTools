using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_TRANS_PARTITION_SCHEMA
    {
        public decimal ID_TRANS_PARTITION_SCHEMA { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_PARTITION_SCHEMA { get; set; }
    }
}
