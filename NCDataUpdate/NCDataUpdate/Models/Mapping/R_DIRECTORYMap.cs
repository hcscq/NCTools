using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DIRECTORYMap : EntityTypeConfiguration<R_DIRECTORY>
    {
        public R_DIRECTORYMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DIRECTORY);

            // Properties
            this.Property(t => t.ID_DIRECTORY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DIRECTORY_NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DIRECTORY", "DI");
            this.Property(t => t.ID_DIRECTORY).HasColumnName("ID_DIRECTORY");
            this.Property(t => t.ID_DIRECTORY_PARENT).HasColumnName("ID_DIRECTORY_PARENT");
            this.Property(t => t.DIRECTORY_NAME).HasColumnName("DIRECTORY_NAME");
        }
    }
}
