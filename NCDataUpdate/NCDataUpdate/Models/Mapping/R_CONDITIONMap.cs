using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NCDataUpdate.Models.Mapping
{
    public class R_CONDITIONMap : EntityTypeConfiguration<R_CONDITION>
    {
        public R_CONDITIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_CONDITION);

            // Properties
            this.Property(t => t.ID_CONDITION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NEGATED)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OPERATOR)
                .HasMaxLength(255);

            this.Property(t => t.LEFT_NAME)
                .HasMaxLength(255);

            this.Property(t => t.CONDITION_FUNCTION)
                .HasMaxLength(255);

            this.Property(t => t.RIGHT_NAME)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_CONDITION", "DI");
            this.Property(t => t.ID_CONDITION).HasColumnName("ID_CONDITION");
            this.Property(t => t.ID_CONDITION_PARENT).HasColumnName("ID_CONDITION_PARENT");
            this.Property(t => t.NEGATED).HasColumnName("NEGATED");
            this.Property(t => t.OPERATOR).HasColumnName("OPERATOR");
            this.Property(t => t.LEFT_NAME).HasColumnName("LEFT_NAME");
            this.Property(t => t.CONDITION_FUNCTION).HasColumnName("CONDITION_FUNCTION");
            this.Property(t => t.RIGHT_NAME).HasColumnName("RIGHT_NAME");
            this.Property(t => t.ID_VALUE_RIGHT).HasColumnName("ID_VALUE_RIGHT");
        }
    }
}
