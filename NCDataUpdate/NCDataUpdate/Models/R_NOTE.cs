using System;
using System.Collections.Generic;

namespace NCDataUpdate.Models
{
    public partial class R_NOTE
    {
        public decimal ID_NOTE { get; set; }
        public string VALUE_STR { get; set; }
        public Nullable<decimal> GUI_LOCATION_X { get; set; }
        public Nullable<decimal> GUI_LOCATION_Y { get; set; }
        public Nullable<decimal> GUI_LOCATION_WIDTH { get; set; }
        public Nullable<decimal> GUI_LOCATION_HEIGHT { get; set; }
        public string FONT_NAME { get; set; }
        public Nullable<decimal> FONT_SIZE { get; set; }
        public string FONT_BOLD { get; set; }
        public string FONT_ITALIC { get; set; }
        public Nullable<decimal> FONT_COLOR_RED { get; set; }
        public Nullable<decimal> FONT_COLOR_GREEN { get; set; }
        public Nullable<decimal> FONT_COLOR_BLUE { get; set; }
        public Nullable<decimal> FONT_BACK_GROUND_COLOR_RED { get; set; }
        public Nullable<decimal> FONT_BACK_GROUND_COLOR_GREEN { get; set; }
        public Nullable<decimal> FONT_BACK_GROUND_COLOR_BLUE { get; set; }
        public Nullable<decimal> FONT_BORDER_COLOR_RED { get; set; }
        public Nullable<decimal> FONT_BORDER_COLOR_GREEN { get; set; }
        public Nullable<decimal> FONT_BORDER_COLOR_BLUE { get; set; }
        public string DRAW_SHADOW { get; set; }
    }
}
