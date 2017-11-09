using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOB_ATTRIBUTEMap : EntityTypeConfiguration<R_JOB_ATTRIBUTE>
    {
        public R_JOB_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOB_ATTRIBUTE);

            // Properties
            this.Property(t => t.ID_JOB_ATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_JOB_ATTRIBUTE", "DI");
            this.Property(t => t.ID_JOB_ATTRIBUTE).HasColumnName("ID_JOB_ATTRIBUTE");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.NR).HasColumnName("NR");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.VALUE_NUM).HasColumnName("VALUE_NUM");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
        }
    }
}
