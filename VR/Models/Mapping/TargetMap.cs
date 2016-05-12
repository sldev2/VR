using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class TargetMap : EntityTypeConfiguration<Target>
    {
        public TargetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Targets");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.GovernmentLevelId).HasColumnName("GovernmentLevelId");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GeneralElectionDate).HasColumnName("GeneralElectionDate");
            this.Property(t => t.PrimaryDate).HasColumnName("PrimaryDate");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.Party).HasColumnName("Party");
            this.Property(t => t.IsIncumbent).HasColumnName("IsIncumbent");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Targets)
                .HasForeignKey(d => d.CountryId);
            this.HasRequired(t => t.GovernmentLevel)
                .WithMany(t => t.Targets)
                .HasForeignKey(d => d.GovernmentLevelId);
            this.HasRequired(t => t.House)
                .WithMany(t => t.Targets)
                .HasForeignKey(d => d.HouseId);

        }
    }
}
