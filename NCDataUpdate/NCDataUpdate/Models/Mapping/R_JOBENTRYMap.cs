using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOBENTRYMap : EntityTypeConfiguration<R_JOBENTRY>
    {
        public R_JOBENTRYMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOBENTRY);

            // Properties
            this.Property(t => t.ID_JOBENTRY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_JOBENTRY", "DI");
            this.Property(t => t.ID_JOBENTRY).HasColumnName("ID_JOBENTRY");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_JOBENTRY_TYPE).HasColumnName("ID_JOBENTRY_TYPE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
