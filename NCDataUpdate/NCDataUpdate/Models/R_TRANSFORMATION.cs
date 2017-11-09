using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_TRANSFORMATION
    {
        public decimal ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_DIRECTORY { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXTENDED_DESCRIPTION { get; set; }
        public string TRANS_VERSION { get; set; }
        public Nullable<decimal> TRANS_STATUS { get; set; }
        public Nullable<decimal> ID_STEP_READ { get; set; }
        public Nullable<decimal> ID_STEP_WRITE { get; set; }
        public Nullable<decimal> ID_STEP_INPUT { get; set; }
        public Nullable<decimal> ID_STEP_OUTPUT { get; set; }
        public Nullable<decimal> ID_STEP_UPDATE { get; set; }
        public Nullable<decimal> ID_DATABASE_LOG { get; set; }
        public string TABLE_NAME_LOG { get; set; }
        public string USE_BATCHID { get; set; }
        public string USE_LOGFIELD { get; set; }
        public Nullable<decimal> ID_DATABASE_MAXDATE { get; set; }
        public string TABLE_NAME_MAXDATE { get; set; }
        public string FIELD_NAME_MAXDATE { get; set; }
        public Nullable<decimal> OFFSET_MAXDATE { get; set; }
        public Nullable<decimal> DIFF_MAXDATE { get; set; }
        public string CREATED_USER { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string MODIFIED_USER { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public Nullable<decimal> SIZE_ROWSET { get; set; }
    }
}
