using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOBENTRY_COPY
    {
        public decimal ID_JOBENTRY_COPY { get; set; }
        public Nullable<decimal> ID_JOBENTRY { get; set; }
        public Nullable<decimal> ID_JOB { get; set; }
        public Nullable<decimal> ID_JOBENTRY_TYPE { get; set; }
        public Nullable<decimal> NR { get; set; }
        public Nullable<decimal> GUI_LOCATION_X { get; set; }
        public Nullable<decimal> GUI_LOCATION_Y { get; set; }
        public string GUI_DRAW { get; set; }
        public string PARALLEL { get; set; }
    }
}
