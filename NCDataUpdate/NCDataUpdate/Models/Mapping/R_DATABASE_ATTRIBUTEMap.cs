using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DATABASE_ATTRIBUTEMap : EntityTypeConfiguration<R_DATABASE_ATTRIBUTE>
    {
        public R_DATABASE_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DATABASE_ATTRIBUTE);

            // Properties
            this.Property(t => t.ID_DATABASE_ATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DATABASE_ATTRIBUTE", "DI");
            this.Property(t => t.ID_DATABASE_ATTRIBUTE).HasColumnName("ID_DATABASE_ATTRIBUTE");
            this.Property(t => t.ID_DATABASE).HasColumnName("ID_DATABASE");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
        }
    }
}
