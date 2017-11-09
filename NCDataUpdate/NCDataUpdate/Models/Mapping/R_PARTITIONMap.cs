using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_PARTITIONMap : EntityTypeConfiguration<R_PARTITION>
    {
        public R_PARTITIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_PARTITION);

            // Properties
            this.Property(t => t.ID_PARTITION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PARTITION_ID)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_PARTITION", "DI");
            this.Property(t => t.ID_PARTITION).HasColumnName("ID_PARTITION");
            this.Property(t => t.ID_PARTITION_SCHEMA).HasColumnName("ID_PARTITION_SCHEMA");
            this.Property(t => t.PARTITION_ID).HasColumnName("PARTITION_ID");
        }
    }
}
