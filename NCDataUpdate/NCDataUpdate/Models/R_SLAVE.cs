using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_SLAVE
    {
        public decimal ID_SLAVE { get; set; }
        public string NAME { get; set; }
        public string HOST_NAME { get; set; }
        public string PORT { get; set; }
        public string WEB_APP_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PROXY_HOST_NAME { get; set; }
        public string PROXY_PORT { get; set; }
        public string NON_PROXY_HOSTS { get; set; }
        public string MASTER { get; set; }
    }
}
