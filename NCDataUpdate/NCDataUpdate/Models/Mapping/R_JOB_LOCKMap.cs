using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOB_LOCKMap : EntityTypeConfiguration<R_JOB_LOCK>
    {
        public R_JOB_LOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOB_LOCK);

            // Properties
            this.Property(t => t.ID_JOB_LOCK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_JOB_LOCK", "DI");
            this.Property(t => t.ID_JOB_LOCK).HasColumnName("ID_JOB_LOCK");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_USER).HasColumnName("ID_USER");
            this.Property(t => t.LOCK_MESSAGE).HasColumnName("LOCK_MESSAGE");
            this.Property(t => t.LOCK_DATE).HasColumnName("LOCK_DATE");
        }
    }
}
