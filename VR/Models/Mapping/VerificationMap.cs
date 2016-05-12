using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class VerificationMap : EntityTypeConfiguration<Verification>
    {
        public VerificationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Verifications");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.PicturesUrl).HasColumnName("PicturesUrl");
            this.Property(t => t.PledgeCommitmentId).HasColumnName("PledgeCommitmentId");
            this.Property(t => t.VideoUrl).HasColumnName("VideoUrl");

            // Relationships
            this.HasRequired(t => t.PledgeCommitment)
                .WithOptional(t => t.Verification);

        }
    }
}
