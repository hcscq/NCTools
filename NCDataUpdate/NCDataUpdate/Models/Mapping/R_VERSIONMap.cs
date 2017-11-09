using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_VERSIONMap : EntityTypeConfiguration<R_VERSION>
    {
        public R_VERSIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_VERSION);

            // Properties
            this.Property(t => t.ID_VERSION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IS_UPGRADE)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_VERSION", "DI");
            this.Property(t => t.ID_VERSION).HasColumnName("ID_VERSION");
            this.Property(t => t.MAJOR_VERSION).HasColumnName("MAJOR_VERSION");
            this.Property(t => t.MINOR_VERSION).HasColumnName("MINOR_VERSION");
            this.Property(t => t.UPGRADE_DATE).HasColumnName("UPGRADE_DATE");
            this.Property(t => t.IS_UPGRADE).HasColumnName("IS_UPGRADE");
        }
    }
}
