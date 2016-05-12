using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class PrezDemMap : EntityTypeConfiguration<PrezDem>
    {
        public PrezDemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.State, t.PDate });

            // Properties
            this.Property(t => t.State)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PrezDem");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.PDate).HasColumnName("PDate");
        }
    }
}
