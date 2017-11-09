using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class SO_MIDDLE_SALEORDER_BMap : EntityTypeConfiguration<SO_MIDDLE_SALEORDER_B>
    {
        public SO_MIDDLE_SALEORDER_BMap()
        {
            // Primary Key
            this.HasKey(t => t.SALEORDERBID);

            // Properties
            this.Property(t => t.SALEORDERBID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.SENDNO)
                .HasMaxLength(50);

            this.Property(t => t.RESENDNO)
                .HasMaxLength(50);

            this.Property(t => t.CROWNO)
                .HasMaxLength(50);

            this.Property(t => t.MATERIAL)
                .HasMaxLength(50);

            this.Property(t => t.UNITID)
                .HasMaxLength(50);

            this.Property(t => t.BLARGESSFLAG)
                .HasMaxLength(50);

            this.Property(t => t.CURRTYPE)
                .HasMaxLength(50);

            this.Property(t => t.NTAXRATE)
                .HasMaxLength(50);

            this.Property(t => t.DOCTOR)
                .HasMaxLength(50);

            this.Property(t => t.DOCTORPROV)
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

            this.Property(t => t.SALEORDERID)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.ORDERORG)
                .HasMaxLength(50);

            this.Property(t => t.ORDERNO)
                .HasMaxLength(101);

            this.Property(t => t.SENDORG)
                .HasMaxLength(101);

            this.Property(t => t.SRCTRANTYPE)
                .HasMaxLength(101);

            this.Property(t => t.ORDERDATE)
                .HasMaxLength(101);

            this.Property(t => t.ISDEL)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SO_MIDDLE_SALEORDER_B", "DI");
            this.Property(t => t.SALEORDERBID).HasColumnName("SALEORDERBID");
            this.Property(t => t.SENDNO).HasColumnName("SENDNO");
            this.Property(t => t.RESENDNO).HasColumnName("RESENDNO");
            this.Property(t => t.CROWNO).HasColumnName("CROWNO");
            this.Property(t => t.MATERIAL).HasColumnName("MATERIAL");
            this.Property(t => t.UNITID).HasColumnName("UNITID");
            this.Property(t => t.BLARGESSFLAG).HasColumnName("BLARGESSFLAG");
            this.Property(t => t.PRICE).HasColumnName("PRICE");
            this.Property(t => t.CURRTYPE).HasColumnName("CURRTYPE");
            this.Property(t => t.ITEMDISCOUNTRATE).HasColumnName("ITEMDISCOUNTRATE");
            this.Property(t => t.NORIGPRICE).HasColumnName("NORIGPRICE");
            this.Property(t => t.NASTNUM).HasColumnName("NASTNUM");
            this.Property(t => t.NTAXRATE).HasColumnName("NTAXRATE");
            this.Property(t => t.DOCTOR).HasColumnName("DOCTOR");
            this.Property(t => t.DOCTORPROV).HasColumnName("DOCTORPROV");
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
            this.Property(t => t.SALEORDERID).HasColumnName("SALEORDERID");
            this.Property(t => t.TS).HasColumnName("TS");
            this.Property(t => t.DR).HasColumnName("DR");
            this.Property(t => t.ORDERORG).HasColumnName("ORDERORG");
            this.Property(t => t.ORDERNO).HasColumnName("ORDERNO");
            this.Property(t => t.SENDORG).HasColumnName("SENDORG");
            this.Property(t => t.SRCTRANTYPE).HasColumnName("SRCTRANTYPE");
            this.Property(t => t.ORDERDATE).HasColumnName("ORDERDATE");
            this.Property(t => t.SHJE).HasColumnName("SHJE");
            this.Property(t => t.RECDATE).HasColumnName("RECDATE");
            this.Property(t => t.ISDEL).HasColumnName("ISDEL");
        }
    }
}
