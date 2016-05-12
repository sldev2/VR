using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class DefaultPledgeMap : EntityTypeConfiguration<DefaultPledge>
    {
        public DefaultPledgeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("DefaultPledges");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Template).HasColumnName("Template");
            this.Property(t => t.TemplateNoTargetRegion).HasColumnName("TemplateNoTargetRegion");
            this.Property(t => t.TemplateNotIncumbent).HasColumnName("TemplateNotIncumbent");
            this.Property(t => t.TemplateNotIncumbentNoTargetRegion).HasColumnName("TemplateNotIncumbentNoTargetRegion");
            this.Property(t => t.PledgeType).HasColumnName("PledgeType");
        }
    }
}
