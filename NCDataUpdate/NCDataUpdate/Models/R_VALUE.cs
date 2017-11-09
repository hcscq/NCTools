using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_VALUE
    {
        public decimal ID_VALUE { get; set; }
        public string NAME { get; set; }
        public string VALUE_TYPE { get; set; }
        public string VALUE_STR { get; set; }
        public string IS_NULL { get; set; }
    }
}
