using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class CampaignMap : EntityTypeConfiguration<Campaign>
    {
        public CampaignMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TargetMacroRegion)
                .IsRequired();

            this.Property(t => t.TargetElectoralRegionName)
                .IsRequired();

            this.Property(t => t.TargetElectoralRegionAbbreviation)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Campaigns");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsMultiphasic).HasColumnName("IsMultiphasic");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Issue).HasColumnName("Issue");
            this.Property(t => t.PosseId).HasColumnName("PosseId");
            this.Property(t => t.UltimateRedline).HasColumnName("UltimateRedline");
            this.Property(t => t.Info).HasColumnName("Info");
            this.Property(t => t.IsPresidential).HasColumnName("IsPresidential");
            this.Property(t => t.ElectionYear).HasColumnName("ElectionYear");
            this.Property(t => t.PrimaryDate).HasColumnName("PrimaryDate");
            this.Property(t => t.GeneralDate).HasColumnName("GeneralDate");
            this.Property(t => t.TargetMacroRegion).HasColumnName("TargetMacroRegion");
            this.Property(t => t.TargetElectoralRegionName).HasColumnName("TargetElectoralRegionName");
            this.Property(t => t.TargetElectoralRegionAbbreviation).HasColumnName("TargetElectoralRegionAbbreviation");

            // Relationships
            this.HasRequired(t => t.Poss)
                .WithMany(t => t.Campaigns)
                .HasForeignKey(d => d.PosseId);

        }
    }
}
