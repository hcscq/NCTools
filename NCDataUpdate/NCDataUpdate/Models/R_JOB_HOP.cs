using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOB_HOP
    {
        public decimal ID_JOB_HOP { get; set; }
        public Nullable<decimal> ID_JOB { get; set; }
        public Nullable<decimal> ID_JOBENTRY_COPY_FROM { get; set; }
        public Nullable<decimal> ID_JOBENTRY_COPY_TO { get; set; }
        public string ENABLED { get; set; }
        public string EVALUATION { get; set; }
        public string UNCONDITIONAL { get; set; }
    }
}
