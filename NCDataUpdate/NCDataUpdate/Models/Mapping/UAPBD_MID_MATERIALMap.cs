using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class UAPBD_MID_MATERIALMap : EntityTypeConfiguration<UAPBD_MID_MATERIAL>
    {
        public UAPBD_MID_MATERIALMap()
        {
            // Primary Key
            this.HasKey(t => t.MIDID);

            // Properties
            this.Property(t => t.MIDID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.CODE)
                .HasMaxLength(80);

            this.Property(t => t.NAME)
                .HasMaxLength(500);

            this.Property(t => t.SHORTNAME)
                .HasMaxLength(200);

            this.Property(t => t.UNIT)
                .HasMaxLength(50);

            this.Property(t => t.MARCLASSL1)
                .HasMaxLength(50);

            this.Property(t => t.MARCLASSL2)
                .HasMaxLength(50);

            this.Property(t => t.MARCLASSL3)
                .HasMaxLength(50);

            this.Property(t => t.LASTTIME)
                .HasMaxLength(20);

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

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            // Table & Column Mappings
            this.ToTable("UAPBD_MID_MATERIAL", "DI");
            this.Property(t => t.MIDID).HasColumnName("MIDID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.SHORTNAME).HasColumnName("SHORTNAME");
            this.Property(t => t.UNIT).HasColumnName("UNIT");
            this.Property(t => t.MARCLASSL1).HasColumnName("MARCLASSL1");
            this.Property(t => t.MARCLASSL2).HasColumnName("MARCLASSL2");
            this.Property(t => t.MARCLASSL3).HasColumnName("MARCLASSL3");
            this.Property(t => t.MARRATE).HasColumnName("MARRATE");
            this.Property(t => t.LASTTIME).HasColumnName("LASTTIME");
            this.Property(t => t.SRCSYS).HasColumnName("SRCSYS");
            this.Property(t => t.SRCID).HasColumnName("SRCID");
            this.Property(t => t.RECDATE).HasColumnName("RECDATE");
            this.Property(t => t.NCTRANTYPE).HasColumnName("NCTRANTYPE");
            this.Property(t => t.NCFLAG).HasColumnName("NCFLAG");
            this.Property(t => t.NCBILLCODE).HasColumnName("NCBILLCODE");
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
            this.Property(t => t.TS).HasColumnName("TS");
            this.Property(t => t.DR).HasColumnName("DR");
        }
    }
}
