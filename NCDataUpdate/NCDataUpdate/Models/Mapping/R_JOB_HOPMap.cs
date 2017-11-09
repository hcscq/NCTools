using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOB_HOPMap : EntityTypeConfiguration<R_JOB_HOP>
    {
        public R_JOB_HOPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOB_HOP);

            // Properties
            this.Property(t => t.ID_JOB_HOP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ENABLED)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EVALUATION)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UNCONDITIONAL)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_JOB_HOP", "DI");
            this.Property(t => t.ID_JOB_HOP).HasColumnName("ID_JOB_HOP");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_JOBENTRY_COPY_FROM).HasColumnName("ID_JOBENTRY_COPY_FROM");
            this.Property(t => t.ID_JOBENTRY_COPY_TO).HasColumnName("ID_JOBENTRY_COPY_TO");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.EVALUATION).HasColumnName("EVALUATION");
            this.Property(t => t.UNCONDITIONAL).HasColumnName("UNCONDITIONAL");
        }
    }
}
