using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCDataUpdate.Models
{
    public partial class DBASE_ITEM_MSG_ORG
    {
        [NotMapped]
        public bool UPDATE { get; set; }
        public string RID { get; set; }//VARCHAR2(80 BYTE) NULL ,
        public string GOODS_NO { get; set; }//VARCHAR2(80 BYTE) NULL ,
        public string GOODS_CODE { get; set; }//VARCHAR2(80 BYTE) NULL ,
        public string FULL_NAME { get; set; }//VARCHAR2(500 BYTE) NULL ,
        public string COMMON_NAME { get; set; }//VARCHAR2(300 BYTE) NULL ,
        public float OUTPUT_TAX { get; set; }//NUMBER(16,4) NULL ,
        public string UNITCODE { get; set; }//VARCHAR2(10 BYTE) NULL ,
        public string UNITNAME { get; set; }//VARCHAR2(50 BYTE) NULL ,
        public string SPACETIME_ONE_LEVEL { get; set; }//VARCHAR2(50 BYTE) NULL ,
        public string SPACETIME_ONE_LEVEL_NAME { get; set; }//VARCHAR2(200 BYTE) NULL ,
        public string SPACETIME_TWO_LEVEL { get; set; }//VARCHAR2(50 BYTE) NULL ,
        public string SPACETIME_TWO_LEVEL_NAME { get; set; }//VARCHAR2(200 BYTE) NULL ,
        public string SPACETIME_THREE_LEVEL { get; set; }//VARCHAR2(50 BYTE) NULL ,
        public string SPACETIME_THREE_LEVEL_NAME { get; set; }//VARCHAR2(200 BYTE) NULL ,
        public Nullable<DateTime> UPDATE_TIME { get; set; }//DATE NULL ,
        public Nullable<DateTime> RECDATE { get; set; }//DATE DEFAULT sysdate  NULL ,
        public string DAMAGE_TREATMENT { get; set; }//VARCHAR2(100 BYTE) NULL ,
        public string ORG { get; set; }//VARCHAR2(60 BYTE) NULL ,
        public Nullable<int> SHBIT { get; set; }//NUMBER NULL 
    }
}
