using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class Target_TemplateInfoMap : EntityTypeConfiguration<Target_TemplateInfo>
    {
        public Target_TemplateInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.Party, t.IsIncumbent, t.IsActive, t.GovernmentLevelId, t.HouseId, t.GeneralElectionDate, t.IsBadOnTPP, t.IsGoodOnTPP });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Party)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Region)
                .HasMaxLength(20);

            this.Property(t => t.GovernmentLevelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Target_TemplateInfo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Party).HasColumnName("Party");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.IsIncumbent).HasColumnName("IsIncumbent");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.GovernmentLevelId).HasColumnName("GovernmentLevelId");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.GeneralElectionDate).HasColumnName("GeneralElectionDate");
            this.Property(t => t.PrimaryDate).HasColumnName("PrimaryDate");
            this.Property(t => t.ConventionDate).HasColumnName("ConventionDate");
            this.Property(t => t.IsBadOnTPP).HasColumnName("IsBadOnTPP");
            this.Property(t => t.IsGoodOnTPP).HasColumnName("IsGoodOnTPP");
            this.Property(t => t.TPPGoodBadReason).HasColumnName("TPPGoodBadReason");
        }
    }
}
