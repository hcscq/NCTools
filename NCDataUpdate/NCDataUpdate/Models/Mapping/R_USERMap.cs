using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_USERMap : EntityTypeConfiguration<R_USER>
    {
        public R_USERMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_USER);

            // Properties
            this.Property(t => t.ID_USER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LOGIN)
                .HasMaxLength(255);

            this.Property(t => t.PASSWORD)
                .HasMaxLength(255);

            this.Property(t => t.NAME)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            this.Property(t => t.ENABLED)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("R_USER", "DI");
            this.Property(t => t.ID_USER).HasColumnName("ID_USER");
            this.Property(t => t.LOGIN).HasColumnName("LOGIN");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
        }
    }
}
