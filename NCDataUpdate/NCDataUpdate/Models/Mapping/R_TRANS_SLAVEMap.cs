using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_SLAVEMap : EntityTypeConfiguration<R_TRANS_SLAVE>
    {
        public R_TRANS_SLAVEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_SLAVE);

            // Properties
            this.Property(t => t.ID_TRANS_SLAVE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_TRANS_SLAVE", "DI");
            this.Property(t => t.ID_TRANS_SLAVE).HasColumnName("ID_TRANS_SLAVE");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_SLAVE).HasColumnName("ID_SLAVE");
        }
    }
}
