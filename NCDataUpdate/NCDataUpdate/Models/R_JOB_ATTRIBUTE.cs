using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOB_ATTRIBUTE
    {
        public decimal ID_JOB_ATTRIBUTE { get; set; }
        public Nullable<decimal> ID_JOB { get; set; }
        public Nullable<decimal> NR { get; set; }
        public string CODE { get; set; }
        public Nullable<decimal> VALUE_NUM { get; set; }
        public string VALUE_STR { get; set; }
    }
}
