using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_STEPMap : EntityTypeConfiguration<R_STEP>
    {
        public R_STEPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_STEP);

            // Properties
            this.Property(t => t.ID_STEP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.DISTRIBUTE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GUI_DRAW)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_STEP", "DI");
            this.Property(t => t.ID_STEP).HasColumnName("ID_STEP");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.ID_STEP_TYPE).HasColumnName("ID_STEP_TYPE");
            this.Property(t => t.DISTRIBUTE).HasColumnName("DISTRIBUTE");
            this.Property(t => t.COPIES).HasColumnName("COPIES");
            this.Property(t => t.GUI_LOCATION_X).HasColumnName("GUI_LOCATION_X");
            this.Property(t => t.GUI_LOCATION_Y).HasColumnName("GUI_LOCATION_Y");
            this.Property(t => t.GUI_DRAW).HasColumnName("GUI_DRAW");
        }
    }
}
