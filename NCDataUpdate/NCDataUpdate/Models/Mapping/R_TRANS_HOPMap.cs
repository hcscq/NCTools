using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_HOPMap : EntityTypeConfiguration<R_TRANS_HOP>
    {
        public R_TRANS_HOPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_HOP);

            // Properties
            this.Property(t => t.ID_TRANS_HOP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ENABLED)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_TRANS_HOP", "DI");
            this.Property(t => t.ID_TRANS_HOP).HasColumnName("ID_TRANS_HOP");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_STEP_FROM).HasColumnName("ID_STEP_FROM");
            this.Property(t => t.ID_STEP_TO).HasColumnName("ID_STEP_TO");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
        }
    }
}
