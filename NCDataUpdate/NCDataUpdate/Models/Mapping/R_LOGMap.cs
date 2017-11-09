using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_LOGMap : EntityTypeConfiguration<R_LOG>
    {
        public R_LOGMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_LOG);

            // Properties
            this.Property(t => t.ID_LOG)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.LOGTYPE)
                .HasMaxLength(255);

            this.Property(t => t.FILENAME)
                .HasMaxLength(255);

            this.Property(t => t.FILEEXTENTION)
                .HasMaxLength(255);

            this.Property(t => t.ADD_DATE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ADD_TIME)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TABLE_NAME_LOG)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_LOG", "DI");
            this.Property(t => t.ID_LOG).HasColumnName("ID_LOG");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.ID_LOGLEVEL).HasColumnName("ID_LOGLEVEL");
            this.Property(t => t.LOGTYPE).HasColumnName("LOGTYPE");
            this.Property(t => t.FILENAME).HasColumnName("FILENAME");
            this.Property(t => t.FILEEXTENTION).HasColumnName("FILEEXTENTION");
            this.Property(t => t.ADD_DATE).HasColumnName("ADD_DATE");
            this.Property(t => t.ADD_TIME).HasColumnName("ADD_TIME");
            this.Property(t => t.ID_DATABASE_LOG).HasColumnName("ID_DATABASE_LOG");
            this.Property(t => t.TABLE_NAME_LOG).HasColumnName("TABLE_NAME_LOG");
        }
    }
}
