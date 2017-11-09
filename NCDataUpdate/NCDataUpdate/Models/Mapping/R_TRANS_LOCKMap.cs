using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_LOCKMap : EntityTypeConfiguration<R_TRANS_LOCK>
    {
        public R_TRANS_LOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_LOCK);

            // Properties
            this.Property(t => t.ID_TRANS_LOCK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("R_TRANS_LOCK", "DI");
            this.Property(t => t.ID_TRANS_LOCK).HasColumnName("ID_TRANS_LOCK");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.ID_USER).HasColumnName("ID_USER");
            this.Property(t => t.LOCK_MESSAGE).HasColumnName("LOCK_MESSAGE");
            this.Property(t => t.LOCK_DATE).HasColumnName("LOCK_DATE");
        }
    }
}
