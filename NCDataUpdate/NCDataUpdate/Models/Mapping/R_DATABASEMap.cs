using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DATABASEMap : EntityTypeConfiguration<R_DATABASE>
    {
        public R_DATABASEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DATABASE);

            // Properties
            this.Property(t => t.ID_DATABASE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.HOST_NAME)
                .HasMaxLength(255);

            this.Property(t => t.DATABASE_NAME)
                .HasMaxLength(255);

            this.Property(t => t.USERNAME)
                .HasMaxLength(255);

            this.Property(t => t.PASSWORD)
                .HasMaxLength(255);

            this.Property(t => t.SERVERNAME)
                .HasMaxLength(255);

            this.Property(t => t.DATA_TBS)
                .HasMaxLength(255);

            this.Property(t => t.INDEX_TBS)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DATABASE", "DI");
            this.Property(t => t.ID_DATABASE).HasColumnName("ID_DATABASE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.ID_DATABASE_TYPE).HasColumnName("ID_DATABASE_TYPE");
            this.Property(t => t.ID_DATABASE_CONTYPE).HasColumnName("ID_DATABASE_CONTYPE");
            this.Property(t => t.HOST_NAME).HasColumnName("HOST_NAME");
            this.Property(t => t.DATABASE_NAME).HasColumnName("DATABASE_NAME");
            this.Property(t => t.PORT).HasColumnName("PORT");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.SERVERNAME).HasColumnName("SERVERNAME");
            this.Property(t => t.DATA_TBS).HasColumnName("DATA_TBS");
            this.Property(t => t.INDEX_TBS).HasColumnName("INDEX_TBS");
        }
    }
}
