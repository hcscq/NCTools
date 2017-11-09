using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class SO_MIDDLE_SALEORDER
    {
        public string SALEORDERID { get; set; }
        public string ORDERNO { get; set; }
        public string ORDERDATE { get; set; }
        public string ORDERORG { get; set; }
        public string SENDORG { get; set; }
        public string SENDSTORDOC { get; set; }
        public string SENDPOINT { get; set; }
        public string SENDNO { get; set; }
        public string RESENDNO { get; set; }
        public string SENDDATE { get; set; }
        public string CUSTOMER { get; set; }
        public string CHRECEIVECUSTID { get; set; }
        public string CINVOICECUSTID { get; set; }
        public string RETPROVINCE { get; set; }
        public string EXPRESS { get; set; }
        public string PAYMETHOD { get; set; }
        public string PAYMENT { get; set; }
        public string BELONGDPT { get; set; }
        public Nullable<decimal> FREIGHTTOTAL { get; set; }
        public Nullable<decimal> DISCOUNTTOTAL { get; set; }
        public Nullable<decimal> AMOUNTRECEIVABLE { get; set; }
        public Nullable<decimal> AMOUNTTOTAL { get; set; }
        public Nullable<decimal> GOODSPREFER { get; set; }
        public Nullable<decimal> PAYPREFER { get; set; }
        public Nullable<decimal> CASHCOUPON { get; set; }
        public Nullable<decimal> GIFTCOUPON { get; set; }
        public string SRCTRANTYPE { get; set; }
        public string GUIDEID { get; set; }
        public string SRCSYS { get; set; }
        public string SRCID { get; set; }
        public Nullable<System.DateTime> RECDATE { get; set; }
        public string NCTRANTYPE { get; set; }
        public string NCFLAG { get; set; }
        public string NCBILLCODE { get; set; }
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
        public string TS { get; set; }
        public Nullable<decimal> DR { get; set; }
        public string EXPRESSNO { get; set; }
    }
}
