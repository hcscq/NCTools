using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DEPENDENCYMap : EntityTypeConfiguration<R_DEPENDENCY>
    {
        public R_DEPENDENCYMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DEPENDENCY);

            // Properties
            this.Property(t => t.ID_DEPENDENCY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TABLE_NAME)
                .HasMaxLength(255);

            this.Property(t => t.FIELD_NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DEPENDENCY", "DI");
            this.Property(t => t.ID_DEPENDENCY).HasColumnName("ID_DEPENDENCY");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_DATABASE).HasColumnName("ID_DATABASE");
            this.Property(t => t.TABLE_NAME).HasColumnName("TABLE_NAME");
            this.Property(t => t.FIELD_NAME).HasColumnName("FIELD_NAME");
        }
    }
}
