using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOBMap : EntityTypeConfiguration<R_JOB>
    {
        public R_JOBMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOB);

            // Properties
            this.Property(t => t.ID_JOB)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.JOB_VERSION)
                .HasMaxLength(255);

            this.Property(t => t.TABLE_NAME_LOG)
                .HasMaxLength(255);

            this.Property(t => t.CREATED_USER)
                .HasMaxLength(255);

            this.Property(t => t.MODIFIED_USER)
                .HasMaxLength(255);

            this.Property(t => t.USE_BATCH_ID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PASS_BATCH_ID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.USE_LOGFIELD)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SHARED_FILE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_JOB", "DI");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_DIRECTORY).HasColumnName("ID_DIRECTORY");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.EXTENDED_DESCRIPTION).HasColumnName("EXTENDED_DESCRIPTION");
            this.Property(t => t.JOB_VERSION).HasColumnName("JOB_VERSION");
            this.Property(t => t.JOB_STATUS).HasColumnName("JOB_STATUS");
            this.Property(t => t.ID_DATABASE_LOG).HasColumnName("ID_DATABASE_LOG");
            this.Property(t => t.TABLE_NAME_LOG).HasColumnName("TABLE_NAME_LOG");
            this.Property(t => t.CREATED_USER).HasColumnName("CREATED_USER");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.MODIFIED_USER).HasColumnName("MODIFIED_USER");
            this.Property(t => t.MODIFIED_DATE).HasColumnName("MODIFIED_DATE");
            this.Property(t => t.USE_BATCH_ID).HasColumnName("USE_BATCH_ID");
            this.Property(t => t.PASS_BATCH_ID).HasColumnName("PASS_BATCH_ID");
            this.Property(t => t.USE_LOGFIELD).HasColumnName("USE_LOGFIELD");
            this.Property(t => t.SHARED_FILE).HasColumnName("SHARED_FILE");
        }
    }
}
