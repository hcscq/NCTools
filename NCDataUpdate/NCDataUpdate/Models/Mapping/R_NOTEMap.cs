using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_NOTEMap : EntityTypeConfiguration<R_NOTE>
    {
        public R_NOTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_NOTE);

            // Properties
            this.Property(t => t.ID_NOTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FONT_BOLD)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FONT_ITALIC)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DRAW_SHADOW)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_NOTE", "DI");
            this.Property(t => t.ID_NOTE).HasColumnName("ID_NOTE");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
            this.Property(t => t.GUI_LOCATION_X).HasColumnName("GUI_LOCATION_X");
            this.Property(t => t.GUI_LOCATION_Y).HasColumnName("GUI_LOCATION_Y");
            this.Property(t => t.GUI_LOCATION_WIDTH).HasColumnName("GUI_LOCATION_WIDTH");
            this.Property(t => t.GUI_LOCATION_HEIGHT).HasColumnName("GUI_LOCATION_HEIGHT");
            this.Property(t => t.FONT_NAME).HasColumnName("FONT_NAME");
            this.Property(t => t.FONT_SIZE).HasColumnName("FONT_SIZE");
            this.Property(t => t.FONT_BOLD).HasColumnName("FONT_BOLD");
            this.Property(t => t.FONT_ITALIC).HasColumnName("FONT_ITALIC");
            this.Property(t => t.FONT_COLOR_RED).HasColumnName("FONT_COLOR_RED");
            this.Property(t => t.FONT_COLOR_GREEN).HasColumnName("FONT_COLOR_GREEN");
            this.Property(t => t.FONT_COLOR_BLUE).HasColumnName("FONT_COLOR_BLUE");
            this.Property(t => t.FONT_BACK_GROUND_COLOR_RED).HasColumnName("FONT_BACK_GROUND_COLOR_RED");
            this.Property(t => t.FONT_BACK_GROUND_COLOR_GREEN).HasColumnName("FONT_BACK_GROUND_COLOR_GREEN");
            this.Property(t => t.FONT_BACK_GROUND_COLOR_BLUE).HasColumnName("FONT_BACK_GROUND_COLOR_BLUE");
            this.Property(t => t.FONT_BORDER_COLOR_RED).HasColumnName("FONT_BORDER_COLOR_RED");
            this.Property(t => t.FONT_BORDER_COLOR_GREEN).HasColumnName("FONT_BORDER_COLOR_GREEN");
            this.Property(t => t.FONT_BORDER_COLOR_BLUE).HasColumnName("FONT_BORDER_COLOR_BLUE");
            this.Property(t => t.DRAW_SHADOW).HasColumnName("DRAW_SHADOW");
        }
    }
}
