using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class GovernmentLevelMap : EntityTypeConfiguration<GovernmentLevel>
    {
        public GovernmentLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Abbr2)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Abbr3)
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("GovernmentLevels");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Abbr2).HasColumnName("Abbr2");
            this.Property(t => t.Abbr3).HasColumnName("Abbr3");
        }
    }
}
