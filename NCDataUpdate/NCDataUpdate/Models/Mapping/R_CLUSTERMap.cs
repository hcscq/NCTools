using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_CLUSTERMap : EntityTypeConfiguration<R_CLUSTER>
    {
        public R_CLUSTERMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_CLUSTER);

            // Properties
            this.Property(t => t.ID_CLUSTER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.BASE_PORT)
                .HasMaxLength(255);

            this.Property(t => t.SOCKETS_BUFFER_SIZE)
                .HasMaxLength(255);

            this.Property(t => t.SOCKETS_FLUSH_INTERVAL)
                .HasMaxLength(255);

            this.Property(t => t.SOCKETS_COMPRESSED)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DYNAMIC_CLUSTER)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_CLUSTER", "DI");
            this.Property(t => t.ID_CLUSTER).HasColumnName("ID_CLUSTER");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.BASE_PORT).HasColumnName("BASE_PORT");
            this.Property(t => t.SOCKETS_BUFFER_SIZE).HasColumnName("SOCKETS_BUFFER_SIZE");
            this.Property(t => t.SOCKETS_FLUSH_INTERVAL).HasColumnName("SOCKETS_FLUSH_INTERVAL");
            this.Property(t => t.SOCKETS_COMPRESSED).HasColumnName("SOCKETS_COMPRESSED");
            this.Property(t => t.DYNAMIC_CLUSTER).HasColumnName("DYNAMIC_CLUSTER");
        }
    }
}
