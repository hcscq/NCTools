using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class UAPBD_MID_RECBILLMap : EntityTypeConfiguration<UAPBD_MID_RECBILL>
    {
        public UAPBD_MID_RECBILLMap()
        {
            // Primary Key
            this.HasKey(t => t.PK_RECBILL);

            // Properties
            this.Property(t => t.PK_RECBILL)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ORG)
                .HasMaxLength(50);

            this.Property(t => t.VBILLCODE)
                .HasMaxLength(50);

            this.Property(t => t.DBILLDATE)
                .HasMaxLength(50);

            this.Property(t => t.TRANTYPE)
                .HasMaxLength(50);

            this.Property(t => t.CUSTOMER)
                .HasMaxLength(50);

            this.Property(t => t.PAYMETHOD)
                .HasMaxLength(50);

            this.Property(t => t.PAYMENT)
                .HasMaxLength(50);

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
            this.ToTable("UAPBD_MID_RECBILL", "DI");
            this.Property(t => t.PK_RECBILL).HasColumnName("PK_RECBILL");
            this.Property(t => t.ORG).HasColumnName("ORG");
            this.Property(t => t.VBILLCODE).HasColumnName("VBILLCODE");
            this.Property(t => t.DBILLDATE).HasColumnName("DBILLDATE");
            this.Property(t => t.TRANTYPE).HasColumnName("TRANTYPE");
            this.Property(t => t.CUSTOMER).HasColumnName("CUSTOMER");
            this.Property(t => t.PAYMETHOD).HasColumnName("PAYMETHOD");
            this.Property(t => t.PAYMENT).HasColumnName("PAYMENT");
            this.Property(t => t.AMOUNTRECEIVABLE).HasColumnName("AMOUNTRECEIVABLE");
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
