using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_STEP_TYPEMap : EntityTypeConfiguration<R_STEP_TYPE>
    {
        public R_STEP_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_STEP_TYPE);

            // Properties
            this.Property(t => t.ID_STEP_TYPE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            this.Property(t => t.HELPTEXT)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_STEP_TYPE", "DI");
            this.Property(t => t.ID_STEP_TYPE).HasColumnName("ID_STEP_TYPE");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.HELPTEXT).HasColumnName("HELPTEXT");
        }
    }
}
