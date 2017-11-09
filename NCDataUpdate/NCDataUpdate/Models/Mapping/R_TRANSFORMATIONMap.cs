using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANSFORMATIONMap : EntityTypeConfiguration<R_TRANSFORMATION>
    {
        public R_TRANSFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANSFORMATION);

            // Properties
            this.Property(t => t.ID_TRANSFORMATION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.TRANS_VERSION)
                .HasMaxLength(255);

            this.Property(t => t.TABLE_NAME_LOG)
                .HasMaxLength(255);

            this.Property(t => t.USE_BATCHID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.USE_LOGFIELD)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TABLE_NAME_MAXDATE)
                .HasMaxLength(255);

            this.Property(t => t.FIELD_NAME_MAXDATE)
                .HasMaxLength(255);

            this.Property(t => t.CREATED_USER)
                .HasMaxLength(255);

            this.Property(t => t.MODIFIED_USER)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_TRANSFORMATION", "DI");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_DIRECTORY).HasColumnName("ID_DIRECTORY");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.EXTENDED_DESCRIPTION).HasColumnName("EXTENDED_DESCRIPTION");
            this.Property(t => t.TRANS_VERSION).HasColumnName("TRANS_VERSION");
            this.Property(t => t.TRANS_STATUS).HasColumnName("TRANS_STATUS");
            this.Property(t => t.ID_STEP_READ).HasColumnName("ID_STEP_READ");
            this.Property(t => t.ID_STEP_WRITE).HasColumnName("ID_STEP_WRITE");
            this.Property(t => t.ID_STEP_INPUT).HasColumnName("ID_STEP_INPUT");
            this.Property(t => t.ID_STEP_OUTPUT).HasColumnName("ID_STEP_OUTPUT");
            this.Property(t => t.ID_STEP_UPDATE).HasColumnName("ID_STEP_UPDATE");
            this.Property(t => t.ID_DATABASE_LOG).HasColumnName("ID_DATABASE_LOG");
            this.Property(t => t.TABLE_NAME_LOG).HasColumnName("TABLE_NAME_LOG");
            this.Property(t => t.USE_BATCHID).HasColumnName("USE_BATCHID");
            this.Property(t => t.USE_LOGFIELD).HasColumnName("USE_LOGFIELD");
            this.Property(t => t.ID_DATABASE_MAXDATE).HasColumnName("ID_DATABASE_MAXDATE");
            this.Property(t => t.TABLE_NAME_MAXDATE).HasColumnName("TABLE_NAME_MAXDATE");
            this.Property(t => t.FIELD_NAME_MAXDATE).HasColumnName("FIELD_NAME_MAXDATE");
            this.Property(t => t.OFFSET_MAXDATE).HasColumnName("OFFSET_MAXDATE");
            this.Property(t => t.DIFF_MAXDATE).HasColumnName("DIFF_MAXDATE");
            this.Property(t => t.CREATED_USER).HasColumnName("CREATED_USER");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.MODIFIED_USER).HasColumnName("MODIFIED_USER");
            this.Property(t => t.MODIFIED_DATE).HasColumnName("MODIFIED_DATE");
            this.Property(t => t.SIZE_ROWSET).HasColumnName("SIZE_ROWSET");
        }
    }
}
