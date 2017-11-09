using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_DIRECTORY
    {
        public decimal ID_DIRECTORY { get; set; }
        public Nullable<decimal> ID_DIRECTORY_PARENT { get; set; }
        public string DIRECTORY_NAME { get; set; }
    }
}
