using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_DATABASE_CONTYPEMap : EntityTypeConfiguration<R_DATABASE_CONTYPE>
    {
        public R_DATABASE_CONTYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_DATABASE_CONTYPE);

            // Properties
            this.Property(t => t.ID_DATABASE_CONTYPE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_DATABASE_CONTYPE", "DI");
            this.Property(t => t.ID_DATABASE_CONTYPE).HasColumnName("ID_DATABASE_CONTYPE");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
