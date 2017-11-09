using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_LOG
    {
        public decimal ID_LOG { get; set; }
        public string NAME { get; set; }
        public Nullable<decimal> ID_LOGLEVEL { get; set; }
        public string LOGTYPE { get; set; }
        public string FILENAME { get; set; }
        public string FILEEXTENTION { get; set; }
        public string ADD_DATE { get; set; }
        public string ADD_TIME { get; set; }
        public Nullable<decimal> ID_DATABASE_LOG { get; set; }
        public string TABLE_NAME_LOG { get; set; }
    }
}
