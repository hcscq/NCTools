using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class DBASE_ITEM_MSG_ORGMap : EntityTypeConfiguration<DBASE_ITEM_MSG_ORG>
    {
        public DBASE_ITEM_MSG_ORGMap()
        {
            // Primary Key
            this.HasKey(t =>new { t.GOODS_NO, t.ORG });
            //this.HasKey(t=>t.ORG);

             //Properties
            this.Property(t => t.OUTPUT_TAX)
                .IsRequired();

            this.Property(t => t.COMMON_NAME)
                .HasMaxLength(300);

            this.Property(t => t.DAMAGE_TREATMENT)
                .HasMaxLength(100);

            this.Property(t => t.FULL_NAME)
                .HasMaxLength(500);

            this.Property(t => t.GOODS_CODE)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.GOODS_NO)
                .HasMaxLength(80);

            this.Property(t => t.ORG)
                .HasMaxLength(60);

            this.Property(t => t.RECDATE);

            this.Property(t => t.RID)
                .HasMaxLength(80);

            this.Property(t => t.SHBIT);

            this.Property(t => t.SPACETIME_ONE_LEVEL)
                .HasMaxLength(50);

            this.Property(t => t.SPACETIME_ONE_LEVEL_NAME)
                .HasMaxLength(200);

            this.Property(t => t.SPACETIME_THREE_LEVEL)
                .HasMaxLength(50);

            this.Property(t => t.SPACETIME_THREE_LEVEL_NAME)
                .HasMaxLength(200);

            this.Property(t => t.SPACETIME_TWO_LEVEL)
                .HasMaxLength(101);

            this.Property(t => t.SPACETIME_TWO_LEVEL_NAME)
                .HasMaxLength(200);

            this.Property(t => t.UNITCODE)
                .HasMaxLength(101);

            this.Property(t => t.UNITNAME)
                .HasMaxLength(101);

            this.Property(t => t.UPDATE_TIME);


            // Table & Column Mappings
            this.ToTable("DBASE_ITEM_MSG_ORG", "DI");
            this.Property(t => t.COMMON_NAME).HasColumnName("COMMON_NAME");
            this.Property(t => t.DAMAGE_TREATMENT).HasColumnName("DAMAGE_TREATMENT");
            this.Property(t => t.FULL_NAME).HasColumnName("FULL_NAME");
            this.Property(t => t.GOODS_CODE).HasColumnName("GOODS_CODE");
            this.Property(t => t.GOODS_NO).HasColumnName("GOODS_NO");
            this.Property(t => t.ORG).HasColumnName("ORG");
            this.Property(t => t.OUTPUT_TAX).HasColumnName("OUTPUT_TAX");
            this.Property(t => t.RECDATE).HasColumnName("RECDATE");
            this.Property(t => t.RID).HasColumnName("RID");
            this.Property(t => t.SHBIT).HasColumnName("SHBIT");
            this.Property(t => t.SPACETIME_ONE_LEVEL).HasColumnName("SPACETIME_ONE_LEVEL");
            this.Property(t => t.SPACETIME_ONE_LEVEL_NAME).HasColumnName("SPACETIME_ONE_LEVEL_NAME");
            this.Property(t => t.SPACETIME_THREE_LEVEL).HasColumnName("SPACETIME_THREE_LEVEL");
            this.Property(t => t.SPACETIME_THREE_LEVEL_NAME).HasColumnName("SPACETIME_THREE_LEVEL_NAME");
            this.Property(t => t.SPACETIME_TWO_LEVEL).HasColumnName("SPACETIME_TWO_LEVEL");
            this.Property(t => t.SPACETIME_TWO_LEVEL_NAME).HasColumnName("SPACETIME_TWO_LEVEL_NAME");
            this.Property(t => t.UNITCODE).HasColumnName("UNITCODE");
            this.Property(t => t.UNITNAME).HasColumnName("UNITNAME");
            this.Property(t => t.UPDATE_TIME).HasColumnName("UPDATE_TIME");
        }
    }
}
