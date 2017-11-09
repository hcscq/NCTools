using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_DATABASE_ATTRIBUTE
    {
        public decimal ID_DATABASE_ATTRIBUTE { get; set; }
        public Nullable<decimal> ID_DATABASE { get; set; }
        public string CODE { get; set; }
        public string VALUE_STR { get; set; }
    }
}
