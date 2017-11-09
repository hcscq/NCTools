using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_CLUSTER_SLAVE
    {
        public decimal ID_CLUSTER_SLAVE { get; set; }
        public Nullable<decimal> ID_CLUSTER { get; set; }
        public Nullable<decimal> ID_SLAVE { get; set; }
    }
}
