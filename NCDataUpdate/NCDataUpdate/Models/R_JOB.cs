using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_JOB
    {
        public decimal ID_JOB { get; set; }
        public Nullable<decimal> ID_DIRECTORY { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXTENDED_DESCRIPTION { get; set; }
        public string JOB_VERSION { get; set; }
        public Nullable<decimal> JOB_STATUS { get; set; }
        public Nullable<decimal> ID_DATABASE_LOG { get; set; }
        public string TABLE_NAME_LOG { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string MODIFIED_USER { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public string USE_BATCH_ID { get; set; }
        public string PASS_BATCH_ID { get; set; }
        public string USE_LOGFIELD { get; set; }
        public string SHARED_FILE { get; set; }
    }
}
