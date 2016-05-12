using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class PossMap : EntityTypeConfiguration<Poss>
    {
        public PossMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Discriminator)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Posses");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Info).HasColumnName("Info");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TargetId).HasColumnName("TargetId");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.PosseId).HasColumnName("PosseId");
            this.Property(t => t.ZipCode1).HasColumnName("ZipCode1");
            this.Property(t => t.Discriminator).HasColumnName("Discriminator");
            this.Property(t => t.CoralinSuperPosse_Id).HasColumnName("CoralinSuperPosse_Id");
            this.Property(t => t.m_CoralinPosse_Id).HasColumnName("m_CoralinPosse_Id");
            this.Property(t => t.SuperPosse_Id).HasColumnName("SuperPosse_Id");

            // Relationships
            this.HasOptional(t => t.Poss1)
                .WithMany(t => t.Posses1)
                .HasForeignKey(d => d.CoralinSuperPosse_Id);
            this.HasOptional(t => t.Poss2)
                .WithMany(t => t.Posses11)
                .HasForeignKey(d => d.m_CoralinPosse_Id);
            this.HasOptional(t => t.Poss3)
                .WithMany(t => t.Posses12)
                .HasForeignKey(d => d.PosseId);
            this.HasOptional(t => t.Poss4)
                .WithMany(t => t.Posses13)
                .HasForeignKey(d => d.SuperPosse_Id);
            this.HasRequired(t => t.Target)
                .WithMany(t => t.Posses)
                .HasForeignKey(d => d.TargetId);

        }
    }
}
