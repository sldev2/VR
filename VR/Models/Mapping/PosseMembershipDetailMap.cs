using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class PosseMembershipDetailMap : EntityTypeConfiguration<PosseMembershipDetail>
    {
        public PosseMembershipDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdentityUserId, t.PosseId });

            // Properties
            this.Property(t => t.PosseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosseMembershipDetails");
            this.Property(t => t.IdentityUserId).HasColumnName("IdentityUserId");
            this.Property(t => t.PosseId).HasColumnName("PosseId");
            this.Property(t => t.DateJoined).HasColumnName("DateJoined");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsDeputy).HasColumnName("IsDeputy");
            this.Property(t => t.IsJoiner).HasColumnName("IsJoiner");
            this.Property(t => t.IsSheriff).HasColumnName("IsSheriff");
            this.Property(t => t.IsSocial).HasColumnName("IsSocial");
            this.Property(t => t.MemberType).HasColumnName("MemberType");
            this.Property(t => t.ReasonJoined).HasColumnName("ReasonJoined");

            // Relationships
            this.HasRequired(t => t.Poss)
                .WithMany(t => t.PosseMembershipDetails)
                .HasForeignKey(d => d.PosseId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.PosseMembershipDetails)
                .HasForeignKey(d => d.IdentityUserId);

        }
    }
}
