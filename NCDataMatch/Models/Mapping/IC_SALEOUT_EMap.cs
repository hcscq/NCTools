using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataMatch.Models.Mapping
{
    public class IC_SALEOUT_EMap : EntityTypeConfiguration<IC_SALEOUT_E>
    {
        public IC_SALEOUT_EMap()
        {
            // Primary Key
            this.HasKey(t => t.CGENERALBID);

            // Properties
            this.Property(t => t.BTRANENDFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CGENERALBID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.CSUMID)
                .HasMaxLength(20);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            // Table & Column Mappings
            this.ToTable("IC_SALEOUT_E", "NC65");
            this.Property(t => t.BTRANENDFLAG).HasColumnName("BTRANENDFLAG");
            this.Property(t => t.CGENERALBID).HasColumnName("CGENERALBID");
            this.Property(t => t.CSUMID).HasColumnName("CSUMID");
            this.Property(t => t.DR).HasColumnName("DR");
            this.Property(t => t.NACCUMOUTBACKNUM).HasColumnName("NACCUMOUTBACKNUM");
            this.Property(t => t.NACCUMOUTSIGNNUM).HasColumnName("NACCUMOUTSIGNNUM");
            this.Property(t => t.NACCUMVMINUM).HasColumnName("NACCUMVMINUM");
            this.Property(t => t.NACCUMWASTNUM).HasColumnName("NACCUMWASTNUM");
            this.Property(t => t.NCORRESPONDASTNUM).HasColumnName("NCORRESPONDASTNUM");
            this.Property(t => t.NCORRESPONDGRSNUM).HasColumnName("NCORRESPONDGRSNUM");
            this.Property(t => t.NCORRESPONDNUM).HasColumnName("NCORRESPONDNUM");
            this.Property(t => t.NREPLENISHEDNUM).HasColumnName("NREPLENISHEDNUM");
            this.Property(t => t.NRUSHNUM).HasColumnName("NRUSHNUM");
            this.Property(t => t.NSIGNNUM).HasColumnName("NSIGNNUM");
            this.Property(t => t.NTOTALTRANNUM).HasColumnName("NTOTALTRANNUM");
            this.Property(t => t.TS).HasColumnName("TS");
        }
    }
}
