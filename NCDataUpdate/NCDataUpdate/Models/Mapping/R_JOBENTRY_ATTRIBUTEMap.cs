using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_JOBENTRY_ATTRIBUTEMap : EntityTypeConfiguration<R_JOBENTRY_ATTRIBUTE>
    {
        public R_JOBENTRY_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_JOBENTRY_ATTRIBUTE);

            // Properties
            this.Property(t => t.ID_JOBENTRY_ATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_JOBENTRY_ATTRIBUTE", "DI");
            this.Property(t => t.ID_JOBENTRY_ATTRIBUTE).HasColumnName("ID_JOBENTRY_ATTRIBUTE");
            this.Property(t => t.ID_JOB).HasColumnName("ID_JOB");
            this.Property(t => t.ID_JOBENTRY).HasColumnName("ID_JOBENTRY");
            this.Property(t => t.NR).HasColumnName("NR");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.VALUE_NUM).HasColumnName("VALUE_NUM");
            this.Property(t => t.VALUE_STR).HasColumnName("VALUE_STR");
        }
    }
}
