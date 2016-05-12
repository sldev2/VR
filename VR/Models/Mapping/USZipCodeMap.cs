using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VR.Models.Mapping
{
    public class USZipCodeMap : EntityTypeConfiguration<USZipCode>
    {
        public USZipCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ZipCode);

            // Properties
            this.Property(t => t.ZipCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.State)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("USZipCode");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lng).HasColumnName("Lng");
            this.Property(t => t.GeoPoint).HasColumnName("GeoPoint");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
