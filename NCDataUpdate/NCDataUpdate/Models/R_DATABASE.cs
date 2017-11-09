using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_DATABASE
    {
        public decimal ID_DATABASE { get; set; }
        public string NAME { get; set; }
        public Nullable<decimal> ID_DATABASE_TYPE { get; set; }
        public Nullable<decimal> ID_DATABASE_CONTYPE { get; set; }
        public string HOST_NAME { get; set; }
        public string DATABASE_NAME { get; set; }
        public Nullable<decimal> PORT { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string SERVERNAME { get; set; }
        public string DATA_TBS { get; set; }
        public string INDEX_TBS { get; set; }
    }
}
