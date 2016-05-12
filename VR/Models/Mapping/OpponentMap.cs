using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class OpponentMap : EntityTypeConfiguration<Opponent>
    {
        public OpponentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Opponents");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CampaignUrl).HasColumnName("CampaignUrl");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.GovernmentLevelId).HasColumnName("GovernmentLevelId");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GeneralElectionDate).HasColumnName("GeneralElectionDate");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Party).HasColumnName("Party");
            this.Property(t => t.WithdrawalDate).HasColumnName("WithdrawalDate");

            // Relationships
            this.HasMany(t => t.Targets)
                .WithMany(t => t.Opponents)
                .Map(m =>
                    {
                        m.ToTable("TargetOpponents");
                        m.MapLeftKey("OpponentId");
                        m.MapRightKey("TargetId");
                    });

            this.HasRequired(t => t.Country)
                .WithMany(t => t.Opponents)
                .HasForeignKey(d => d.CountryId);
            this.HasRequired(t => t.GovernmentLevel)
                .WithMany(t => t.Opponents)
                .HasForeignKey(d => d.GovernmentLevelId);
            this.HasRequired(t => t.House)
                .WithMany(t => t.Opponents)
                .HasForeignKey(d => d.HouseId);

        }
    }
}
