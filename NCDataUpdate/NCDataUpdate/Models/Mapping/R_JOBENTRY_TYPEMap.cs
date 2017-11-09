using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOBENTRY_TYPEMap : EntityTypeConfiguration<R_JOBENTRY_TYPE>
    {
        public R_JOBENTRY_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOBENTRY_TYPE);

            // Properties
            this.Property(t => t.ID_JOBENTRY_TYPE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_JOBENTRY_TYPE", "DI");
            this.Property(t => t.ID_JOBENTRY_TYPE).HasColumnName("ID_JOBENTRY_TYPE");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
