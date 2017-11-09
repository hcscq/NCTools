using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class UAPBD_MID_INVCOUNT_B
    {
        public string MIDBID { get; set; }
        public string ORG { get; set; }
        public string VBILLCODE { get; set; }
        public string DBILLDATE { get; set; }
        public string TRANTYPE { get; set; }
        public string WAREHOUSE { get; set; }
        public string CROWNO { get; set; }
        public string MATERIAL { get; set; }
        public string UNIT { get; set; }
        public Nullable<decimal> COUNTNUM { get; set; }
        public Nullable<decimal> ONHANDNUM { get; set; }
        public Nullable<decimal> NUM { get; set; }
        public Nullable<decimal> COSTPRICE { get; set; }
        public string STATE1 { get; set; }
        public string VDEF1 { get; set; }
        public string VDEF2 { get; set; }
        public string VDEF3 { get; set; }
        public string VDEF4 { get; set; }
        public string VDEF5 { get; set; }
        public string VDEF6 { get; set; }
        public string VDEF7 { get; set; }
        public string VDEF8 { get; set; }
        public string VDEF9 { get; set; }
        public string VDEF10 { get; set; }
        public string SRCSYS { get; set; }
        public string SRCID { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string NCTRANTYPE { get; set; }
        public string NCFLAG { get; set; }
        public string NCBILLCODE { get; set; }
        public string MIDHID { get; set; }
        public string TS { get; set; }
        public Nullable<decimal> DR { get; set; }
    }
}
