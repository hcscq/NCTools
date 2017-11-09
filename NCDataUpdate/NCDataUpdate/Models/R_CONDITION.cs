using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_CONDITION
    {
        public decimal ID_CONDITION { get; set; }
        public Nullable<decimal> ID_CONDITION_PARENT { get; set; }
        public string NEGATED { get; set; }
        public string OPERATOR { get; set; }
        public string LEFT_NAME { get; set; }
        public string CONDITION_FUNCTION { get; set; }
        public string RIGHT_NAME { get; set; }
        public Nullable<decimal> ID_VALUE_RIGHT { get; set; }
    }
}
