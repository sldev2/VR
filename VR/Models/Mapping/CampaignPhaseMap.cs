using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class CampaignPhaseMap : EntityTypeConfiguration<CampaignPhase>
    {
        public CampaignPhaseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CampaignPhases");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Redline).HasColumnName("Redline");
            this.Property(t => t.Campaign_Id).HasColumnName("Campaign_Id");
            this.Property(t => t.VoteslingerPrimaryDeadline).HasColumnName("VoteslingerPrimaryDeadline");
            this.Property(t => t.VoteslingerGeneralDeadline).HasColumnName("VoteslingerGeneralDeadline");
            this.Property(t => t.PledgeDeadline).HasColumnName("PledgeDeadline");
            this.Property(t => t.PledgeFulfillmentDeadline).HasColumnName("PledgeFulfillmentDeadline");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Relationships
            this.HasOptional(t => t.Campaign)
                .WithMany(t => t.CampaignPhases)
                .HasForeignKey(d => d.Campaign_Id);

        }
    }
}
