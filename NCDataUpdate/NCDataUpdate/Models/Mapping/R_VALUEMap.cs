using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_VALUEMap : EntityTypeConfiguration<R_VALUE>
    {
        public R_VALUEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_VALUE);

            // Properties
            this.Property(t => t.ID_VALUE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.VALUE_TYPE)
                .HasMaxLength(255);

            this.Property(t => t.VALUE_STR)
                .HasMaxLength(255);

            this.Property(t => t.IS_NULL)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_VALUE", "DI");
            this.Property(t => t.ID_VALUE).HasColumnName("ID_VALUE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.VALUE_TYPE).HasColumnName("VALUE_TYPE");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
            this.Property(t => t.IS_NULL).HasColumnName("IS_NULL");
        }
    }
}
