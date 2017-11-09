using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_CLUSTER_SLAVEMap : EntityTypeConfiguration<R_CLUSTER_SLAVE>
    {
        public R_CLUSTER_SLAVEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_CLUSTER_SLAVE);

            // Properties
            this.Property(t => t.ID_CLUSTER_SLAVE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_CLUSTER_SLAVE", "DI");
            this.Property(t => t.ID_CLUSTER_SLAVE).HasColumnName("ID_CLUSTER_SLAVE");
            this.Property(t => t.ID_CLUSTER).HasColumnName("ID_CLUSTER");
            this.Property(t => t.ID_SLAVE).HasColumnName("ID_SLAVE");
        }
    }
}
