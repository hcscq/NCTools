using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_REPOSITORY_LOGMap : EntityTypeConfiguration<R_REPOSITORY_LOG>
    {
        public R_REPOSITORY_LOGMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_REPOSITORY_LOG);

            // Properties
            this.Property(t => t.ID_REPOSITORY_LOG)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REP_VERSION)
                .HasMaxLength(255);

            this.Property(t => t.LOG_USER)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_REPOSITORY_LOG", "DI");
            this.Property(t => t.ID_REPOSITORY_LOG).HasColumnName("ID_REPOSITORY_LOG");
            this.Property(t => t.REP_VERSION).HasColumnName("REP_VERSION");
            this.Property(t => t.LOG_DATE).HasColumnName("LOG_DATE");
            this.Property(t => t.LOG_USER).HasColumnName("LOG_USER");
            this.Property(t => t.OPERATION_DESC).HasColumnName("OPERATION_DESC");
        }
    }
}
