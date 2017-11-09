using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_LOGLEVELMap : EntityTypeConfiguration<R_LOGLEVEL>
    {
        public R_LOGLEVELMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_LOGLEVEL);

            // Properties
            this.Property(t => t.ID_LOGLEVEL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_LOGLEVEL", "DI");
            this.Property(t => t.ID_LOGLEVEL).HasColumnName("ID_LOGLEVEL");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
