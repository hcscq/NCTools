using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_DEPENDENCY
    {
        public decimal ID_DEPENDENCY { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public Nullable<decimal> ID_DATABASE { get; set; }
        public string TABLE_NAME { get; set; }
        public string FIELD_NAME { get; set; }
    }
}
