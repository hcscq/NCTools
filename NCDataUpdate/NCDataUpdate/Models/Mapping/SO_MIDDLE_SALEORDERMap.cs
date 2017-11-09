using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class SO_MIDDLE_SALEORDERMap : EntityTypeConfiguration<SO_MIDDLE_SALEORDER>
    {
        public SO_MIDDLE_SALEORDERMap()
        {
            // Primary Key
            this.HasKey(t => t.SALEORDERID);

            // Properties
            this.Property(t => t.SALEORDERID)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.ORDERNO)
                .HasMaxLength(80);

            this.Property(t => t.ORDERDATE)
                .HasMaxLength(80);

            this.Property(t => t.ORDERORG)
                .HasMaxLength(80);

            this.Property(t => t.SENDORG)
                .HasMaxLength(80);

            this.Property(t => t.SENDSTORDOC)
                .HasMaxLength(80);

            this.Property(t => t.SENDPOINT)
                .HasMaxLength(80);

            this.Property(t => t.SENDNO)
                .HasMaxLength(80);

            this.Property(t => t.RESENDNO)
                .HasMaxLength(80);

            this.Property(t => t.SENDDATE)
                .HasMaxLength(80);

            this.Property(t => t.CUSTOMER)
                .HasMaxLength(500);

            this.Property(t => t.CHRECEIVECUSTID)
                .HasMaxLength(500);

            this.Property(t => t.CINVOICECUSTID)
                .HasMaxLength(500);

            this.Property(t => t.RETPROVINCE)
                .HasMaxLength(80);

            this.Property(t => t.EXPRESS)
                .HasMaxLength(500);

            this.Property(t => t.PAYMETHOD)
                .HasMaxLength(80);

            this.Property(t => t.PAYMENT)
                .HasMaxLength(80);

            this.Property(t => t.BELONGDPT)
                .HasMaxLength(80);

            this.Property(t => t.SRCTRANTYPE)
                .HasMaxLength(80);

            this.Property(t => t.GUIDEID)
                .HasMaxLength(500);

            this.Property(t => t.SRCSYS)
                .HasMaxLength(80);

            this.Property(t => t.SRCID)
                .HasMaxLength(80);

            this.Property(t => t.NCTRANTYPE)
                .HasMaxLength(80);

            this.Property(t => t.NCFLAG)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NCBILLCODE)
                .HasMaxLength(50);

            this.Property(t => t.VDEF1)
                .HasMaxLength(200);

            this.Property(t => t.VDEF2)
                .HasMaxLength(200);

            this.Property(t => t.VDEF3)
                .HasMaxLength(200);

            this.Property(t => t.VDEF4)
                .HasMaxLength(200);

            this.Property(t => t.VDEF5)
                .HasMaxLength(200);

            this.Property(t => t.VDEF6)
                .HasMaxLength(200);

            this.Property(t => t.VDEF7)
                .HasMaxLength(200);

            this.Property(t => t.VDEF8)
                .HasMaxLength(200);

            this.Property(t => t.VDEF9)
                .HasMaxLength(200);

            this.Property(t => t.VDEF10)
                .HasMaxLength(200);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.EXPRESSNO)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SO_MIDDLE_SALEORDER", "DI");
            this.Property(t => t.SALEORDERID).HasColumnName("SALEORDERID");
            this.Property(t => t.ORDERNO).HasColumnName("ORDERNO");
            this.Property(t => t.ORDERDATE).HasColumnName("ORDERDATE");
            this.Property(t => t.ORDERORG).HasColumnName("ORDERORG");
            this.Property(t => t.SENDORG).HasColumnName("SENDORG");
            this.Property(t => t.SENDSTORDOC).HasColumnName("SENDSTORDOC");
            this.Property(t => t.SENDPOINT).HasColumnName("SENDPOINT");
            this.Property(t => t.SENDNO).HasColumnName("SENDNO");
            this.Property(t => t.RESENDNO).HasColumnName("RESENDNO");
            this.Property(t => t.SENDDATE).HasColumnName("SENDDATE");
            this.Property(t => t.CUSTOMER).HasColumnName("CUSTOMER");
            this.Property(t => t.CHRECEIVECUSTID).HasColumnName("CHRECEIVECUSTID");
            this.Property(t => t.CINVOICECUSTID).HasColumnName("CINVOICECUSTID");
            this.Property(t => t.RETPROVINCE).HasColumnName("RETPROVINCE");
            this.Property(t => t.EXPRESS).HasColumnName("EXPRESS");
            this.Property(t => t.PAYMETHOD).HasColumnName("PAYMETHOD");
            this.Property(t => t.PAYMENT).HasColumnName("PAYMENT");
            this.Property(t => t.BELONGDPT).HasColumnName("BELONGDPT");
            this.Property(t => t.FREIGHTTOTAL).HasColumnName("FREIGHTTOTAL");
            this.Property(t => t.DISCOUNTTOTAL).HasColumnName("DISCOUNTTOTAL");
            this.Property(t => t.AMOUNTRECEIVABLE).HasColumnName("AMOUNTRECEIVABLE");
            this.Property(t => t.AMOUNTTOTAL).HasColumnName("AMOUNTTOTAL");
            this.Property(t => t.GOODSPREFER).HasColumnName("GOODSPREFER");
            this.Property(t => t.PAYPREFER).HasColumnName("PAYPREFER");
            this.Property(t => t.CASHCOUPON).HasColumnName("CASHCOUPON");
            this.Property(t => t.GIFTCOUPON).HasColumnName("GIFTCOUPON");
            this.Property(t => t.SRCTRANTYPE).HasColumnName("SRCTRANTYPE");
            this.Property(t => t.GUIDEID).HasColumnName("GUIDEID");
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
            this.Property(t => t.EXPRESSNO).HasColumnName("EXPRESSNO");
        }
    }
}
