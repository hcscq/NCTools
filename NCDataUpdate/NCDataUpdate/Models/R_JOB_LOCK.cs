using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOB_LOCK
    {
        public decimal ID_JOB_LOCK { get; set; }
        public Nullable<decimal> ID_JOB { get; set; }
        public Nullable<decimal> ID_USER { get; set; }
        public string LOCK_MESSAGE { get; set; }
        public Nullable<System.DateTime> LOCK_DATE { get; set; }
    }
}
