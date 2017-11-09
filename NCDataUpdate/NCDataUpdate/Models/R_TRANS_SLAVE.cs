using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_TRANS_SLAVE
    {
        public decimal ID_TRANS_SLAVE { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_SLAVE { get; set; }
    }
}
