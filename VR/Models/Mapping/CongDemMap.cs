using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class CongDemMap : EntityTypeConfiguration<CongDem>
    {
        public CongDemMap()
        {
            // Primary Key
            this.HasKey(t => t.State);

            // Properties
            this.Property(t => t.State)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CongDem");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.PDate).HasColumnName("PDate");
        }
    }
}
