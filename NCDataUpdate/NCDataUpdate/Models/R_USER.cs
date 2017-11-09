using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_USER
    {
        public decimal ID_USER { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ENABLED { get; set; }
    }
}
