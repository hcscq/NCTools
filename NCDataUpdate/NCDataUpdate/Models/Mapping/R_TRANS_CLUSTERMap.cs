using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_CLUSTERMap : EntityTypeConfiguration<R_TRANS_CLUSTER>
    {
        public R_TRANS_CLUSTERMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_CLUSTER);

            // Properties
            this.Property(t => t.ID_TRANS_CLUSTER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_TRANS_CLUSTER", "DI");
            this.Property(t => t.ID_TRANS_CLUSTER).HasColumnName("ID_TRANS_CLUSTER");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_CLUSTER).HasColumnName("ID_CLUSTER");
        }
    }
}
