using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_PARTITION_SCHEMA
    {
        public decimal ID_PARTITION_SCHEMA { get; set; }
        public string NAME { get; set; }
        public string DYNAMIC_DEFINITION { get; set; }
        public string PARTITIONS_PER_SLAVE { get; set; }
    }
}
