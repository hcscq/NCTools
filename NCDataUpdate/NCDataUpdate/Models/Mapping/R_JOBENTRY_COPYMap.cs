using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOBENTRY_COPYMap : EntityTypeConfiguration<R_JOBENTRY_COPY>
    {
        public R_JOBENTRY_COPYMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOBENTRY_COPY);

            // Properties
            this.Property(t => t.ID_JOBENTRY_COPY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GUI_DRAW)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PARALLEL)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_JOBENTRY_COPY", "DI");
            this.Property(t => t.ID_JOBENTRY_COPY).HasColumnName("ID_JOBENTRY_COPY");
            this.Property(t => t.ID_JOBENTRY).HasColumnName("ID_JOBENTRY");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_JOBENTRY_TYPE).HasColumnName("ID_JOBENTRY_TYPE");
            this.Property(t => t.NR).HasColumnName("NR");
            this.Property(t => t.GUI_LOCATION_X).HasColumnName("GUI_LOCATION_X");
            this.Property(t => t.GUI_LOCATION_Y).HasColumnName("GUI_LOCATION_Y");
            this.Property(t => t.GUI_DRAW).HasColumnName("GUI_DRAW");
            this.Property(t => t.PARALLEL).HasColumnName("PARALLEL");
        }
    }
}
