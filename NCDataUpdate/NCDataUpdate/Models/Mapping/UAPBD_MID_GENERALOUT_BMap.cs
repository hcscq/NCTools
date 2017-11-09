using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class UAPBD_MID_GENERALOUT_BMap : EntityTypeConfiguration<UAPBD_MID_GENERALOUT_B>
    {
        public UAPBD_MID_GENERALOUT_BMap()
        {
            // Primary Key
            this.HasKey(t => t.MIDBID);

            // Properties
            this.Property(t => t.MIDBID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ORG)
                .HasMaxLength(50);

            this.Property(t => t.VBILLCODE)
                .HasMaxLength(50);

            this.Property(t => t.DBILLDATE)
                .HasMaxLength(19);

            this.Property(t => t.TRANTYPE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.WAREHOUSE)
                .HasMaxLength(50);

            this.Property(t => t.CROWNO)
                .HasMaxLength(50);

            this.Property(t => t.MATERIAL)
                .HasMaxLength(50);

            this.Property(t => t.UNIT)
                .HasMaxLength(50);

            this.Property(t => t.STATE1)
                .HasMaxLength(50);

            this.Property(t => t.STATE2)
                .HasMaxLength(50);

            this.Property(t => t.VDEF1)
                .HasMaxLength(101);

            this.Property(t => t.VDEF2)
                .HasMaxLength(101);

            this.Property(t => t.VDEF3)
                .HasMaxLength(101);

            this.Property(t => t.VDEF4)
                .HasMaxLength(101);

            this.Property(t => t.VDEF5)
                .HasMaxLength(101);

            this.Property(t => t.VDEF6)
                .HasMaxLength(101);

            this.Property(t => t.VDEF7)
                .HasMaxLength(101);

            this.Property(t => t.VDEF8)
                .HasMaxLength(101);

            this.Property(t => t.VDEF9)
                .HasMaxLength(101);

            this.Property(t => t.VDEF10)
                .HasMaxLength(101);

            this.Property(t => t.SRCSYS)
                .HasMaxLength(50);

            this.Property(t => t.SRCID)
                .HasMaxLength(50);

            this.Property(t => t.NCTRANTYPE)
                .HasMaxLength(50);

            this.Property(t => t.NCFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NCBILLCODE)
                .HasMaxLength(50);

            this.Property(t => t.MIDHID)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            // Table & Column Mappings
            this.ToTable("UAPBD_MID_GENERALOUT_B", "DI");
            this.Property(t => t.MIDBID).HasColumnName("MIDBID");
            this.Property(t => t.ORG).HasColumnName("ORG");
            this.Property(t => t.VBILLCODE).HasColumnName("VBILLCODE");
            this.Property(t => t.DBILLDATE).HasColumnName("DBILLDATE");
            this.Property(t => t.TRANTYPE).HasColumnName("TRANTYPE");
            this.Property(t => t.WAREHOUSE).HasColumnName("WAREHOUSE");
            this.Property(t => t.CROWNO).HasColumnName("CROWNO");
            this.Property(t => t.MATERIAL).HasColumnName("MATERIAL");
            this.Property(t => t.UNIT).HasColumnName("UNIT");
            this.Property(t => t.NUM).HasColumnName("NUM");
            this.Property(t => t.STATE1).HasColumnName("STATE1");
            this.Property(t => t.STATE2).HasColumnName("STATE2");
            this.Property(t => t.VDEF1).HasColumnName("VDEF1");
            this.Property(t => t.VDEF2).HasColumnName("VDEF2");
            this.Property(t => t.VDEF3).HasColumnName("VDEF3");
            this.Property(t => t.VDEF4).HasColumnName("VDEF4");
            this.Property(t => t.VDEF5).HasColumnName("VDEF5");
            this.Property(t => t.VDEF6).HasColumnName("VDEF6");
            this.Property(t => t.VDEF7).HasColumnName("VDEF7");
            this.Property(t => t.VDEF8).HasColumnName("VDEF8");
            this.Property(t => t.VDEF9).HasColumnName("VDEF9");
            this.Property(t => t.VDEF10).HasColumnName("VDEF10");
            this.Property(t => t.SRCSYS).HasColumnName("SRCSYS");
            this.Property(t => t.SRCID).HasColumnName("SRCID");
            this.Property(t => t.RECDATE).HasColumnName("RECDATE");
            this.Property(t => t.NCTRANTYPE).HasColumnName("NCTRANTYPE");
            this.Property(t => t.NCFLAG).HasColumnName("NCFLAG");
            this.Property(t => t.NCBILLCODE).HasColumnName("NCBILLCODE");
            this.Property(t => t.MIDHID).HasColumnName("MIDHID");
            this.Property(t => t.TS).HasColumnName("TS");
            this.Property(t => t.DR).HasColumnName("DR");
        }
    }
}
