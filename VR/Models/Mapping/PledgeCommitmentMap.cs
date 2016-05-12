using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class PledgeCommitmentMap : EntityTypeConfiguration<PledgeCommitment>
    {
        public PledgeCommitmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PledgeCommitments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CampaignPhaseId).HasColumnName("CampaignPhaseId");
            this.Property(t => t.Deadline).HasColumnName("Deadline");
            this.Property(t => t.PersonalPledge).HasColumnName("PersonalPledge");
            this.Property(t => t.DefaultPledgeId).HasColumnName("DefaultPledgeId");
            this.Property(t => t.SelfVerificationScore).HasColumnName("SelfVerificationScore");
            this.Property(t => t.PosseMembershipDetail_IdentityUserId).HasColumnName("PosseMembershipDetail_IdentityUserId");
            this.Property(t => t.PosseMembershipDetail_PosseId).HasColumnName("PosseMembershipDetail_PosseId");
            this.Property(t => t.PledgeType).HasColumnName("PledgeType");
            this.Property(t => t.FulfillmentDeadline).HasColumnName("FulfillmentDeadline");

            // Relationships
            this.HasOptional(t => t.PosseMembershipDetail)
                .WithMany(t => t.PledgeCommitments)
                .HasForeignKey(d => new { d.PosseMembershipDetail_IdentityUserId, d.PosseMembershipDetail_PosseId });

        }
    }
}
