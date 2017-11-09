using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DATABASE_TYPEMap : EntityTypeConfiguration<R_DATABASE_TYPE>
    {
        public R_DATABASE_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DATABASE_TYPE);

            // Properties
            this.Property(t => t.ID_DATABASE_TYPE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DATABASE_TYPE", "DI");
            this.Property(t => t.ID_DATABASE_TYPE).HasColumnName("ID_DATABASE_TYPE");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
