using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class ClaimDataMap : EntityTypeConfiguration<ClaimData>
    {
        public ClaimDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ClaimId);

            // Properties
            this.Property(t => t.ClaimType)
                .HasMaxLength(4000);

            this.Property(t => t.ClaimValue)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("ClaimData");
            this.Property(t => t.ClaimId).HasColumnName("ClaimId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ClaimType).HasColumnName("ClaimType");
            this.Property(t => t.ClaimValue).HasColumnName("ClaimValue");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.ClaimDatas)
                .HasForeignKey(d => d.UserId);

        }
    }
}
