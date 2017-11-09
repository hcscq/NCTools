using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_TRANS_ATTRIBUTEMap : EntityTypeConfiguration<R_TRANS_ATTRIBUTE>
    {
        public R_TRANS_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_TRANS_ATTRIBUTE);

            // Properties
            this.Property(t => t.ID_TRANS_ATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_TRANS_ATTRIBUTE", "DI");
            this.Property(t => t.ID_TRANS_ATTRIBUTE).HasColumnName("ID_TRANS_ATTRIBUTE");
            this.Property(t => t.ID_TRANSFORMATION).HasColumnName("ID_TRANSFORMATION");
            this.Property(t => t.NR).HasColumnName("NR");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.VALUE_NUM).HasColumnName("VALUE_NUM");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
        }
    }
}
