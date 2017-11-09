using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_SLAVEMap : EntityTypeConfiguration<R_SLAVE>
    {
        public R_SLAVEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_SLAVE);

            // Properties
            this.Property(t => t.ID_SLAVE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.HOST_NAME)
                .HasMaxLength(255);

            this.Property(t => t.PORT)
                .HasMaxLength(255);

            this.Property(t => t.WEB_APP_NAME)
                .HasMaxLength(255);

            this.Property(t => t.USERNAME)
                .HasMaxLength(255);

            this.Property(t => t.PASSWORD)
                .HasMaxLength(255);

            this.Property(t => t.PROXY_HOST_NAME)
                .HasMaxLength(255);

            this.Property(t => t.PROXY_PORT)
                .HasMaxLength(255);

            this.Property(t => t.NON_PROXY_HOSTS)
                .HasMaxLength(255);

            this.Property(t => t.MASTER)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_SLAVE", "DI");
            this.Property(t => t.ID_SLAVE).HasColumnName("ID_SLAVE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.HOST_NAME).HasColumnName("HOST_NAME");
            this.Property(t => t.PORT).HasColumnName("PORT");
            this.Property(t => t.WEB_APP_NAME).HasColumnName("WEB_APP_NAME");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.PROXY_HOST_NAME).HasColumnName("PROXY_HOST_NAME");
            this.Property(t => t.PROXY_PORT).HasColumnName("PROXY_PORT");
            this.Property(t => t.NON_PROXY_HOSTS).HasColumnName("NON_PROXY_HOSTS");
            this.Property(t => t.MASTER).HasColumnName("MASTER");
        }
    }
}
