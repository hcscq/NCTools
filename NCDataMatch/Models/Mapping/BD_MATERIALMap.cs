using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataMatch.Models.Mapping
{
    public class BD_MATERIALMap : EntityTypeConfiguration<BD_MATERIAL>
    {
        public BD_MATERIALMap()
        {
            // Primary Key
            this.HasKey(t => t.PK_MATERIAL);

            // Properties
            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CREATIONTIME)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.CREATOR)
                .HasMaxLength(20);

            this.Property(t => t.DEF1)
                .HasMaxLength(101);

            this.Property(t => t.DEF10)
                .HasMaxLength(101);

            this.Property(t => t.DEF11)
                .HasMaxLength(101);

            this.Property(t => t.DEF12)
                .HasMaxLength(101);

            this.Property(t => t.DEF13)
                .HasMaxLength(101);

            this.Property(t => t.DEF14)
                .HasMaxLength(101);

            this.Property(t => t.DEF15)
                .HasMaxLength(101);

            this.Property(t => t.DEF16)
                .HasMaxLength(101);

            this.Property(t => t.DEF17)
                .HasMaxLength(101);

            this.Property(t => t.DEF18)
                .HasMaxLength(101);

            this.Property(t => t.DEF19)
                .HasMaxLength(101);

            this.Property(t => t.DEF2)
                .HasMaxLength(101);

            this.Property(t => t.DEF20)
                .HasMaxLength(101);

            this.Property(t => t.DEF3)
                .HasMaxLength(101);

            this.Property(t => t.DEF4)
                .HasMaxLength(101);

            this.Property(t => t.DEF5)
                .HasMaxLength(101);

            this.Property(t => t.DEF6)
                .HasMaxLength(101);

            this.Property(t => t.DEF7)
                .HasMaxLength(101);

            this.Property(t => t.DEF8)
                .HasMaxLength(101);

            this.Property(t => t.DEF9)
                .HasMaxLength(101);

            this.Property(t => t.DELPERSON)
                .HasMaxLength(20);

            this.Property(t => t.DELTIME)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.DISCOUNTFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ELECTRONICSALE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EMATERIALSPEC)
                .HasMaxLength(400);

            this.Property(t => t.ENAME)
                .HasMaxLength(200);

            this.Property(t => t.FEATURECLASS)
                .HasMaxLength(20);

            this.Property(t => t.FEE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GOODSPRTNAME)
                .HasMaxLength(200);

            this.Property(t => t.GRAPHID)
                .HasMaxLength(50);

            this.Property(t => t.ISELECTRANS)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ISFEATURE)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ISHPROITEMS)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LATEST)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MATERIALBARCODE)
                .HasMaxLength(30);

            this.Property(t => t.MATERIALMNECODE)
                .HasMaxLength(50);

            this.Property(t => t.MATERIALSHORTNAME)
                .HasMaxLength(300);

            this.Property(t => t.MATERIALSPEC)
                .HasMaxLength(400);

            this.Property(t => t.MATERIALTYPE)
                .HasMaxLength(400);

            this.Property(t => t.MEMO)
                .HasMaxLength(150);

            this.Property(t => t.MODIFIEDTIME)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.MODIFIER)
                .HasMaxLength(20);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.NAME2)
                .HasMaxLength(300);

            this.Property(t => t.NAME3)
                .HasMaxLength(300);

            this.Property(t => t.NAME4)
                .HasMaxLength(300);

            this.Property(t => t.NAME5)
                .HasMaxLength(300);

            this.Property(t => t.NAME6)
                .HasMaxLength(300);

            this.Property(t => t.PK_BRAND)
                .HasMaxLength(20);

            this.Property(t => t.PK_GOODSCODE)
                .HasMaxLength(20);

            this.Property(t => t.PK_GROUP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PK_MARASSTFRAME)
                .HasMaxLength(20);

            this.Property(t => t.PK_MARBASCLASS)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PK_MATERIAL)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PK_MATERIAL_PF)
                .HasMaxLength(20);

            this.Property(t => t.PK_MATTAXES)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PK_MEASDOC)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PK_ORG)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PK_PRODLINE)
                .HasMaxLength(20);

            this.Property(t => t.PK_SOURCE)
                .HasMaxLength(20);

            this.Property(t => t.PK_TAXITEMS)
                .HasMaxLength(20);

            this.Property(t => t.PRODAREA)
                .HasMaxLength(20);

            this.Property(t => t.PRODUCTFAMILY)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RETAIL)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SETPARTSFLAG)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TS)
                .IsFixedLength()
                .HasMaxLength(19);

            this.Property(t => t.UNITHEIGHT)
                .HasMaxLength(20);

            this.Property(t => t.UNITLENGTH)
                .HasMaxLength(20);

            this.Property(t => t.UNITWIDTH)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("BD_MATERIAL", "NC65");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.CREATIONTIME).HasColumnName("CREATIONTIME");
            this.Property(t => t.CREATOR).HasColumnName("CREATOR");
            this.Property(t => t.DATAORIGINFLAG).HasColumnName("DATAORIGINFLAG");
            this.Property(t => t.DEF1).HasColumnName("DEF1");
            this.Property(t => t.DEF10).HasColumnName("DEF10");
            this.Property(t => t.DEF11).HasColumnName("DEF11");
            this.Property(t => t.DEF12).HasColumnName("DEF12");
            this.Property(t => t.DEF13).HasColumnName("DEF13");
            this.Property(t => t.DEF14).HasColumnName("DEF14");
            this.Property(t => t.DEF15).HasColumnName("DEF15");
            this.Property(t => t.DEF16).HasColumnName("DEF16");
            this.Property(t => t.DEF17).HasColumnName("DEF17");
            this.Property(t => t.DEF18).HasColumnName("DEF18");
            this.Property(t => t.DEF19).HasColumnName("DEF19");
            this.Property(t => t.DEF2).HasColumnName("DEF2");
            this.Property(t => t.DEF20).HasColumnName("DEF20");
            this.Property(t => t.DEF3).HasColumnName("DEF3");
            this.Property(t => t.DEF4).HasColumnName("DEF4");
            this.Property(t => t.DEF5).HasColumnName("DEF5");
            this.Property(t => t.DEF6).HasColumnName("DEF6");
            this.Property(t => t.DEF7).HasColumnName("DEF7");
            this.Property(t => t.DEF8).HasColumnName("DEF8");
            this.Property(t => t.DEF9).HasColumnName("DEF9");
            this.Property(t => t.DELETESTATE).HasColumnName("DELETESTATE");
            this.Property(t => t.DELPERSON).HasColumnName("DELPERSON");
            this.Property(t => t.DELTIME).HasColumnName("DELTIME");
            this.Property(t => t.DISCOUNTFLAG).HasColumnName("DISCOUNTFLAG");
            this.Property(t => t.DR).HasColumnName("DR");
            this.Property(t => t.ELECTRONICSALE).HasColumnName("ELECTRONICSALE");
            this.Property(t => t.EMATERIALSPEC).HasColumnName("EMATERIALSPEC");
            this.Property(t => t.ENABLESTATE).HasColumnName("ENABLESTATE");
            this.Property(t => t.ENAME).HasColumnName("ENAME");
            this.Property(t => t.FEATURECLASS).HasColumnName("FEATURECLASS");
            this.Property(t => t.FEE).HasColumnName("FEE");
            this.Property(t => t.GOODSPRTNAME).HasColumnName("GOODSPRTNAME");
            this.Property(t => t.GRAPHID).HasColumnName("GRAPHID");
            this.Property(t => t.INTOLERANCE).HasColumnName("INTOLERANCE");
            this.Property(t => t.ISELECTRANS).HasColumnName("ISELECTRANS");
            this.Property(t => t.ISFEATURE).HasColumnName("ISFEATURE");
            this.Property(t => t.ISHPROITEMS).HasColumnName("ISHPROITEMS");
            this.Property(t => t.LATEST).HasColumnName("LATEST");
            this.Property(t => t.MATERIALBARCODE).HasColumnName("MATERIALBARCODE");
            this.Property(t => t.MATERIALMGT).HasColumnName("MATERIALMGT");
            this.Property(t => t.MATERIALMNECODE).HasColumnName("MATERIALMNECODE");
            this.Property(t => t.MATERIALSHORTNAME).HasColumnName("MATERIALSHORTNAME");
            this.Property(t => t.MATERIALSPEC).HasColumnName("MATERIALSPEC");
            this.Property(t => t.MATERIALTYPE).HasColumnName("MATERIALTYPE");
            this.Property(t => t.MEMO).HasColumnName("MEMO");
            this.Property(t => t.MODIFIEDTIME).HasColumnName("MODIFIEDTIME");
            this.Property(t => t.MODIFIER).HasColumnName("MODIFIER");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.NAME2).HasColumnName("NAME2");
            this.Property(t => t.NAME3).HasColumnName("NAME3");
            this.Property(t => t.NAME4).HasColumnName("NAME4");
            this.Property(t => t.NAME5).HasColumnName("NAME5");
            this.Property(t => t.NAME6).HasColumnName("NAME6");
            this.Property(t => t.OUTCLOSELOWERLIMIT).HasColumnName("OUTCLOSELOWERLIMIT");
            this.Property(t => t.OUTTOLERANCE).HasColumnName("OUTTOLERANCE");
            this.Property(t => t.PK_BRAND).HasColumnName("PK_BRAND");
            this.Property(t => t.PK_GOODSCODE).HasColumnName("PK_GOODSCODE");
            this.Property(t => t.PK_GROUP).HasColumnName("PK_GROUP");
            this.Property(t => t.PK_MARASSTFRAME).HasColumnName("PK_MARASSTFRAME");
            this.Property(t => t.PK_MARBASCLASS).HasColumnName("PK_MARBASCLASS");
            this.Property(t => t.PK_MATERIAL).HasColumnName("PK_MATERIAL");
            this.Property(t => t.PK_MATERIAL_PF).HasColumnName("PK_MATERIAL_PF");
            this.Property(t => t.PK_MATTAXES).HasColumnName("PK_MATTAXES");
            this.Property(t => t.PK_MEASDOC).HasColumnName("PK_MEASDOC");
            this.Property(t => t.PK_ORG).HasColumnName("PK_ORG");
            this.Property(t => t.PK_PRODLINE).HasColumnName("PK_PRODLINE");
            this.Property(t => t.PK_SOURCE).HasColumnName("PK_SOURCE");
            this.Property(t => t.PK_TAXITEMS).HasColumnName("PK_TAXITEMS");
            this.Property(t => t.PRODAREA).HasColumnName("PRODAREA");
            this.Property(t => t.PRODUCTFAMILY).HasColumnName("PRODUCTFAMILY");
            this.Property(t => t.PROLIFEPERIOD).HasColumnName("PROLIFEPERIOD");
            this.Property(t => t.RETAIL).HasColumnName("RETAIL");
            this.Property(t => t.SETPARTSFLAG).HasColumnName("SETPARTSFLAG");
            this.Property(t => t.STOREUNITNUM).HasColumnName("STOREUNITNUM");
            this.Property(t => t.TS).HasColumnName("TS");
            this.Property(t => t.UNITHEIGHT).HasColumnName("UNITHEIGHT");
            this.Property(t => t.UNITLENGTH).HasColumnName("UNITLENGTH");
            this.Property(t => t.UNITVOLUME).HasColumnName("UNITVOLUME");
            this.Property(t => t.UNITWEIGHT).HasColumnName("UNITWEIGHT");
            this.Property(t => t.UNITWIDTH).HasColumnName("UNITWIDTH");
            this.Property(t => t.VERSION).HasColumnName("VERSION");
        }
    }
}
