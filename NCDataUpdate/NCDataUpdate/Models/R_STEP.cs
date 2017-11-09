using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_STEP
    {
        public decimal ID_STEP { get; set; }
        public Nullable<decimal> ID_TRANSFORMATION { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<decimal> ID_STEP_TYPE { get; set; }
        public string DISTRIBUTE { get; set; }
        public Nullable<decimal> COPIES { get; set; }
        public Nullable<decimal> GUI_LOCATION_X { get; set; }
        public Nullable<decimal> GUI_LOCATION_Y { get; set; }
        public string GUI_DRAW { get; set; }
    }
}
