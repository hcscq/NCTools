using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_PARTITION_SCHEMAMap : EntityTypeConfiguration<R_PARTITION_SCHEMA>
    {
        public R_PARTITION_SCHEMAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_PARTITION_SCHEMA);

            // Properties
            this.Property(t => t.ID_PARTITION_SCHEMA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.DYNAMIC_DEFINITION)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PARTITIONS_PER_SLAVE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_PARTITION_SCHEMA", "DI");
            this.Property(t => t.ID_PARTITION_SCHEMA).HasColumnName("ID_PARTITION_SCHEMA");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DYNAMIC_DEFINITION).HasColumnName("DYNAMIC_DEFINITION");
            this.Property(t => t.PARTITIONS_PER_SLAVE).HasColumnName("PARTITIONS_PER_SLAVE");
        }
    }
}
