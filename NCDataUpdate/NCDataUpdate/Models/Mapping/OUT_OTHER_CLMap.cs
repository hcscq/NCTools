using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class OUT_OTHER_CLMap : EntityTypeConfiguration<OUT_OTHER_CL>
    {
        public OUT_OTHER_CLMap()
        {
            // Primary Key
            this.HasKey(t => t.RID);

            // Properties
            this.Property(t => t.ORG)
                .HasMaxLength(20);

            this.Property(t => t.DJBH)
                .HasMaxLength(60);

            this.Property(t => t.BILLDATE)
                .HasMaxLength(60);

            this.Property(t => t.USERNAME)
                .HasMaxLength(60);

            this.Property(t => t.CS_HW)
                .HasMaxLength(60);

            this.Property(t => t.HWID)
                .HasMaxLength(60);

            this.Property(t => t.KB)
                .HasMaxLength(60);

            this.Property(t => t.ZDNR)
                .HasMaxLength(100);

            this.Property(t => t.YSPID)
                .HasMaxLength(60);

            this.Property(t => t.YSPBH)
                .HasMaxLength(80);

            this.Property(t => t.YSPMCH)
                .HasMaxLength(500);

            this.Property(t => t.CSPID)
                .HasMaxLength(51);

            this.Property(t => t.CSPBH)
                .HasMaxLength(55);

            this.Property(t => t.CSPMCH)
                .HasMaxLength(500);

            this.Property(t => t.FROMCKCODE)
                .HasMaxLength(80);

            this.Property(t => t.RID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BZ)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OUT_OTHER_CL", "DI");
            this.Property(t => t.ORG).HasColumnName("ORG");
            this.Property(t => t.DJBH).HasColumnName("DJBH");
            this.Property(t => t.BILLDATE).HasColumnName("BILLDATE");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.CS_HW).HasColumnName("CS_HW");
            this.Property(t => t.HWID).HasColumnName("HWID");
            this.Property(t => t.KB).HasColumnName("KB");
            this.Property(t => t.ZDNR).HasColumnName("ZDNR");
            this.Property(t => t.YSPID).HasColumnName("YSPID");
            this.Property(t => t.YSPBH).HasColumnName("YSPBH");
            this.Property(t => t.YSPMCH).HasColumnName("YSPMCH");
            this.Property(t => t.YSL).HasColumnName("YSL");
            this.Property(t => t.CSPID).HasColumnName("CSPID");
            this.Property(t => t.CSPBH).HasColumnName("CSPBH");
            this.Property(t => t.CSPMCH).HasColumnName("CSPMCH");
            this.Property(t => t.CSL).HasColumnName("CSL");
            this.Property(t => t.PROPORTION).HasColumnName("PROPORTION");
            this.Property(t => t.FROMCKCODE).HasColumnName("FROMCKCODE");
            this.Property(t => t.DJ_SN).HasColumnName("DJ_SN");
            this.Property(t => t.RID).HasColumnName("RID");
            this.Property(t => t.BZ).HasColumnName("BZ");
            this.Property(t => t.RECDATE).HasColumnName("RECDATE");
        }
    }
}
