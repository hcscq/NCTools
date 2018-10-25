using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataMatch.Models.Mapping
{
    public class Cux_Rpt_notdatasMap : EntityTypeConfiguration<Cux_Rpt_Notdatas>
    {
        public Cux_Rpt_notdatasMap()
        {
            // Primary Key
            this.HasKey(t => new {t.ITEMCODE,t.ORG });

            // Table & Column Mappings
            this.ToTable("CUX_RPT_NOTDATAS", "NC65");
            this.Property(t => t.ITEMCODE).HasColumnName("ITEMCODE");
            this.Property(t => t.ORG).HasColumnName("ORG");
        }
    }
}
