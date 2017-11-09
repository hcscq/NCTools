using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOBENTRY
    {
        public decimal ID_JOBENTRY { get; set; }
        public Nullable<decimal> ID_JOB { get; set; }
        public Nullable<decimal> ID_JOBENTRY_TYPE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
