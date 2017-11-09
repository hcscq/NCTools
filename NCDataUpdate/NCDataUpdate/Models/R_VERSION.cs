using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_VERSION
    {
        public decimal ID_VERSION { get; set; }
        public Nullable<decimal> MAJOR_VERSION { get; set; }
        public Nullable<decimal> MINOR_VERSION { get; set; }
        public Nullable<System.DateTime> UPGRADE_DATE { get; set; }
        public string IS_UPGRADE { get; set; }
    }
}
