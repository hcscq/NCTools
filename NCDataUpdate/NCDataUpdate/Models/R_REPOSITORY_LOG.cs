using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_REPOSITORY_LOG
    {
        public decimal ID_REPOSITORY_LOG { get; set; }
        public string REP_VERSION { get; set; }
        public Nullable<System.DateTime> LOG_DATE { get; set; }
        public string LOG_USER { get; set; }
        public string OPERATION_DESC { get; set; }
    }
}
