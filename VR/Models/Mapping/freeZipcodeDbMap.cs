using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class freeZipcodeDbMap : EntityTypeConfiguration<freeZipcodeDb>
    {
        public freeZipcodeDbMap()
        {
            // Primary Key
            this.HasKey(t => t.Decommisioned);

            // Properties
            this.Property(t => t.ZipCodeType)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .HasMaxLength(255);

            this.Property(t => t.State)
                .HasMaxLength(255);

            this.Property(t => t.LocationType)
                .HasMaxLength(255);

            this.Property(t => t.Location)
                .HasMaxLength(255);

            this.Property(t => t.TaxReturnsFiled)
                .HasMaxLength(255);

            this.Property(t => t.EstimatedPopulation)
                .HasMaxLength(255);

            this.Property(t => t.TotalWages)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("freeZipcodeDb");
            this.Property(t => t.Zipcode).HasColumnName("Zipcode");
            this.Property(t => t.ZipCodeType).HasColumnName("ZipCodeType");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.LocationType).HasColumnName("LocationType");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Long).HasColumnName("Long");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Decommisioned).HasColumnName("Decommisioned");
            this.Property(t => t.TaxReturnsFiled).HasColumnName("TaxReturnsFiled");
            this.Property(t => t.EstimatedPopulation).HasColumnName("EstimatedPopulation");
            this.Property(t => t.TotalWages).HasColumnName("TotalWages");
        }
    }
}
