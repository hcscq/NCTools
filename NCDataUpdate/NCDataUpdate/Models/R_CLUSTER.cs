using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_CLUSTER
    {
        public decimal ID_CLUSTER { get; set; }
        public string NAME { get; set; }
        public string BASE_PORT { get; set; }
        public string SOCKETS_BUFFER_SIZE { get; set; }
        public string SOCKETS_FLUSH_INTERVAL { get; set; }
        public string SOCKETS_COMPRESSED { get; set; }
        public string DYNAMIC_CLUSTER { get; set; }
    }
}
