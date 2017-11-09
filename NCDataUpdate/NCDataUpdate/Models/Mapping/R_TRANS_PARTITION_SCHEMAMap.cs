using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_PARTITION_SCHEMAMap : EntityTypeConfiguration<R_TRANS_PARTITION_SCHEMA>
    {
        public R_TRANS_PARTITION_SCHEMAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_PARTITION_SCHEMA);

            // Properties
            this.Property(t => t.ID_TRANS_PARTITION_SCHEMA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_TRANS_PARTITION_SCHEMA", "DI");
            this.Property(t => t.ID_TRANS_PARTITION_SCHEMA).HasColumnName("ID_TRANS_PARTITION_SCHEMA");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_PARTITION_SCHEMA).HasColumnName("ID_PARTITION_SCHEMA");
        }
    }
}
